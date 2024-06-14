using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject satu;
    public GameObject dua;
    public GameObject tiga;
    public GameObject empat;
    public GameObject lima;
    public GameObject enam;
    public GameObject tujuh;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hilangmassal()
    {
        Destroy(satu);
        Destroy(dua);
        Destroy(tiga);
        Destroy(empat);
        Destroy(lima);
        Destroy(enam);
        Destroy(tujuh);
  

    }
}
