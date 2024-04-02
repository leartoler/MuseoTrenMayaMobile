using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class TapObject : MonoBehaviour
    {
        public GameObject canvasPlayer;
        public GameObject canvasExamineA;
        public GameObject canvasExamineB;

        public void ExamineA()
        {
            canvasPlayer.SetActive(false);
            canvasExamineA.SetActive(true);
            canvasExamineB.SetActive(false);
        }

        public void ExamineB()
        {
            canvasPlayer.SetActive(false);
            canvasExamineA.SetActive(false);
            canvasExamineB.SetActive(true);
        }

        public void ExitExamine()
        {
            canvasPlayer.SetActive(true);
            canvasExamineA.SetActive(false);
            canvasExamineB.SetActive(false);
        }
    }
}

