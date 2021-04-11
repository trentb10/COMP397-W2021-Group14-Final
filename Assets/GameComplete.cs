using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour
{
    public GameObject endUI;
    public Text pointsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            endUI.gameObject.SetActive(true);
        }
    }

    public void Setup(int score)
    {
       // gameObject.SetActive(true);
        pointsText.text = score.ToString() + "Points";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }

}
