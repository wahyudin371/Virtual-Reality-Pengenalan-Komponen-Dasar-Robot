using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject motordckiri;
    public GameObject pick;
    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void picksd()
    {

        motordckiri.SetActive(true);
        pick.SetActive(false);
        ball.SetActive(false);
    }

    public void licksd()
    {

        motordckiri.SetActive(true);
        pick.SetActive(false);
        ball.SetActive(true);
    }


    public void diskdd()
    {


        pick.SetActive(true);
  
    }
}
