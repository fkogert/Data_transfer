using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        OutBestScore();
    }




    public void OutBestScore()
    {
        scoreText.text = "Best Score: " + Manager.bestScoreName + " - " + Manager.bestScore;
    }
}
