using System;
using UnityEngine;

namespace GameFolders.Scripts
{
    public class ProgressController : MonoBehaviour
    {
        public static ProgressController instance;
        
        public GameObject[] progressObjects;

        public int progressIndex;

        private void Awake()
        {
            instance = this;
        }
    }
}
