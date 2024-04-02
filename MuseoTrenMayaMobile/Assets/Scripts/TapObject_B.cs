using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class TapObject_B: MonoBehaviour
    {
        public GameObject canvasPlayer_B;
        public GameObject canvasExamine_B;

        public void Examine()
        {
            canvasPlayer_B.SetActive(false);
            canvasExamine_B.SetActive(true);
        }

        public void ExitExamine()
        {
            canvasPlayer_B.SetActive(true);
            canvasExamine_B.SetActive(false);
        }
    }
}

