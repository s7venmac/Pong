using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class Count_Score : MonoBehaviour
{
    public Text score;
    public GameObject ball;
    public int ScoreWin;
    public static bool canAddScore = true;
    private int teamleft = 0;
    private int teamright = 0;
    void Start()
    {
        canAddScore = true;
    }

    void Update()
    {
        if(ball.transform.position.x >= 13f && canAddScore){
            canAddScore =false;
            teamleft++;
        }
        if(ball.transform.position.x <= -13f && canAddScore){
            canAddScore = false;
            teamright++;
        }
        if(teamleft >= ScoreWin ){
            teamleft = 0;
            SceneManager.LoadScene("WinnerLeft");
        }
        if(teamright >= ScoreWin){
            teamright = 0;
            SceneManager.LoadScene("WinnerRight");
        }
        score.text = teamleft.ToString() + " - " + teamright.ToString();
    }
}
