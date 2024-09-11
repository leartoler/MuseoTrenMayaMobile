using UnityEngine;
using UnityEngine.EventSystems;

namespace MisaVondoExamineSystem
{
    public class RotateObject_B : MonoBehaviour, IDragHandler
    {
        public Transform examinePrefabs;

        public void OnDrag(PointerEventData eventData)
        {
            examinePrefabs.eulerAngles += new Vector3(-eventData.delta.y, -eventData.delta.x);
        }
    }
}
