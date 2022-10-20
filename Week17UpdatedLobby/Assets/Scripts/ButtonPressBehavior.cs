using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressBehavior : MonoBehaviour
{

    public GameObject door;
    public int buttonNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            door.GetComponent<OpenSafeBehavior>().EnterNextNum(buttonNumber);
        }
    }
}
