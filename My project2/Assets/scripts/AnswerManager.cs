using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerMnager : MonoBehaviour
{
    public string m_AnswerText;
    public TextMeshProUGUI m_WorldText;

    private QuestionManager m_QuestionManagerRef; 
    // Start is called before the first frame update
    void Start()
    {
        m_QuestionManagerRef = FindObjectOfType<QuestionManager>();
        if(m_WorldText == null)
        {
            m_WorldText.text = m_AnswerText;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            bool correct = m_QuestionManagerRef.CheckAnswer(m_AnswerText);

            if (correct)
            {

                Debug.Log("Player chose the right answer");
            }
            else
            {
                Debug.Log("Player chose the wrong answer");
            }
        }
    }
}
