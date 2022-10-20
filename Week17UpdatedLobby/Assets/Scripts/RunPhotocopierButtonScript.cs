using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunPhotocopierButtonScript : MonoBehaviour
{

    public GameObject parentPhotocopier;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered Button Manually");
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("Triggered print button");
            parentPhotocopier.GetComponent<PhotocopierBehavior>().Print();
        }
    }

}
