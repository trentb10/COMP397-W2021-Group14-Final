using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaManage : MonoBehaviour
{
    bool gameHasEnded = false;
    bool gameCompleted = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject levelCompleted;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
   

    public void LevelCompleted()
    {
        levelCompleted.SetActive(true);
    }

    public void CompletedUI()
    {
        if(gameCompleted == false)
        {
            gameCompleted = true;
            Debug.Log("Level Completed");
            levelCompleted.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            completeLevelUI.SetActive(true);
            //Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.lockState = CursorLockMode.Locked;


    }
}
