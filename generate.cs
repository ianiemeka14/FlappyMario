using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{

    public GameObject rocks;
    int score;

    void Start()
    {
        InvokeRepeating("CreateObstacle", 2.5f, 1f);

       
        
    }

   
    void CreateObstacle()
    {
        Instantiate(rocks);
       
    
    }

    
    void Update()
    {
        
        
    }
}
