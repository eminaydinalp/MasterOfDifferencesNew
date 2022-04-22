using GameFolders.Scripts.Manager;
using UnityEngine;

namespace GameFolders.Scripts.Level
{
    public class LevelSelector : MonoBehaviour
    {
        [SerializeField] private GameObject[] levelButtons;

        private void Start()
        {
            for (int i = 0; i < levelButtons.Length; i++)
            {
                if (i + 1 > GameManager.instance.currentLevel)
                { 
                    levelButtons[i].GetComponent<LevelButton>().DoDeactive();
                }
                
                if (i + 2 > GameManager.instance.currentLevel)
                { 
                    levelButtons[i].GetComponent<LevelButton>().StarsDeActive();
                }
                
                
            }
        }
    }
}
