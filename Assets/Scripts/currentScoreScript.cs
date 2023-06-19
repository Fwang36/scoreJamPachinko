using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class currentScoreScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    int finalScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        finalScore = PlayerPrefs.GetInt("totalScore");
        
        if (gameObject.layer == LayerMask.NameToLayer("NoTextMeshPro"))
        {
            enabled = false; // Disable the script for this object
            return;
        }
        if (gameObject.layer == LayerMask.NameToLayer("scoreCapture"))
        {
            enabled = true; // Enable the script for this object
            Text = GetComponent<TextMeshProUGUI>();
            Text.text = "Score: " + PlayerPrefs.GetInt("totalScore").ToString();
            return;
        }
        if (gameObject.layer == LayerMask.NameToLayer("ballsLeft"))
        {
            enabled = true; // Enable the script for this object
            Text = GetComponent<TextMeshProUGUI>();
            Text.text = "Balls Left: " + PlayerPrefs.GetInt("count").ToString();
            return;
        }
        if (gameObject.layer == LayerMask.NameToLayer("scoreCaptureFrame"))
        {
            enabled = true; // Enable the script for this object
            Text = GetComponent<TextMeshProUGUI>();
            Text.text = PlayerPrefs.GetInt("totalScore").ToString();
            return;
        }
        if (gameObject.layer == LayerMask.NameToLayer("finalScore"))
        {
            enabled = true; // Enable the script for this object
            Text = GetComponent<TextMeshProUGUI>();
            Text.text = "Final Score: " + finalScore;
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
