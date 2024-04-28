using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Winner : MonoBehaviour
{
    public Button Play;
    public Button Quit;

    public void Play_game(){
        SceneManager.LoadScene("Game");
    }
    public void Quit_game(){
        Application.Quit();
    }
}
