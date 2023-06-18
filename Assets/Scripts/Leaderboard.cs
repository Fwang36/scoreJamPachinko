using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
public class Leaderboard : MonoBehaviour
{
    // Start is called before the first frame update
    string leaderboardKey = "ADescriptiveKey_ThatYouSetInTheConsole";
    int count = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnLoadLeaderboard() 
    {


    LootLockerSDKManager.GetScoreList(leaderboardKey, count, 0, (response) =>
{
    if (response.statusCode == 200) {
        Debug.Log("Successful");
    } else {
        Debug.Log("failed: " + response.Error);
    }
});
    }
}
