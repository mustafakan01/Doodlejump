using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D temas)
    {
        float rastgeleX=Random.Range(-5f,5f);
        float sabitY = 14f;

        if (temas.tag == "Platform")
        {
            temas.transform.position=new Vector3(rastgeleX,temas.transform.position.y+sabitY,transform.position.z); 
        }
    }

    
}
