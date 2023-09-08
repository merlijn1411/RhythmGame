using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Textscore;
    public int score;

        void start()
    {
        score= 0;
    }
    private void Update ()
    {
        Textscore.text  = score.ToString();
    }
    public void addscore()
    {
        score += 10;
    }
}
