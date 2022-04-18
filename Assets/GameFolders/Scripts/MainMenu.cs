using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFolders.Scripts
{
    public class MainMenu : MonoBehaviour
    {
        public void GoLevelMap()
        {
            SceneManager.LoadScene("Game");
        }
    }
}
