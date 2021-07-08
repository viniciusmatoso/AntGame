using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLeaf : MonoBehaviour
{
    Text textFolhas;
    public static int countFolhas = 0;
    AudioSource audioVida;

    void Start()
    {
        textFolhas = GetComponent<Text>();
        audioVida = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        textFolhas.text = "" + countFolhas;
        validarVidas();
    }

    private void validarVidas()
    {
        if(countFolhas >= 10)
        {
            countFolhas = 0;
            ScoreLife.countVidas += 1;
            audioVida.Play();
        }
    }
}
