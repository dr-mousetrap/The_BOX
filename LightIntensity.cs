using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class LightIntensity : MonoBehaviour
{
    public int Intensity = 5;
    public int objectsOn= 0;
    public bool breaker = false;
    public GameObject BreakerObject;

    private GameObject lightObject;
    private Light myLight;
    // private bool isFlickering = false;
    // private flaot timeDelay; h ttps://www.youtube.com/watch?v=DNMdu3kylec


    // Start is called before the first frame update
    void Start()
    {
        lightObject = GameObject.Find("RoomLight");
        myLight = lightObject.GetComponent<Light>();

        
    }

    // Update is called once per frame
    void Update()
    {
       myLight.intensity = Intensity;

        if (breaker == false) {
            if (objectsOn == 0)
            {
                Intensity = 5;
            }

            if (objectsOn == 1)
            {
                Intensity = 4;
            }

            if (objectsOn == 2)
            {
                Intensity = 3;
            }

            if (objectsOn == 3)
            {
                Intensity = 2;
            }

            if (objectsOn == 4)
            {
                Intensity = 1;

            }

            if (objectsOn >= 5)
            {
                Intensity = 0;
                breaker = true;
                if (BreakerObject != null)
                {
                    BreakerObject.GetComponent<BreakerScript>().BreakerOn(breaker);
                }
            }
        }
        else
        {
           
        }
    }


}
