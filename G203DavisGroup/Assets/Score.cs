using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshPro ui;
    public int score = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.Equals("Bird")) 
        {
            score++;
            ui.text = "Bird" + score;
        }
    }
}
