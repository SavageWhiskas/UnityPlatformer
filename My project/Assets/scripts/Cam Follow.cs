using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] GameObject focalPoint;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(focalPoint.transform.position.x, focalPoint.transform.position.y, gameObject.transform.position.z);
    }
}
