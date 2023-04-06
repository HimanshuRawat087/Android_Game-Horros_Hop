using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public GameObject LevelSelectorCanvas;
    public GameObject HomeCanvas;

    public void Start()
    {
        LevelSelectorCanvas.SetActive(false);
    }
    public void PlayButton()
    {
        LevelSelectorCanvas.SetActive(true);
        HomeCanvas.SetActive(false);

    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("application is ended");
    }

    public void BackButton()
    {
        LevelSelectorCanvas.SetActive(false);
        HomeCanvas.SetActive(true);
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
}
