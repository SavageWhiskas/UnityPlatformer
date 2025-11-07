using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [Header("Patrol Points")]
    public Transform[] patrolPoints;
    public float speed = 1f;
    public Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void flipsprite()
    {
        if (gameObject.CompareTag("Patrol"))
        {
            GetComponent<SpriteRenderer>().flipX = true; 
        }
    }
}
