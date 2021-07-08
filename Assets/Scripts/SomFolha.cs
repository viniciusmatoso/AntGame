using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomFolha : MonoBehaviour
{
    AudioSource audio;
    public static bool tocar = false;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tocar)
        {
            audio.Play();
            tocar = false;
        }
    }
}
