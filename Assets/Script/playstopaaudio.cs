using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playstopaaudio : MonoBehaviour
{
    public AudioSource soundplayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playsuara() 
    {
        soundplayer.Play();
    
    }

    public void stopsuara()
    {
        soundplayer.Stop();

    }

}
