using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void onQuitButton()
    {
        print("Quit Button");
        Application.Quit();
    }
    public void onSettingsButton()
    {
        print("settings BUtton Pressed");
    }
}