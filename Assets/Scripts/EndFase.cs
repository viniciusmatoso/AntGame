using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndFase : MonoBehaviour
{
    public RawImage bg;
    public Text title;
    public Button nextFase;
    public Text subtitleButton;

    public static bool mostrar = false;

    void Start()
    {
        bg.enabled = false;
        title.enabled = false;
        nextFase.gameObject.SetActive(false);
        subtitleButton.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        checarClick();
    }

    private void checarClick()
    {
        if (mostrar)
        {
            bg.enabled = true;
            title.enabled = true;
            nextFase.gameObject.SetActive(true);
            subtitleButton.enabled = true;
        }
        mostrar = false;
    }

    public void proxFase()
    {
        Scene scene = SceneManager.GetActiveScene();
        switch (scene.name)
        {
            case "Fase1":
                SceneManager.LoadScene("Fase2");
                break;

        }
    }
}
