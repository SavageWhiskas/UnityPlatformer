using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public int livesRemaining = 3;

    [SerializeField] private TextMeshProUGUI lifeCounter;
    [SerializeField] private GameObject gameOver;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            if(livesRemaining >0)
            {
                livesRemaining--;
                gameObject.transform.position = new Vector3(-31, -1, 0);
                lifeCounter.text = "Lives: " + livesRemaining.ToString();
            }
            else
            {
                //game over logic here
            }
        }
    }
}
