using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    int levelsunlocked;
    public Button[] Levels;
    void Start()
    {
        levelsunlocked = PlayerPrefs.GetInt("levelsunlocked",1);
        for(int i=0; i< Levels.Length; i++)
        {
            Levels[i].interactable = false;
        }
        for (int i = 0; i < levelsunlocked; i++)
        {
            Levels[i].interactable = true;
        }
    }

   public void loadlevel(int Levelindex)
    {
        SceneManager.LoadScene(Levelindex);
    }
}
