using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFolders.Scripts
{
    public class Joker : MonoBehaviour
    {
        [SerializeField] private int jokerCount = 3;

        private void Start()
        {
            UIManager.instance.jokerText.text = "" + jokerCount;
        }

        public void JokerButton()
        {
            if (jokerCount <= 0) return;
            StartCoroutine(JokerAsycn());
        }

        private IEnumerator JokerAsycn()
        {
            while (true)
            {
                yield return new WaitForEndOfFrame();
                int index = Random.Range(0, CollisionController.instance.objects.Length);
                DifferenceObject differenceObject = CollisionController.instance.objects[index].GetComponent<DifferenceObject>();
                if(differenceObject.isTrigger) continue;
                differenceObject.SignCorrect();
                break;
            }

            jokerCount--;
            UIManager.instance.jokerText.text = "" + jokerCount;
        }
    }
}
