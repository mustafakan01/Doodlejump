using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public GameObject platform;
    public int platformcounter;
    public float minX, maxX;
    public float minY, maxY;
  
    void Start()
    {
        Vector3 pozisyon= new Vector3 ();

        for(int i = 0; i < platformcounter;i++)
        {
            pozisyon.x = Random.Range(minX,maxX);
            pozisyon.y = Random.Range(minY,maxY);
            Instantiate(platform,pozisyon,Quaternion.identity);
        }
    }

    
    void Update()
    {
        
    }
}
