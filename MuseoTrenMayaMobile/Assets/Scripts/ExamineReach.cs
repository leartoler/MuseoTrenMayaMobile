using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineReach : MonoBehaviour
{
    public GameObject buttonExamineA;
    public GameObject buttonExamineB;
    public bool isReach;

    private void Start()
    {
        isReach = false;
        buttonExamineA.SetActive(false);
        buttonExamineB.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Objeto_1")
        
        {
            Debug.Log ("objeto 1");
            isReach = true;
            buttonExamineA.SetActive(true);
            buttonExamineB.SetActive(false);
        }    
        
        if (other.gameObject.tag == "Objeto_2")
        
        {
            Debug.Log ("Objeto 2");
            isReach = true;
            buttonExamineB.SetActive(true);
            buttonExamineA.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objeto_1")
        {
            isReach = false;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(false);
        }
        if (other.gameObject.tag == "Objeto_2")
        {
            isReach = false;
            buttonExamineA.SetActive(false);
            buttonExamineB.SetActive(false);
    }
}
}