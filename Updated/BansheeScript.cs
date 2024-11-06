using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BansheeScript : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip Scream1;
    public AudioClip Scream2;
    public AudioClip Scream3;
    public AudioClip Scream4;
    public GameObject Me;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = Me.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Event(int num)
    {
        if (num == 0)
        {
            source.PlayOneShot(Scream1);
        }

        if (num == 1)
        {
            source.PlayOneShot(Scream2);
        }

        if (num == 2)
        {
            source.PlayOneShot(Scream3);
        }
    }
}
