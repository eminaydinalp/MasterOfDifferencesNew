using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameFolders.Scripts
{
    public class CollisionController : MonoBehaviour
    {
        public static CollisionController instance;
        
        public GameObject[] objects;
        public GameObject parentObject;

        private Health _health;

        public Vector2 clickPosition;

        private void Awake()
        {
            instance = this;

            _health = GameManager.instance.gameObject.GetComponent<Health>();
        }

        public void ClickProsess()
        {
            if(GameManager.instance.isFinish) return;
            RaycastHit2D raycastHit = ThrowRay();

            if (raycastHit.transform == null)
            {
                Debug.Log("healt2");
                _health.DecreaseHealth();
                //_health.WrongProcess(clickPosition);
                return;
            }

            if (raycastHit.transform.CompareTag("DifferenceImage"))
            {
                return;
            }

            DifferenceObject differenceObject = raycastHit.transform.GetComponent<DifferenceObject>();

            if (differenceObject == null) return;
            differenceObject.SignCorrect();
        }


        private RaycastHit2D ThrowRay()
        {
            Vector3 clickPosition = this.clickPosition;
            clickPosition = Camera.main.ScreenToWorldPoint(clickPosition);

            return Physics2D.Raycast(clickPosition, Vector3.back, Mathf.Infinity);
        }

        public void HeldProcess()
		{
            RaycastHit2D raycastHit = ThrowRay();
        }
    }
}