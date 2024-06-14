using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttondisable : MonoBehaviour
{
    public Button btn;
    public Button ptn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn1()
    {
        btn.interactable = false;
        ptn.interactable = true;
    }

    public void btn2()
    {

        ptn.interactable = true;

    }


}
