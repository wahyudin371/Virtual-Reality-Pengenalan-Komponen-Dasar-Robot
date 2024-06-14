using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ssxsss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DisableVRs();
    }


    IEnumerator LoadDevice(string newDevice, bool enable)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = enable;
    }


    public void DisableVRs()
    {
        StartCoroutine(LoadDevice("Cardboard", false));
    }


    public void EnableVRas()
    {
        StartCoroutine(LoadDevice("Cardboard", true));
    }
}
