using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class ExamineObject : MonoBehaviour
    {
        public GameObject buttonExamine;

        public bool isReach;

        private void Start()
        {
            isReach = false;
            buttonExamine.SetActive(false);
            Debug.Log ("No hay naaa");
        }

        private void OnTriggerEnter(Collider other)  
        {
            if (other.gameObject.tag == "Reach")
            {

                isReach = true;
                buttonExamine.SetActive(true);
                Debug.Log ("Objeto identificado");
            }
}
        
        

        private void OnTriggerExit(Collider other)
        {
            
                isReach = false;
                buttonExamine.SetActive(false);
                Debug.Log("No hay objeto");
            }
        }
    }

