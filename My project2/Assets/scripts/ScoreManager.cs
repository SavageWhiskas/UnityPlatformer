

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI m_ScoreText;
    private int m_score;
    void Start()
    {
        UpdateScoreUI();
    }



    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int amount)
    {
        m_score += amount;
        UpdateScoreUI();

    }

    void UpdateScoreUI()

    { 
       m_ScoreText.text = "Score: " + m_score;
    }
    

}






    



