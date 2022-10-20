using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportEnableScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject parentObject;
    public GameObject leftHandDirectPrefab;


    public void HandleAction(InputAction.CallbackContext context)
    {
        GameObject newControl = Instantiate(leftHandDirectPrefab, parentObject.transform.position, parentObject.transform.rotation);
        


        Debug.Log("WE MADE IT!");
    }
}
