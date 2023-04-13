using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIcontrol : MonoBehaviour
{
    public static UIcontrol instance;
    [SerializeField] TextMeshProUGUI scoreText;
    public int lives = 4;
    public int score = 0;
    
    void Start() {
        if (instance != null)
        {
            Destroy(gameObject,0);
        }
        else
        {
            instance = this;
        }
        
    }
   /* void Update()
    {
         scoreText.text = score.ToString();
    }*/
    public void UpdateScore(int scoreChange)
    {
        score += scoreChange;
        scoreText.text = score.ToString();
    }
    public void UpdateLives(int livesChange)
    {
        lives += livesChange;
    }


}
