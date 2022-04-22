using GameFolders.Scripts.Controller;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts
{
    public class DifferenceObject : MonoBehaviour
    {
        [SerializeField] private GameObject correctSign;
        [SerializeField] private GameObject pairObject; 
        public bool isTrigger;

        public void SignCorrect()
        {
            if (isTrigger) return;
            isTrigger = true;
            pairObject.GetComponent<DifferenceObject>().isTrigger = true;

            Instantiate(correctSign, transform.position, Quaternion.identity, CollisionController.instance.parentObject.transform);
            Instantiate(correctSign, pairObject.transform.position, Quaternion.identity, CollisionController.instance.parentObject.transform);
            ProgressController.instance.MoveParticle(transform.position);
        }
        

    }
}
