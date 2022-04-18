using System;
using System.Collections;
using UnityEngine;

namespace GameFolders.Scripts
{
    public class Health : MonoBehaviour
    {
        public int healthCount = 3;
        public GameObject healthBroken;
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
    }
}
