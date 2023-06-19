using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LootLocker.Requests;
public class Menu : MonoBehaviour
{

    public void onPlayButton()
    {
        PlayerPrefs.SetInt("totalScore", 0);
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (!response.success)
            {
                Debug.Log("error starting Lootlocker session");
                return;
            }
            print(response.player_id);
            PlayerPrefs.SetInt("id", response.player_id);
            Debug.Log("successfully started Lootlocker session");
        });

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
