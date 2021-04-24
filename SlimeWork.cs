using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SlimeWork : MonoBehaviour
{
    public GameObject WorkPlace1;
    public int WorkIndex;
    public Material FarmingItem;
    public GameObject SC;
    public GameObject WorkGage;
    public GameObject WhereToPutIn;
    public GameObject FontDB;
    public GameObject Instant;
    public GameObject MoneyInst;
    System.Random ran = new System.Random();
    public GameObject EmptyBag;
    public GameObject FullBag;
    public GameObject Bow;


    Slime SS;

    // Start is called before the first frame update
    void Start()
    {
        WorkPlace1 = GameObject.Find("W1");
        SS = this.GetComponent<SlimeState>().slimeState;
        WorkGage = this.transform.GetChild(5).GetChild(1).GetChild(1).gameObject;
        WhereToPutIn = GameObject.Find("PN");
        MoneyInst = GameObject.Find("MoneyNotificationStore").GetComponent<MoneyFontScrp>().Font2;
        EmptyBag = this.transform.GetChild(6).GetChild(0).gameObject;
        FullBag = this.transform.GetChild(6).GetChild(1).gameObject;
        Bow = this.transform.GetChild(2).GetChild(0).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        
        WorkGage.GetComponent<Image>().fillAmount = GetComponent<SlimeState>().slimeState.WorkTimeNow / GetComponent<SlimeState>().slimeState.WorkTimeNeed;




    }
    void FixedUpdate()
    {
        if(this.GetComponent<Rigidbody2D>().velocity.x > 0.01)
        {
            this.transform.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (this.GetComponent<Rigidbody2D>().velocity.x < -0.01)
        {
            this.transform.GetComponent<SpriteRenderer>().flipX = false;
        }

        if(WorkIndex == 0)
        {
            FullBag.SetActive(false);
            EmptyBag.SetActive(false);
            Bow.SetActive(true);
        }

        if(WorkIndex != 0)
        {
            Bow.SetActive(false);
        }


        this.transform.localRotation = new Quaternion();
        if (WorkIndex != 0)
        {

            if(SS.WorkDone == true)
            {
                FullBag.SetActive(true);
                EmptyBag.SetActive(false);
            }

            else if(SS.WorkDone == false)
            {
                FullBag.SetActive(false);
                EmptyBag.SetActive(true);
            }


            if ((this.GetComponent<Rigidbody2D>().velocity.x) < -SS.MovementSpeed)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(-SS.MovementSpeed, 0, 0);
            }

            if ((this.GetComponent<Rigidbody2D>().velocity.x) > SS.MovementSpeed)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector3(SS.MovementSpeed, 0, 0);
            }



            if (Mathf.Abs(WorkPlace1.transform.position.x - this.transform.position.x) < 1 && SS.WorkDone == false)
            {
                Mining();
            }

            if (Mathf.Abs(WorkPlace1.transform.position.x - this.transform.position.x) > 1 && SS.WorkDone == false)

            {
                GOTOWORKPLACE();

            }

            if (Mathf.Abs(WhereToPutIn.transform.position.x - this.transform.position.x) > 1 && SS.WorkDone == true)
            {
                AfterMine();
                GotoPutIn();
            }

            if(Mathf.Abs(WhereToPutIn.transform.position.x - this.transform.position.x) < 1 && SS.WorkDone == true)
            {
                AfterPutIn();
            }


        }

       
            if (this.GetComponent<Rigidbody2D>().velocity.normalized.x == 0)
            {
                this.GetComponent<Animator>().SetBool("IsMoving", false);
            }
            else if (this.GetComponent<Rigidbody2D>().velocity.normalized.x != 0)
            {
                this.GetComponent<Animator>().SetBool("IsMoving", true);
            
        }
    }

    public void GOTOWORKPLACE()
    {
        if (WorkPlace1.transform.position.x > this.transform.position.x)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(20, 0, 0));

        }
        else if (WorkPlace1.transform.position.x < this.transform.position.x)
        {

            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-20, 0, 0));
        }
    }
    public void Mining()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        this.transform.GetChild(1).GetComponent<Animator>().SetBool("FarmingState", true);
        WorkGage.transform.parent.gameObject.SetActive(true);
        GetComponent<SlimeState>().slimeState.WorkTimeNow += Time.deltaTime;

    }

    public void AfterMine()
    {
        if(WorkGage.transform.parent.gameObject.activeSelf == true)
        {
            WorkGage.transform.parent.gameObject.SetActive(false);

        }
        this.transform.GetChild(1).GetComponent<Animator>().SetBool("FarmingState", false);

    }
    public void GotoPutIn()
    {
        if (WhereToPutIn.transform.position.x < this.transform.position.x)
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(-20, 0, 0));

        }
        else if (WhereToPutIn.transform.position.x > this.transform.position.x)
        {

            this.GetComponent<Rigidbody2D>().AddForce(new Vector3(20, 0, 0));
        }
    }
    public void AfterPutIn()

    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
        SS.WorkTimeNow = 0;
        SS.WorkDone = false;
        CreateMoney(MoneyCalC());
    }


    public int MoneyCalC()
    {
        return Mathf.RoundToInt(SS.LUK * SS.LUK * 0.1f) + Mathf.RoundToInt(ran.Next(1, 100) * SS.LUK);
    }

    public void CreateMoney(int Money)
    {
        
        Instant = Instantiate(MoneyInst, WhereToPutIn.transform.position, new Quaternion(), WhereToPutIn.transform.GetChild(0));
        Instant.GetComponent<Text>().text = "+" + Money.ToString() + "G";
        PlayerInfor.Money += Money;
        
    }





}