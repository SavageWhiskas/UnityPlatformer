using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using System.Diagnostics.CodeAnalysis;


public class SignScript : MonoBehaviour
{
    private bool playerEntered  = false;
    public GameObject questionPanel; 
    public MovementScript movement;
    public QuestionManager questionManager;
     
    // Start is called before the first frame update
    void Start()
    {
        questionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerEntered && Input.GetKeyDown(KeyCode.E) && !movement.answering)
        {

            questionPanel.SetActive(!questionPanel.activeSelf);
            Debug.Log("Player opened sign");
            movement.answering = true;
            questionManager.getQuestion(1);



        }
        else if (playerEntered && Input.GetKeyDown(KeyCode.Escape) && movement.answering)
        {
            questionPanel.SetActive(false);
            movement.answering = false;
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerEntered = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerEntered = false;
        }
    }





}


   

    
  
    

