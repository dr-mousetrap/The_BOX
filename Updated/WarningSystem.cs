using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSystem : MonoBehaviour
{
    private bool state = false; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void blackout(bool ShutDown)
    {
        if (ShutDown == true)
        {
            state = true;
        }
    }
}
