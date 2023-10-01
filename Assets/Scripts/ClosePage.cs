using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClosePage : MonoBehaviour
{
    public GameObject page;

    public void Close()
    {
        page.SetActive(false);
    }

    public void BackToMain()
    {
        Debug.Log("Returning to main menu!");
        SceneManager.LoadScene(0);
    }

    public void WonToMain()
    {

        SceneManager.LoadScene(0);
    }

}
