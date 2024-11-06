using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BreakerScript : MonoBehaviour
{
    public bool ShutDown = false;
    public GameObject HouseLight; //3
    public GameObject Radio; //1
    public GameObject WarningSys; //2
    public GameObject TorchCharge; //1

    public GameObject RoomLight;
   
    public GameObject Me;
    public AudioClip clip;
    private AudioSource source;

    //Lightning system

    // Start is called before the first frame update
    void Start()
    {
        source = Me.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShutDown == true)
        {
            if (HouseLight != null)
            {
               HouseLight.GetComponent<LIGHTSPINDETECTED>().blackout(ShutDown);
            }

            if (Radio != null)
            {
               Radio.GetComponent<RadioPlayer>().blackout(ShutDown);
            }

            if (WarningSys != null)
            {
               // WarningSys.GetComponent<WarningSystem>().blackout(ShutDown);
            }

            if (TorchCharge != null)
            {
               // TorchCharge.GetComponent<>().blackout(ShutDown);
            }
        }
        else if (ShutDown = false)
        {
            if (HouseLight != null)
            {
                HouseLight.GetComponent<LIGHTSPINDETECTED>().blackout(ShutDown);
            }

            if (Radio != null)
            {
                Radio.GetComponent<RadioPlayer>().blackout(ShutDown);
            }

            if (WarningSys != null)
            {
                // WarningSys.GetComponent<WarningSystem>().blackout(ShutDown);
            }

            if (TorchCharge != null)
            {
                // TorchCharge.GetComponent<>().blackout(ShutDown);
            }

            if (RoomLight != null)
            {
                RoomLight.GetComponent<LightIntensity>().reset(ShutDown);
            }
        }
    }

    public void BreakerOn(bool status)
    {
        if (status == true)
        {
            ShutDown = true;
            source.PlayOneShot(clip);
        }
        else
        {
            ShutDown = false;
        }
    }
}
//e 