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
        Text = FindObjectOfType<TextMeshProUGUI>();
        Text.text = PlayerPrefs.GetInt("totalScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
