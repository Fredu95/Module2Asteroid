using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIcontrol : MonoBehaviour
{
    public static UIcontrol instance;
    [SerializeField] TextMeshProUGUI scoreText;
    
    [SerializeField] Image[] lifeImages;
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
        Debug.Log("liveUpdate");
        score += scoreChange;
        scoreText.text = score.ToString();
    }
    public void UpdateLives(int livesChange)
    {
       for (int i = 1; i < lifeImages.Length + 1; i++)
        {
            lifeImages[i - 1].enabled = lives >= i;
        }     
    }
}
