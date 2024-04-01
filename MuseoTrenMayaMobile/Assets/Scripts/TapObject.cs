using UnityEngine;

namespace MisaVondoExamineSystem
{
    public class TapObject : MonoBehaviour
    {
        public GameObject canvasPlayer;
        public GameObject canvasExamine;

        public void Examine()
        {
            canvasPlayer.SetActive(false);
            canvasExamine.SetActive(true);
        }

        public void ExitExamine()
        {
            canvasPlayer.SetActive(true);
            canvasExamine.SetActive(false);
        }
    }
}

