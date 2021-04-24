using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LunchLongClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IPointerEnterHandler
{
    [SerializeField] AnimationCurve ac;
    private bool pointerDown;
    private float pointerDownTimer;
    public float requireHoldTime;
    public UnityEvent onLongClick;
    public UnityEvent onShortClick;
    public GameObject Desc;
    public GameObject Thrower;
    public GameObject bar;
    GameObject Instant;
    Vector2 Cposition;
    Vector2 Nposition;
    Vector2 SubVec;
    Vector3 startPos;
    Vector3 endPos;
    LineRenderer lr;
    Camera camera;

    // Start is called before the first frame update
    void Start()
    {

        camera = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pointerDown)
        {
            this.transform.GetChild(0).GetChild(0).GetComponent<Image>().fillAmount += 0.01f;

        }

    }
    public void OnPointerDown(PointerEventData eventData)
    {
     
            lr = gameObject.GetComponent<LineRenderer>();

        if (pointerDown == false)
        {
            Cposition = Input.mousePosition;
            Debug.Log(Cposition);
            endPos = camera.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,10);
            lr.SetPosition(0, endPos);
            lr.positionCount = 2;
            lr.useWorldSpace = true;
        }
        pointerDown = true;
        
       
       
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        startPos = camera.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,9);
        lr.SetPosition(1, startPos);
        Reset();
        Instant = Instantiate(Thrower,transform.position,new Quaternion(),null);
        Nposition = Input.mousePosition;
        Debug.Log(Input.mousePosition);
        SubVec = Nposition - Cposition;
        Debug.Log(SubVec.normalized);
        Instant.GetComponent<Rigidbody2D>().velocity = -SubVec.normalized * 20 * this.transform.GetChild(0).GetChild(0).GetComponent<Image>().fillAmount;
        this.transform.GetChild(0).GetChild(0).GetComponent<Image>().fillAmount = 0;

    }
    private void Reset()
    {
        pointerDown = false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }

}


