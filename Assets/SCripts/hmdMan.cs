using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class hmdMan : MonoBehaviour
{
    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("DEVICE IN USE : "+ XRSettings.loadedDeviceName);
        if(XRSettings.isDeviceActive)
        {
            fpsPlayer.SetActive(false);
            xrPlayer.SetActive(true);
        }
        else
        {
            fpsPlayer.SetActive(true);
            xrPlayer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
