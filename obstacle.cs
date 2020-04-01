using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public Rigidbody2D rgbody;
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 4;
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
          rgbody.velocity = velocity;
          transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
        
    }

  
    void Update()
    {
        
    }
}
