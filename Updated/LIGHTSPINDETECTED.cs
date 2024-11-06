using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LIGHTSPINDETECTED : MonoBehaviour
{
    public GameObject SpotLight1;
    public GameObject SpotLight2;

    public bool state;

    private Light Spot1;
    private Light Spot2;

    // Start is called before the first frame update
    void Start()
    {
        Spot1 = SpotLight1.GetComponent<Light>();
        Spot2 = SpotLight2.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 10 * Time.deltaTime, 0f, Space.Self);

        if(state == true)
        {
            Spot1.intensity = 0f;
            Spot2.intensity = 0f;
        }

        if(state == false)
        {
            Spot1.intensity = 2.3f;
            Spot2.intensity = 2.3f;
        }
    }

    public void blackout(bool ShutDown)
    {
       if(ShutDown == true)
        {
            state = true;
        }
    }
}
