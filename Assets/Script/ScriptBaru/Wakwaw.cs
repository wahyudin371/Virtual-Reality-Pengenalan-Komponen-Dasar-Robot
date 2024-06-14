using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wakwaw : MonoBehaviour
{

    public GameObject mainMenuPanelx;
    public GameObject menubahan1x;
    public GameObject menubahan2x;
    public GameObject menubahan3x;
    public GameObject menubahan4x;
    public GameObject menubahan5x;
    public GameObject menubahan6x;
    public GameObject menubahan7x;
    public GameObject menubahan8x;
    public GameObject menubahan9x;
    public GameObject menubahan10x;
    public GameObject menubahan11x;

    public GameObject komponens1x;
    public GameObject komponens2x;
    public GameObject komponens3x;
    public GameObject komponens4x;
    public GameObject komponens5x;
    public GameObject komponens6x;
    public GameObject komponens7x;
    public GameObject komponens8x;
    public GameObject komponens9x;
    public GameObject komponens10x;
    public GameObject feedbenar, feedsalah;


    // Use this for initialization
    void Start()
    {
        mainMenuPanelx.SetActive(true);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);

        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);
     
    }

    public void jawaban(bool jawab)
    {
        if (jawab)
        {
            feedbenar.SetActive(false);
            feedbenar.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor") + 10;
            PlayerPrefs.SetInt("skor", skor);
        }
        else
        {
            feedsalah.SetActive(false);
            feedsalah.SetActive(true);
        }
    }

    public void Bahanxx1()
    {
        menubahan1x.SetActive(true);
        mainMenuPanelx.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);

        komponens1x.SetActive(true);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);

    }

    public void Bahanxx2()
    {
        menubahan2x.SetActive(true);
        menubahan1x.SetActive(false);
        mainMenuPanelx.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
       
        komponens1x.SetActive(false);
        komponens2x.SetActive(true);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);

    }

    public void Bahanxx3()
    {
        menubahan2x.SetActive(false);
        menubahan1x.SetActive(false);
        mainMenuPanelx.SetActive(false);
        menubahan3x.SetActive(true);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
        
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(true);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);


    }



    public void BackClickedx()
    {
        mainMenuPanelx.SetActive(true);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
       
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);
        

    }
    public void Bahanxx4()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(true);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
        
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(true);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);
        

    }

    public void Bahanxx5()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(true);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);

        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(true);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);


    }

    public void Bahanxx6()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(true);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
;
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(true);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);


    }

    public void Bahanxx7()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(true);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
        
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(true);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);


    }

    public void Bahanxx8()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(true);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
       
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(true);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);
       

    }

    public void Bahanxx9()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(true);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(false);
       
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(true);
        komponens10x.SetActive(false);
 

    }

    public void Bahanxx10()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(true);
        menubahan11x.SetActive(false);
       
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(true);
   

    }

    public void Bahanxx11()
    {
        mainMenuPanelx.SetActive(false);
        menubahan1x.SetActive(false);
        menubahan2x.SetActive(false);
        menubahan3x.SetActive(false);
        menubahan4x.SetActive(false);
        menubahan5x.SetActive(false);
        menubahan6x.SetActive(false);
        menubahan7x.SetActive(false);
        menubahan8x.SetActive(false);
        menubahan9x.SetActive(false);
        menubahan10x.SetActive(false);
        menubahan11x.SetActive(true);
       
        komponens1x.SetActive(false);
        komponens2x.SetActive(false);
        komponens3x.SetActive(false);
        komponens4x.SetActive(false);
        komponens5x.SetActive(false);
        komponens6x.SetActive(false);
        komponens7x.SetActive(false);
        komponens8x.SetActive(false);
        komponens9x.SetActive(false);
        komponens10x.SetActive(false);
   

    }

    }