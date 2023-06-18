using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sentry;
using System;

public class Score : MonoBehaviour
{
    public int scoreAwarded;
    public bool ballBounce;

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
        
        if(ballBounce == false){
            PlayerPrefs.SetInt("totalScore", newScore);
            PlayerPrefs.Save();
            print("Your score is:");
            print(newScore);
            // @Fran edit upon rest of the ball
            ballBounce = true;
        }

        // SentrySdk.CaptureMessage("Something went wrong");
        // throw new Exception("Kobby test error from score feature");

    }

}

