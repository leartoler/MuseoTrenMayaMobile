using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineReach : MonoBehaviour
{
    public GameObject buttonExamine;
    public bool isReach;

    private void Start()
    {
        isReach = false;
        buttonExamine.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Objeto_1")
        
        {
            Debug.Log ("objeto 1");
            isReach = true;
            buttonExamine.SetActive(true);
        }    
        
        if (other.gameObject.tag == "Objeto_2")
        
        {
            Debug.Log ("Objeto 2");
            isReach = true;
            buttonExamine.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Objeto_1")
        {
            isReach = false;
            buttonExamine.SetActive(false);
        }
        if (other.gameObject.tag == "Objeto_2")
        {
            isReach = false;
            buttonExamine.SetActive(false);
    }
}
}