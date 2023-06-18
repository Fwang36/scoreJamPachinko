using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Sentry;
using System;

public class Score : MonoBehaviour
{
    [FormerlySerializedAs("score")]
    public int scoreAwarded;

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
        var newScore = PlayerPrefs.GetInt("totalScore")+ scoreAwarded;
        PlayerPrefs.SetInt("totalScore", newScore);
        PlayerPrefs.Save();
        print("Your score is:");
        print(newScore);

        // SentrySdk.CaptureMessage("Something went wrong");
        // throw new Exception("Kobby test error from score feature");
        
    }

}
