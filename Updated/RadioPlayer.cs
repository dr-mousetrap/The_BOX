using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioPlayer : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip Warning;
    public AudioClip ShipCast1;
    public AudioClip ShipCast2;
    public AudioClip ShipCast3;
    public GameObject Me;

    private AudioSource source;

    private bool state = false;
    public bool isOn = true;

    public bool shipCall = false;

    // Start is called before the first frame update
    void Start()
    {
        source = Me.GetComponent<AudioSource>();
        source.PlayOneShot(clip);
    }

    // Update is called once per frame
    void Update()
    {
        if (state == true)
        {
            source.Stop();
        }
        else
        {
            if (isOn == true)
            {
                source.mute = false;
            }

            if (isOn == false)
            {
                source.mute = true;
            }
        }
        //temporary
        if (shipCall == true)
        {
            source = Me.GetComponent<AudioSource>();
            source.PlayOneShot(ShipCast1);
        }
    }

    public void Event(int num)
    {

    }

    public void blackout(bool ShutDown)
    {
        if (ShutDown == true)
        {
            state = true;
        }
    }
    public void ship()
    {

    }
}
