using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerQuiz : MonoBehaviour
{

    public GameObject[] Levels;
    public GameObject ResetScreen, End;
    public GameObject soalsatu, soaldua, soaltiga,soalempat,soallima,soalenam,soaltujuh,soaldelapan,soalsembilan,soalsepuluh;

    int currentLevel;


    public void wrongAnswer()
    {
        ResetScreen.SetActive(true);
        soalsatu.SetActive(false);
        soaldua.SetActive(false);
        soaltiga.SetActive(false);
        soalempat.SetActive(false);
        soallima.SetActive(false);
        soalenam.SetActive(false);
        soaltujuh.SetActive(false);
        soaldelapan.SetActive(false);
        soalsembilan.SetActive(false);
        soalsepuluh.SetActive(false);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void pindahscene()
    {
        Application.LoadLevel(0);
    }







    public void correctAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }




}