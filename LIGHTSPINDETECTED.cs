using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LIGHTSPINDETECTED : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 10 * Time.deltaTime, 0f, Space.Self);
    }
}
