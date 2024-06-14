using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{

    public GameObject nextsatu;
    public GameObject nextdua;
    public GameObject nexttiga;
    public GameObject nextempat;
    public GameObject nextlima;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void baswo()
    {

        nextsatu.SetActive(false);
        nextdua.SetActive(false);
        nexttiga.SetActive(false);
        nextempat.SetActive(false);
        nextlima.SetActive(true);


    }

}
