using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts.Manager
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager instance;
    
        public Text jokerText;
        public Text healthText;
        public Text levelText;
        public Text failText;

        public GameObject[] complateUIs;
        public Text[] complateTexts;
        public GameObject failUI;

        private void Awake()
        {
            instance = this;
        }
    }
}
