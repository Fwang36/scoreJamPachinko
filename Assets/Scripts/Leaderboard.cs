using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using TMPro;


public class Leaderboard : MonoBehaviour
{
    // Start is called before the first frame update
    string leaderboardKey = "Pachanks";
    public TextMeshProUGUI playerNames;
    public TextMeshProUGUI playerScores;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnLoadLeaderboardFinal()
    {
        StartCoroutine( OnLoadLeaderboard());
    }

    public IEnumerator OnLoadLeaderboard() 
    {
        Debug.Log("Testing");
        bool done = false;
        LootLockerSDKManager.GetScoreList(leaderboardKey, 5, 0, (response) =>
        {
            if (response.success) {
                string tempPlayerNames = "Names\n";
                string tempPlayerScores = "Scores\n";
                Debug.Log("Successful");
                Debug.Log(tempPlayerNames);
                Debug.Log(tempPlayerNames);
                LootLockerLeaderboardMember[] members = response.items;
                for (int i = 0; i < members.Length; i++){
                    Debug.Log("Forloop");
                    tempPlayerNames += members[i].rank + ".  ";
                    tempPlayerNames += members[i].member_id + ".  "; 
                    tempPlayerScores += members[i].score + "\n";
                    tempPlayerNames += "\n";
                }
                print(tempPlayerNames);
                print(tempPlayerScores);
                done = true;
                playerNames.text = tempPlayerNames;
                playerScores.text = tempPlayerScores;
            } else {
                Debug.Log("failed: " + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(()=> done == false);
    }
}
