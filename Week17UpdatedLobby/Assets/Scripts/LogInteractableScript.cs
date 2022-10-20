using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LogInteractableScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LogHoverEnter(HoverEnterEventArgs eventArgs )
    {
        Debug.Log("Got here");
        Debug.Log(eventArgs.interactableObject.transform.gameObject.name);
        Debug.Log(eventArgs.interactableObject.transform.gameObject.tag);
    }
}
