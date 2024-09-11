using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class TapObject : MonoBehaviour
    {
        public GameObject canvasPlayer;
        public GameObject canvasExamineA;
        public GameObject canvasExamineB;
        public GameObject canvasExamineC;

        public void ExamineA()
        {
            
            Debug.Log("ExamineA");
            canvasPlayer.SetActive(false);
            canvasExamineA.SetActive(true);
            canvasExamineB.SetActive(false);
            canvasExamineC.SetActive(false);
        }

        public void ExamineB()
        {
            Debug.Log("ExamineB");
            canvasPlayer.SetActive(false);
            canvasExamineA.SetActive(false);
            canvasExamineB.SetActive(true);
            canvasExamineC.SetActive(false);
        }

        public void ExamineC()
        {
            Debug.Log("ExamineC");
            canvasPlayer.SetActive(false);
            canvasExamineA.SetActive(false);
            canvasExamineB.SetActive(false);
            canvasExamineC.SetActive(true);
        }

        public void ExitExamine()
        {
            canvasPlayer.SetActive(true);
            canvasExamineA.SetActive(false);
            canvasExamineB.SetActive(false);
            canvasExamineC.SetActive(false);
        }
    }
}

