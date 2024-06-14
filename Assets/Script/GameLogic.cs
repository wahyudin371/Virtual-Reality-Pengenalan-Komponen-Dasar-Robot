using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameLogic : MonoBehaviour
{

    public GameObject mainMenuPanel;
    public GameObject menubahan1;
    public GameObject menubahan2;
    public GameObject menubahan3;
    public GameObject menubahan4;
    public GameObject menubahan5;
    public GameObject menubahan6;
    public GameObject menubahan7;
    public GameObject menubahan8;
    public GameObject menubahan9;
    public GameObject menubahan10;
    public GameObject menubahan11;
    public GameObject menubahan12;
    public GameObject menubahan13;
    public GameObject menubahan14;
    public GameObject komponens1;
    public GameObject komponens2;
    public GameObject komponens3;
    public GameObject komponens4;
    public GameObject komponens5;
    public GameObject komponens6;
    public GameObject komponens7;
    public GameObject komponens8;
    public GameObject komponens9;
    public GameObject komponens10;
    public GameObject komponens11;
    public GameObject komponens12;
    public GameObject komponens13;
    public GameObject komponens14;

    // Use this for initialization
    void Start()
    {
        mainMenuPanel.SetActive(true);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);
    }



    public void CreditClicked()
    {
        menubahan1.SetActive(true);
        mainMenuPanel.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(true);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);
    }

    public void AboutClicked()
    {
        menubahan2.SetActive(true);
        menubahan1.SetActive(false);
        mainMenuPanel.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(true);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);
    }

    public void AuthorMenu()
    {
        menubahan2.SetActive(false);
        menubahan1.SetActive(false);
        mainMenuPanel.SetActive(false);
        menubahan3.SetActive(true);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(true);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }



    public void BackClicked()
    {
        mainMenuPanel.SetActive(true);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }
    public void ExitMenu()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(true);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(true);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void mmMenu()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(true);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(true);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen6()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(true);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(true);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen7()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(true);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(true);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen8()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(true);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(true);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen9()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(true);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(true);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen10()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(true);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(true);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen11()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(true);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(true);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen12()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(true);
        menubahan13.SetActive(false);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(true);
        komponens13.SetActive(false);
        komponens14.SetActive(false);

    }

    public void bahankomponen13()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(true);
        menubahan14.SetActive(false);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(true);
        komponens14.SetActive(false);

    }

    public void bahankomponen14()
    {
        mainMenuPanel.SetActive(false);
        menubahan1.SetActive(false);
        menubahan2.SetActive(false);
        menubahan3.SetActive(false);
        menubahan4.SetActive(false);
        menubahan5.SetActive(false);
        menubahan6.SetActive(false);
        menubahan7.SetActive(false);
        menubahan8.SetActive(false);
        menubahan9.SetActive(false);
        menubahan10.SetActive(false);
        menubahan11.SetActive(false);
        menubahan12.SetActive(false);
        menubahan13.SetActive(false);
        menubahan14.SetActive(true);
        komponens1.SetActive(false);
        komponens2.SetActive(false);
        komponens3.SetActive(false);
        komponens4.SetActive(false);
        komponens5.SetActive(false);
        komponens6.SetActive(false);
        komponens7.SetActive(false);
        komponens8.SetActive(false);
        komponens9.SetActive(false);
        komponens10.SetActive(false);
        komponens11.SetActive(false);
        komponens12.SetActive(false);
        komponens13.SetActive(false);
        komponens14.SetActive(true);

    }
}