using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject horros;
    public GameObject ball;
    public GameObject PauseUI;
    
     
    void Start()
    {
        PauseUI.SetActive(false);
    }

    public void PauseButton()
    {
        horros.SetActive(false);
        ball.SetActive(false);
        PauseUI.SetActive(true);
    }
    
    public void ResumeButton()
    {
        horros.SetActive(true);
        ball.SetActive(true);
        PauseUI.SetActive(false);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("Home");
    }

    public void nextlevelbutton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }   
}
