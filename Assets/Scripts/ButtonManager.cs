using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    private bool isPaused;

    [SerializeField]
    private GameObject pauseMenuUI;

    public void btnNewgame(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void btnNextLevel(string NextLevel)
    {
        SceneManager.LoadScene(NextLevel);
    }

    public void btnExitGame()
    {
        Application.Quit();
    }

    public void btnMainMenu(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactiveMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
    }

    public void DeactiveMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}
