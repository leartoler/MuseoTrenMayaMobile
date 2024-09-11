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
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Reach_1")
            {
                Debug.Log("objeto a se ve");
                isReach = true;
                buttonExamine.SetActive(true);
            }
           
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Reach_1")
            {
                isReach = false;
                buttonExamine.SetActive(false);
            }

        }
    }
}
