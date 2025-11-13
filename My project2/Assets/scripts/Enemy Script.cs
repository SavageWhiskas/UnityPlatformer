using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform pointA, PointB;
    public float speed = 2f;
    private Vector3 target; 
    // Start is called before the first frame update
    void Start()
    {
        target = pointA.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
