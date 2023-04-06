using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("application is ended");
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("Home");
    }
}
