using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManagement : MonoBehaviour
{
    public GameObject leftHandTeleportControlRef;
    public GameObject leftHandDirectControlRef;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchControls()
    {
        leftHandTeleportControlRef.SetActive(!leftHandTeleportControlRef.activeSelf);
        leftHandDirectControlRef.SetActive(!leftHandDirectControlRef.activeSelf);
    }
}
