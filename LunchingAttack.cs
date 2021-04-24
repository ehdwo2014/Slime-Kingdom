using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class LunchingAttack : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    [SerializeField] private RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;
    public GameObject UICanvas;
    private bool pointerDown;
    public GameObject ThrowerP;
    public GameObject ThrowerM;

    public GameObject bar;
    public GameObject SlimeInv;
    GameObject Instant;
    Vector2 Cposition;
    Vector2 Nposition;
    Vector2 SubVec;
    Vector3 thisPosition;
    public GameObject LunchingPos;
    public List<GameObject> LunchingPositions;
    public List<GameObject> ThrowingObject;
    public GameObject SlimeCas;
    int SizeOfGroups;
    int SizeOfSlimes;
    int InvIndex;
    public Camera camera;
    public GameObject SkillDB;
    System.Random R = new System.Random();
    public GameObject ShotDatabase;
    public GameObject ShotSoundDB;


    public void OnBeginDrag(PointerEventData eventData)
    {
        SizeOfGroups = 5;
        SizeOfSlimes = 5;
        this.GetComponent<Image>().raycastTarget = false;
        Cposition = this.transform.position;
    }





    public void OnDrag(PointerEventData eventData)
    {
        transform.SetParent(UICanvas.transform);

        dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        SubVec = Cposition - new Vector2(this.transform.position.x, this.transform.position.y);

        if (Mathf.Sqrt(Mathf.Pow(SubVec.x, 2) + Mathf.Pow(SubVec.y, 2)) > 1)
        {
            dragRectTransform.anchoredPosition -= eventData.delta / canvas.scaleFactor;

        }


    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Nposition = this.transform.position;
        transform.SetParent(bar.transform.parent);
        this.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        this.GetComponent<Image>().raycastTarget = true;
        
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pointerDown)
        {
            bar.GetComponent<Image>().fillAmount += 0.01f;
        }


    }
 
    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        for (int i = 0; i < 25; i++)
        {
            if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i] != null)
            {
                if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackReady == true)
                {
                    if((SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackType.Equals("Physical")))
                        {
                        StartCoroutine(LunchForMultyPhy(i));
                    }
                    else
                         {
                        Lunching(i);

                          }
                    SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AtimeNow = 0;

                    if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.Sprafe == true)
                    {
                        StartCoroutine(LunchForMulty(i));
                    }
                    
                    //Instant = Instantiate(ThrowerM, SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position, new Quaternion(), null);
                    //Instant.GetComponent<Rigidbody2D>().AddForce(SubVec.normalized * bar.GetComponent<Image>().fillAmount * 3000f);
                    //Instant.GetComponent<ThrowingShot>().ShotOrigin = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i];
                }
                }
        }
        Reset();

    }
    private void Reset()
    {
        pointerDown = false;
        bar.GetComponent<Image>().fillAmount = 0;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public float GetAngle()
    {
        Vector2 v2 = SubVec - new Vector2(0, 0);
        return Mathf.Atan2(v2.y, v2.x) * Mathf.Rad2Deg;
    }

    public void Lunching(int i)
    {
        if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackType.Equals("Physical"))
        {
            ShotSoundDB.GetComponent<SoundController>().CallBowSound();

            if (ShotDatabase.transform.GetChild(0).childCount != 0)
            {
                Instant = ShotDatabase.transform.GetChild(0).GetChild(0).gameObject;
                Instant.SetActive(true);
                Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                Instant.transform.SetParent(null);
                for (int z = 0; z < Instant.transform.childCount; z++)
                {
                    if(z == 0)
                    {
                        Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                    }

                    Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                    Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                }
            }

          //  Instant = Instantiate(ThrowerP, SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position, new Quaternion(), null);

        }
        else if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackType.Equals("Magical"))
        {
            ShotSoundDB.GetComponent<SoundController>().CallMagicSound();

            if(ShotDatabase.transform.GetChild(1).GetChild(SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().TypeOfElement).childCount != 0)
            {
                Instant = ShotDatabase.transform.GetChild(1).GetChild(SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().TypeOfElement).GetChild(0).gameObject;
                Instant.SetActive(true);
                Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                Instant.transform.SetParent(null);
                for (int z = 0; z < Instant.transform.childCount; z++)
                {
                    if (z == 0)
                    {
                        Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                    }

                    Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                    Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                }
            }
           // Instant = Instantiate(ThrowerM, SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position, new Quaternion(), null);
        }
        else
        {
            if (ShotDatabase.transform.GetChild(0).childCount != 0)
            {
                Instant = ShotDatabase.transform.GetChild(0).GetChild(0).gameObject;
                Instant.SetActive(true);
                Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                Instant.transform.SetParent(null);
                for (int z = 0; z < Instant.transform.childCount; z++)
                {
                    if (z == 0)
                    {
                        Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                    }


                    Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                    Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                }
            }
        }

        if (Instant != null)
        {
            Instant.GetComponent<Rigidbody2D>().AddForce(SubVec.normalized * bar.GetComponent<Image>().fillAmount * 3000f);
            Instant.GetComponent<ThrowingShot>().ShotOrigin = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i];
        }
    }


    IEnumerator LunchForMulty(int i)
    {
        SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.Sprafe = false;
        int counter =0;
        Vector2 SubVec2 = SubVec.normalized;
        float FilAmount = bar.GetComponent<Image>().fillAmount * 3000f;
        while (counter < SkillDB.GetComponent<SkillDatabase>().MultiShotS.NumberOfShot)
        {
            if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackType.Equals("Physical"))
            {

                ShotSoundDB.GetComponent<SoundController>().CallBowSound();
                if (ShotDatabase.transform.GetChild(0).childCount != 0)
                {
                    Instant = ShotDatabase.transform.GetChild(0).GetChild(0).gameObject;
                    Instant.SetActive(true);
                    Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                    Instant.transform.SetParent(null);
                    for (int z = 0; z < Instant.transform.childCount; z++)
                    {
                        if (z == 0)
                        {
                            Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                        }

                        Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                        Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                    }
                }

               // Instant = Instantiate(ThrowerP, SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position, new Quaternion(), null);

            }
            else if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackType.Equals("Magical"))
            {
                ShotSoundDB.GetComponent<SoundController>().CallMagicSound();
                if (ShotDatabase.transform.GetChild(1).GetChild(SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().TypeOfElement).childCount != 0)
                {
                    Instant = ShotDatabase.transform.GetChild(1).GetChild(SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().TypeOfElement).GetChild(0).gameObject;
                    Instant.SetActive(true);
                    Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                    Instant.transform.SetParent(null);
                    for (int z = 0; z < Instant.transform.childCount; z++)
                    {
                        if (z == 0)
                        {
                            Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                        }

                        Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                        Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                    }
                }
            }
            else
            {

                if (ShotDatabase.transform.GetChild(0).childCount != 0)
                {
                    Instant = ShotDatabase.transform.GetChild(0).GetChild(0).gameObject;
                    Instant.SetActive(true);
                    Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                    Instant.transform.SetParent(null);
                    for (int z = 0; z < Instant.transform.childCount; z++)
                    {
                        if (z == 0)
                        {
                            Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                        }

                        Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                        Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                    }
                }
            }

            if (Instant != null)
            {
                Instant.GetComponent<Rigidbody2D>().AddForce((SubVec2 * FilAmount) + new Vector2(R.Next(-200, 200), R.Next(-200, 200)));
                Instant.GetComponent<ThrowingShot>().ShotOrigin = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i];
            }
            counter++;
            yield return new WaitForSeconds(0.2f);
        }

    }



    IEnumerator LunchForMultyPhy(int i)
    {
        int counter = 0;
        Vector2 SubVec2 = SubVec.normalized;
        float FilAmount = bar.GetComponent<Image>().fillAmount * 3000f;
        while (counter < 2)
        {
            if (SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].GetComponent<SlimeState>().slimeState.AttackType.Equals("Physical"))
            {

                ShotSoundDB.GetComponent<SoundController>().CallBowSound();
                if (ShotDatabase.transform.GetChild(0).childCount != 0)
                {
                    Instant = ShotDatabase.transform.GetChild(0).GetChild(0).gameObject;
                    Instant.SetActive(true);
                    Instant.transform.position = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i].transform.position;
                    Instant.transform.SetParent(null);
                    for (int z = 0; z < Instant.transform.childCount; z++)
                    {
                        if (z == 0)
                        {
                            Instant.transform.GetChild(z).GetComponent<Rigidbody2D>().freezeRotation = false;
                        }

                        Instant.transform.GetChild(z).transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(SubVec.y, SubVec.x) * Mathf.Rad2Deg, Vector3.forward);
                        Instant.transform.GetChild(z).transform.position = Instant.transform.position;
                    }
                }
            }
          

            if (Instant != null)
            {
                Instant.GetComponent<Rigidbody2D>().AddForce((SubVec2 * FilAmount) + new Vector2(R.Next(-200, 200), R.Next(-200, 200)));
                Instant.GetComponent<ThrowingShot>().ShotOrigin = SlimeCas.GetComponent<SlimeInventoryCopy>().SlimeList1[i];
            }
            counter++;
            yield return new WaitForSeconds(0.2f);
        }

    }
}









