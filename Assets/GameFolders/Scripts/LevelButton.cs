using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts
{
    public class LevelButton : MonoBehaviour
    {
        public Button activeButton;
        public Button deactiveButton;

        public GameObject starActive;
        public GameObject starDeactive;
        

        public void DoDeactive()
        {
            activeButton.gameObject.SetActive(false);
            deactiveButton.gameObject.SetActive(true);
            
            starActive.SetActive(false);
            starDeactive.SetActive(true);
        }
    }
}
