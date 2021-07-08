using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (this.gameObject.name)
        {
            case "Folha":
                SomFolha.tocar = true;
                ScoreLeaf.countFolhas += 1;
                Destroy(gameObject);
                break;

        }
    }
}
