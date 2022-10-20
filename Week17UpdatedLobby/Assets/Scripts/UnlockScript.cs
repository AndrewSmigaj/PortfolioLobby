using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScript : MonoBehaviour
{
    public GameObject doorHinge;

    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Key"))
        {
            Debug.Log("Key comparison true");
            doorHinge.transform.Rotate(0, 90, 0);
        }
    }
}
