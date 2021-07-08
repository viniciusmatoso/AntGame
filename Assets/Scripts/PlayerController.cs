using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Animator an;
    AudioSource audio;
    private bool leftMove = false;
    private bool rightMove = false;
    public float jumpForce;
    private bool isFalling = false;

    public bool ladoDir = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        an = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //capturar cena atual
        Scene scene = SceneManager.GetActiveScene();

        if(transform.position.y < -10){
            ScoreLife.countVidas -= 1;
            ScoreLeaf.countFolhas = 0;
            SceneManager.LoadScene(scene.name);
        }
    }

    void FixedUpdate()
    {
       
        //movimentos
        if (leftMove)
        {
            rb.velocity = new Vector3(-5, rb.velocity.y, rb.velocity.z);

        }
        if (rightMove)
        {
            rb.velocity = new Vector3(5, rb.velocity.y, rb.velocity.z);
            

        }
    }

    //movimento esquerda click
    public void PointerDownLeft()
    {
        leftMove = true;
        an.SetBool("walking", true);
        if (ladoDir)
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }

    }

    //movimento esquerda solto
    public void PointerUpLeft()
    {
        leftMove = false;
        ladoDir = false;
        an.SetBool("walking", false);
    }

    //movimento direita click
    public void PointerDownRight()
    {
        rightMove = true;
        an.SetBool("walking", true);
        if (ladoDir)
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
        else
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }

    //movimento direita solto
    public void PointerUpRight()
    {
        rightMove = false;
        ladoDir = true;
        an.SetBool("walking", false);
    }

    public void Jump()
    {
        if (!isFalling)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            isFalling = true;
            an.SetBool("chao", false);
            an.SetBool("ar", true);
            audio.Play();
        }
        
    }

    //colisoes
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PisoUp")
        {
            isFalling = false;
            an.SetBool("chao", true);
            an.SetBool("ar", false);
        }

        if (collision.gameObject.tag == "Parede")
        {
            isFalling = false;
            an.SetBool("chao", true);
            an.SetBool("ar", false);
        }

        if (collision.gameObject.tag == "Piso")
        {
            isFalling = false;
            an.SetBool("chao", true);
            an.SetBool("ar", false);
        }

        if(collision.gameObject.tag == "Fim")
        {
            AdsManager.mostrar = true;
            EndFase.mostrar = true;
        }

    }

}
