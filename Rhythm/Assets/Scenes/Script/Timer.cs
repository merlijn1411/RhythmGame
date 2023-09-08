using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float Seconde = 120f;
    public TextMeshProUGUI timeText;
    public float end = 1f;
    public bool stop;
    public GameObject pauze;

    private void Start ()
    {
        gameObject.SetActive (true);
    }


    private void Update()
    {
        addScore();
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {

        Seconde = Seconde - Time.deltaTime;
        timeText.text = Mathf.Floor(Seconde).ToString();

        if (Seconde <= end)
        {
            pauze.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
