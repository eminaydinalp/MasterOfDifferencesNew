using System;
using DG.Tweening;
using UnityEngine;

namespace GameFolders.Scripts
{
    public class Particle : MonoBehaviour
    {
        [SerializeField] private GameObject particleObject;
        [SerializeField] private Transform targetObject;

        private void Start()
        {
            
            GameObject cloneParticle = Instantiate(particleObject);

            Vector3 direction = cloneParticle.transform.position - targetObject.transform.position;

            cloneParticle.transform.rotation = Quaternion.Euler(direction);

            cloneParticle.transform.DOMove(targetObject.transform.position, 2f);


        }
    }
}
