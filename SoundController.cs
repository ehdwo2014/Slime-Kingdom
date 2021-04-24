using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallConfirmSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(0).childCount;
        for (int i =0; i<SoundAmount; i++)
        {

            if(this.transform.GetChild(0).GetChild(0).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(0).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }

    public void CallCancelSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(1).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(0).GetChild(1).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(1).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }


    public void CallSuccessSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(2).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(0).GetChild(2).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(2).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }

    public void CallFailSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(3).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(0).GetChild(3).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(3).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }

    public void CallBowSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(2).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(2).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(2).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }


    }

    public void CallMagicSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(3).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(3).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(3).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }


    }

    public void CallHitSound()
    {
        int SoundAmount;
        SoundAmount = this.transform.GetChild(4).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(4).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(4).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }


    }


    public void CallSkillUseSound()
    {


            int SoundAmount;
            SoundAmount = this.transform.GetChild(0).GetChild(4).childCount;
            for (int i = 0; i < SoundAmount; i++)
            {

                if (this.transform.GetChild(0).GetChild(4).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
                {
                    this.transform.GetChild(0).GetChild(4).GetChild(i).GetComponent<AudioSource>().Play();
                    break;
                }

            }
            
    }

    public void CallFixSound()
    {
        
        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(5).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(0).GetChild(5).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(5).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }
    public void CallEuipSound()
    {

        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(6).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(0).GetChild(6).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(6).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }

    public void CallSellSound()
    {

        int SoundAmount;
        SoundAmount = this.transform.GetChild(0).GetChild(6).childCount;
        for (int i = 0; i < SoundAmount; i++)
        {

            if (this.transform.GetChild(0).GetChild(7).GetChild(i).GetComponent<AudioSource>().isPlaying == false)
            {
                this.transform.GetChild(0).GetChild(7).GetChild(i).GetComponent<AudioSource>().Play();
                break;
            }

        }

    }






}
