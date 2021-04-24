using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventObj : MonoBehaviour
{
    GameObject Inventory;
    GameObject InventoryM;
    GameObject InventoryE;
    Core core;
    Material material;
    Equipment equipment;
    GameObject InventoryButton;
    GameObject ItemTarget;
    Camera cam;
    Vector3 target = new Vector3(0, 0, 0);
    Vector3 Retarget = new Vector3(0, 0, 0);
    Vector3 Original = new Vector3(0, 0, 0);
    Vector3 TempCheck = new Vector3(0, 0, 0);
    int count = 0;
    int count_Destroy = 0;
    bool SetValue = false;

    public GameObject OriginalParent;
    // Start is called before the first frame update
    void Start()
    {
        InventoryButton = GameObject.Find("ButtonInventory");
        cam = GameObject.Find("Camera1").GetComponent<Camera>();
        //target = InventoryButton.transform.position;
        
    }

    void Awake()
    {
        Inventory = GameObject.Find("CoreInventory");
        InventoryE = GameObject.Find("EquipmentInventory");
        InventoryM = GameObject.Find("MaterialInventory");

        
    }


    void OnEnable()

    {
        Invoke("OnMouseDown", 3);

    }


    void OnMouseDown()
{

        core = this.GetComponent<filedCore>().GetCore();
        material = this.GetComponent<FiledMaterial>().GetMaterial();
        equipment = this.GetComponent<FiledEq>().GetEquipment();

        if (SetValue == false)
        {
           
            if (core.coreID != 0)
            {
                if (Inventory.GetComponent<CoreInventory>().FindEmptyFirstIndex() != -1)
                {
                    Invoke("Reset", 2);
                    Inventory.GetComponent<CoreInventory>().AddCore(core);
                    this.GetComponent<Rigidbody2D>().gravityScale = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    SetValue = true;
                }


            }
            if(equipment.EquipmentID != 0)
            {
                if(InventoryE.GetComponent<EquipmentInventory>().FindEmptyFirstIndex() != -1)
                {
                    Invoke("Reset", 2);
                    InventoryE.GetComponent<EquipmentInventory>().AddEq(equipment);
                    this.GetComponent<Rigidbody2D>().gravityScale = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    SetValue = true;
                }
                
            }
            if (material.materialID != 0)
            {
                if (InventoryM.GetComponent<MaterialInventory>().FindEmptyFirstIndex() != -1 || InventoryM.GetComponent<MaterialInventory>().IsThereSuchMaterial(material.materialID) == true)
                {
                    Invoke("Reset", 2);
                    material.Amount = 1;
                    InventoryM.GetComponent<MaterialInventory>().AddMaterial(material);
                    this.GetComponent<Rigidbody2D>().gravityScale = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    SetValue = true;
                }
            }

            
        }

    }

     

void Update()
    {

        target = cam.WorldToScreenPoint(InventoryButton.transform.position);
        Retarget = cam.ScreenToWorldPoint(target);

        if (SetValue == true)
        {
          
            TempCheck = transform.position;
            Vector2 velo = Vector2.zero;
            transform.position = Vector2.SmoothDamp(transform.position, Retarget, ref velo, 0.1f);
            if (System.Math.Abs(transform.position.x - Retarget.x) < 1 && System.Math.Abs(transform.position.y - Retarget.y) < 1)
            {
                Reset();
            }

            
        }
    }   

    void Reset()
    {

        this.GetComponent<Rigidbody2D>().gravityScale = 1;
        GetComponent<BoxCollider2D>().enabled = true;
        SetValue = false;
        this.transform.SetParent(OriginalParent.transform);
        this.gameObject.SetActive(false);

    }



}