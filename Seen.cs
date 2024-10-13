using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seen : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 120f;

    public bool sight = false;
    public void events()
    {
        //Box event
    }
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        if (sight == false)
        {
            currentTime -= 1 * Time.deltaTime;
            //print(currentTime);
        }
    }
}
