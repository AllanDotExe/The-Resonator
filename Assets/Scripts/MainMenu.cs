using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject credits;
    public GameObject instructions;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("GAME QUIT!");
        Application.Quit();
    }

    public void OpenCredits()
    {
        credits.SetActive(true);
    }

    public void OpenInstructions()
    {
        instructions.SetActive(true);
    }
}
