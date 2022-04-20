using System;
using DG.Tweening;
using UnityEngine;

namespace GameFolders.Scripts
{
    public class ProgressController : MonoBehaviour
    {
        public static ProgressController instance;
        
        public GameObject[] progressObjects;
        public GameObject particleObject;

        public int progressIndex;

        private void Awake()
        {
            instance = this;
        }

        public void MoveParticle(Vector3 clickPosition)
        {
            particleObject.transform.position = clickPosition;
            particleObject.SetActive(true);

            Vector3 direction = particleObject.transform.position - progressObjects[progressIndex].transform.position;

            particleObject.transform.rotation = Quaternion.Euler(direction);

            particleObject.transform.DOMove(progressObjects[progressIndex].transform.position, 1f)
                .OnComplete(aa);

        }

        void aa()
        {
            particleObject.SetActive(false);
            progressObjects[progressIndex].SetActive(true);
            progressIndex++;
            
            if (progressIndex == progressObjects.Length)
            {
                CollisionController.instance.parentObject.SetActive(false);
                GameManager.instance.Win();
            }
        }
    }
}
