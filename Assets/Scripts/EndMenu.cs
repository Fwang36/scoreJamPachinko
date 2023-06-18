using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void onBackButton()
    {
        SceneManager.LoadScene(0);
    }
    public void onQuitButton()
    {
        print("Quit Button");
        Application.Quit();
    }

}