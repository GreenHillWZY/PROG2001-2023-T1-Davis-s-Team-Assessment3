using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text ui;
    public int score = 0;
    public GameObject congratulationsPanel; //ÃÌº”“˝”√
    public int targetScore = 4;

    void Start()
    {
        ui.text = "Bird: " + score;
        congratulationsPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Bird"))
        {
            score++;
            ui.text = "Bird: " + score;
            Destroy(other.gameObject);

            if (score == targetScore)
            {
                congratulationsPanel.SetActive(true);
            }
        }
    }
}