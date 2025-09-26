using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int m_value = 1; 

  
    

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

            if (scoreManager != null)
            {
                scoreManager.AddScore(m_value);
                Debug.Log("Colleceted coins");
            }

            Destroy(gameObject);
            Debug.Log("Coin destroyed"); 
        }

    }
}
