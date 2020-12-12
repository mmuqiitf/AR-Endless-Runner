using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    //public TextMeshProUGUI finalScore;
    //public TextMeshProUGUI highScore;

    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        //highScore.text = PlayerPrefs.GetInt("High Score", 0).ToString();
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void ChangeScore(int value)
    {
        score = score + value;
        Debug.Log("Score: " + score);
        text.text = score.ToString();
    }


}
