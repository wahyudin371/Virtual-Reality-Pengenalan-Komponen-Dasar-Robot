using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class menuawal : MonoBehaviour
{

    public GameObject awalx;
    public GameObject menuprofile;
    public GameObject menuexit;
    


    // Use this for initialization
    void Start()
    {
        awalx.SetActive(true);
        menuprofile.SetActive(false);
        menuexit.SetActive(false);
    }

    

    public void awlx()
    {
        menuprofile.SetActive(true);
        awalx.SetActive(false);
        menuexit.SetActive(false);
    }

    public void awlxx()
    {
        menuprofile.SetActive(false);
        awalx.SetActive(false);
        menuexit.SetActive(true);
    }

    public void awlxxx()
    {
        menuprofile.SetActive(false);
        awalx.SetActive(true);
        menuexit.SetActive(false);
    }

    public void exitgame()
    {
        Application.Quit();
    }

}