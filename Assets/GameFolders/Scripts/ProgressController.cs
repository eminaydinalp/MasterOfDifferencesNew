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
            GameObject cloneParticle = Instantiate(particleObject, clickPosition, Quaternion.identity);

            Vector3 direction = cloneParticle.transform.position - progressObjects[progressIndex].transform.position;

            cloneParticle.transform.rotation = Quaternion.Euler(direction);

            cloneParticle.transform.DOMove(progressObjects[progressIndex].transform.position, 2f).OnComplete((() => Destroy(cloneParticle)));
        }
    }
}
