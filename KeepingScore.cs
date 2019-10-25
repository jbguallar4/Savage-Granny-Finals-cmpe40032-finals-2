using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeepingScore : MonoBehaviour
{
    public static int Score;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + Score.ToString();
    }
}
