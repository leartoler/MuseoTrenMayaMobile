using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class ExamineObject1 : MonoBehaviour
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
            if (other.gameObject.tag == "Reach")
            {
                isReach = true;
                buttonExamine.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Reach")
            {
                isReach = false;
                buttonExamine.SetActive(false);
            }
        }
    }
}

