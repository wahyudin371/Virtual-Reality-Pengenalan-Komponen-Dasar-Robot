using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{

   
    public GameObject myHand;
    public GameObject ball;
    public GameObject balls;
    public GameObject pick;


    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update(){

    }

    public void ballh()
    {
        balls.SetActive(true);
        pick.SetActive(true);

    }

    

    public void DestroyGameObject()
    {
        
        ball.transform.SetParent(myHand.transform);
        ball.transform.localPosition = new Vector3(0f, -0.24f, 0f);
    }
}
