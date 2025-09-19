using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class pipespawnscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Spawnpipe(); 
            timer = 0;
        }
    }
    void Spawnpipe()
    {
        float LowestPoint = transform.position.y - heightoffset;
        float HighestPoint = transform.position.y + heightoffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint), 0), transform.rotation);
    }
}
    
    





