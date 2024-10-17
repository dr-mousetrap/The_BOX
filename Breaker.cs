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
    public GameObject WarningSystem; //2
    public GameObject TorchCharger; //1


    // Start is called before the first frame update
    void Start()
    {
        
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
               //Radio.GetComponent<LIGHTSPINDETECTED>().blackout(ShutDown);
            }
        }
    }

    public void BreakerOn(bool status)
    {
        if (status == true)
        {
            ShutDown = true;
        }
        else
        {
            
        }
    }
}
//e 
