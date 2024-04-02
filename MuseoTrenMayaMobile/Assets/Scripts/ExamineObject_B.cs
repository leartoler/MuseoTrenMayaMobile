using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class ExamineObject_B : MonoBehaviour
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
            if (other.gameObject.tag == "Reach_2")
            {
                isReach = true;
                buttonExamine.SetActive(true);
            }
           
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Reach_2")
            {
                isReach = false;
                buttonExamine.SetActive(false);
            }

        }
    }
}
