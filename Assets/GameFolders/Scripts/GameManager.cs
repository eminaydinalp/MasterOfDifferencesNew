using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


namespace GameFolders.Scripts
{
    public class GameManager : MonoBehaviour
    {
        private Health _health;
        public static GameManager instance;
        public GameObject confetti, gameCanvas, level, levelMap;
        public int currentLevel;
        public int levelIndex;

        public bool isFinish;
        public bool isMapActive;

        private void Awake()
        {
            instance = this;
            currentLevel = PlayerPrefs.GetInt("Level" ,1);
            _health = GetComponentInChildren<Health>();
            Debug.Log(currentLevel);
            levelMap.SetActive(true);
        }

        void Start()
        {
            isMapActive = true;
            Application.targetFrameRate = 60;
        }

        public void GoGame(int levelIndex)
        {
            isMapActive = false;
            levelMap.SetActive(false);
            gameCanvas.SetActive(true);

            this.levelIndex = levelIndex;
            OpenCurrentLevel();
        }

        private void OpenCurrentLevel()
        {
            /*if (currentLevel > 4)
            {
                Random.InitState(System.DateTime.Now.Millisecond);
                currentLevel = Random.Range(1, 5);
                level = (GameObject)Instantiate(Resources.Load("Level" + currentLevel));
            }
            else
            {
                level = (GameObject)Instantiate(Resources.Load("Level" + currentLevel));
            }*/
            level = (GameObject)Instantiate(Resources.Load("Level" + levelIndex));
            UIManager.instance.levelText.text = "Level " + (levelIndex + 1);

        }
        public void seviyeAtlama()
        {
            PlayerPrefs.SetInt("Tutorial", 1);
            if(levelIndex + 1 == currentLevel) PlayerPrefs.SetInt("Level", currentLevel + 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
        }
        public void Fail()
        {
            isFinish = true;
            StartCoroutine(nameof(GameOver));
        }
        public void Win()
        {
            isFinish = true;
            StartCoroutine(nameof(CompleteLevel));
        }
        public IEnumerator GameOver()
        {
            yield return new WaitForSeconds(.1f);
            //Player.Instance.started = false;
            //Player.Instance.speed = 0;
            UIManager.instance.failText.text = "Level " + (levelIndex + 1);
            UIManager.instance.failUI.SetActive(true);
            //UIManager.instance.complateUI.SetActive(false);
        }
    
        IEnumerator KonfettiPatlat()
        {
            yield return new WaitForSeconds(0.3f);
            confetti.SetActive(true);
        }
        public IEnumerator CompleteLevel()
        {
            yield return new WaitForSeconds(0.1f);
            //StartCoroutine(KonfettiPatlat());
            UIManager.instance.complateUIs[_health.healthCount - 1].SetActive(true);
            UIManager.instance.complateTexts[_health.healthCount - 1].text = "Level " + (levelIndex + 1);
            UIManager.instance.failUI.SetActive(false);
        }
    }
}
