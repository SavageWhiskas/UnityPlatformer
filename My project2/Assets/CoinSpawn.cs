using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CoinSpawn : MonoBehaviour
{
    

    public int m_Value = 1;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            //find the score manager and add points
            ScoreManager = FindObjectOfType<ScoreManager>();

            if (scoreManager != null)
            { 
                
              scoreManager.AddScore(m_Value);
            }
        }
    }
}
