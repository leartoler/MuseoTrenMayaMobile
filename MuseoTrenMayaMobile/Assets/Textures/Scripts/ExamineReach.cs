using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineReach : MonoBehaviour
{
    public GameObject buttonExamineA;
    public GameObject buttonExamineB;
    public GameObject buttonExamineC;
    public bool isReach;

    private void Start()
    {
        isReach = false;
        buttonExamineA.SetActive(false);
        buttonExamineB.SetActive(false);
        buttonExamineC.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Objeto_1")
        
        {
            Debug.Log ("Objeto 1");
            isReach = true;
            buttonExamineA.SetActive(true);
            buttonExamineB.SetActive(false);
            buttonExamineC.SetActive(false);
        }    
        
        if (other.gameObject.tag == "Objeto_2")
        
        {
            Debug.Log ("Objeto 2");
            isReach = true;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(true);            
            buttonExamineC.SetActive(false);
        }
        if (other.gameObject.tag == "Objeto_3")
        {
            Debug.Log ("Objeto 3");
            isReach = true;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(false);
            buttonExamineC.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objeto_1")
        {
            isReach = false;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(false);
            buttonExamineC.SetActive(false);
        }
        if (other.gameObject.tag == "Objeto_2")
        {
            isReach = false;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(false);
            buttonExamineC.SetActive(false);
        }
        if (other.gameObject.tag == "Objeto_3")
        {
            isReach = false;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(false);
            buttonExamineC.SetActive(false);
        }
    }
}
