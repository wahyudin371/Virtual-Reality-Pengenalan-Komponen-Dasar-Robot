using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satuscript : MonoBehaviour
{





    public GameObject pick;
    public GameObject buton;
    public GameObject komponens;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void baso()
    {

        pick.SetActive(false);

    }

    public void basi()
    {

        buton.SetActive(true);

    }

    public void basu()
    {

        komponens.SetActive(true);

    }

}
