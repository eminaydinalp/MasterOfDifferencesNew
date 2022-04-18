using UnityEngine;
using UnityEngine.UI;

namespace GameFolders.Scripts
{
    public class LevelSelector : MonoBehaviour
    {
        [SerializeField] private GameObject[] levelButtons;

        private void Start()
        {
            Debug.Log(GameManager.instance.currentLevel);
            for (int i = 0; i < levelButtons.Length; i++)
            {
                if (i + 1 > GameManager.instance.currentLevel)
                { 
                    levelButtons[i].GetComponent<LevelButton>().DoDeactive();
                }
            }
        }
    }
}
