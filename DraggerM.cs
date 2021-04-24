using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggerM: MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler

{
    [SerializeField] private RectTransform dragRectTransformM;
    [SerializeField] private Canvas canvasM;
    GameObject UICanvasM;
    public GameObject SlotM;
    public int parentIndexM;
    Transform OriginalParentM;
    Vector3 OriginalM = new Vector3(0, 0, 0);
    public void OnBeginDrag(PointerEventData eventData)
    {
        SlotImportM.IsDraggingM = parentIndexM;
        UICanvasM = GameObject.Find("Canvas1");
        this.GetComponent<Image>().raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {

        //transform.GetComponent<SpriteRenderer>().sortingOrder = 3;
        if (GameObject.Find("MaterialInventory").GetComponent<MaterialInventory>().ReturnIndexMaterial(parentIndexM).materialID != 0)
        {
            transform.SetParent(UICanvasM.transform);
            dragRectTransformM.anchoredPosition += eventData.delta / canvasM.scaleFactor;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        SlotImportM.IsDraggingM = -1;
        transform.SetParent(OriginalParentM);
        this.GetComponent<RectTransform>().anchoredPosition = new Vector3(0,0,0);
        this.GetComponent<Image>().raycastTarget = true;
    }


    // Start is called before the first frame update
    void Start()
    {
        dragRectTransformM = this.GetComponent<RectTransform>();
        OriginalParentM = this.transform.parent.GetComponent<Transform>();
        OriginalM = new Vector3(0,0,0);
        SlotM = transform.parent.gameObject;
        parentIndexM = SlotM.transform.GetSiblingIndex();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
