using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreLife : MonoBehaviour
{
    Text textVidas;
    public static int countVidas = 3;

    void Start()
    {
        textVidas = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textVidas.text = "" + countVidas;
        if(countVidas < 0)
        {
            countVidas += 4;
            SceneManager.LoadScene("GameOver");
        }
    }
}
