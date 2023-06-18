using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class currentScoreScript : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
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
        if (gameObject.layer == LayerMask.NameToLayer("scoreCaptureFrame"))
        {
            enabled = true; // Enable the script for this object
            Text = GetComponent<TextMeshProUGUI>();
            Text.text = PlayerPrefs.GetInt("totalScore").ToString();
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
