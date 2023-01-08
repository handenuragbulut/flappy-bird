using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused0 = false;

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        	
        	if(GameIsPaused)
        	{
        		Resume();
        		
        	}
        	else
        	{
        		Pause();
        		
        	}
        	Debug.Log("Escape: " + GameIsPaused);
        }
    }

    public void Resume()
    {

    	pauseMenuUI.SetActive(false);
    	Time.timeScale = 1f;
    	GameIsPaused = false;
    	Debug.Log("Escape: " + GameIsPaused);
    }

    void Pause()
    {
    	pauseMenuUI.SetActive(true);
    	Time.timeScale = 0f;
    	GameIsPaused = true;
    	Debug.Log("Escape: " + GameIsPaused);
    }

    public void LoadMenu()
    {

    	Time.timeScale = 1f;
    	SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {

    	Debug.Log("Quitting game...");
    	Application.Quit();
    }
}
