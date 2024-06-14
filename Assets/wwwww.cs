using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class wwwww : MonoBehaviour
{
    void Start()
    {
        EnableVRa();
    }


    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = enable;
    }


    public void DisableVR()
    {
        StartCoroutine(LoadDevice("Cardboard", false));
    }


    public void EnableVRa()
    {
        StartCoroutine(LoadDevice("Cardboard", true));
    }
}
