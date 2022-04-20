using System;
using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace GameFolders.Scripts
{
    public class Health : MonoBehaviour
    {
        public int healthCount = 3;
        public GameObject healthBroken;
        public GameObject wrongObject;
        private Vector3 healthBrokenPosition;

        private void Start()
        {
            UIManager.instance.healthText.text = "" + healthCount;
            healthBrokenPosition = healthBroken.transform.localPosition;
        }

        public void DecreaseHealth()
        {
            if (GameManager.instance.isFinish) return;
            
            StartCoroutine(DoActiveBrokenHealth());
            healthCount--;
            UIManager.instance.healthText.text = "" + healthCount;

            if (healthCount == 0)
            {
                CollisionController.instance.parentObject.SetActive(false);
                GameManager.instance.isFinish = true;
                GameManager.instance.Fail();
            }
        }

        IEnumerator DoActiveBrokenHealth()
        {
            healthBroken.SetActive(true);
            
            yield return new WaitForSeconds(1f);
            
            healthBroken.SetActive(false);
            healthBroken.transform.localPosition = healthBrokenPosition;
        }

        public void WrongProcess(Vector3 clickPosition)
        {
            Vector3 a = clickPosition;
            a = Camera.main.ScreenToWorldPoint(a);
            Debug.Log("click : " + a);
            wrongObject.SetActive(true);
            wrongObject.transform.position = new Vector3(a.x, a.y, 0);
            wrongObject.transform.DOPunchRotation(Vector3.one * 10f, 1f).OnComplete((() => wrongObject.SetActive(false)));
        }
    }
}
