using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sentry;
using System;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public int scoreAwarded;
    public bool ballBounce;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        var newScore = PlayerPrefs.GetInt("totalScore") + scoreAwarded;
        // count = 0;
        if(ballBounce == false){
            PlayerPrefs.SetInt("totalScore", newScore);
            PlayerPrefs.Save();
            print("Your score is:");
            print(newScore);
            count = count + 1;

            // @Fran edit upon rest of the ball each round 
            ballBounce = true;
            //@Fran set the code below when restarting the game
            // PlayerPrefs.SetInt("totalScore", 0);
            
        }

        OnBallStop();

        // SentrySdk.CaptureMessage("Something went wrong");
        // throw new Exception("Kobby test error from score feature");

    }

    public void OnBallStop()
    {
        ballBounce = false;
        print("Current Count");
        print(count);
        SceneManager.LoadScene(1);
    }

}

