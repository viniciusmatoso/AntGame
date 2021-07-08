using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private float deltax;
    private float cameraY;
    private float cameraZ;
    private float deltaY;
    AudioSource audio;


    void Start()
    {
        deltax = Mathf.Abs(player.transform.position.x - transform.position.x);
        cameraY = transform.position.y;
        cameraZ = transform.position.z;
        audio = GetComponent<AudioSource>();
        audio.Play();

    }

    // Update is called once per frame
    void Update()
    {
        YFollow();
        setCameraPosition();
    }

    void setCameraPosition()
    {
        transform.position = new Vector3(player.transform.position.x + deltax, cameraY + 1.5f, cameraZ);
    }

    void YFollow()
    {
        if (player.transform.position.y < transform.position.y - deltaY)
        {
            cameraY = player.transform.position.y + deltaY;
        }
        else if(player.transform.position.y > transform.position.y + deltaY)
        {
            cameraY = player.transform.position.y - deltaY;
        }
    }
}
