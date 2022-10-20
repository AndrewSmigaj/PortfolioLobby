using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarBehavior : MonoBehaviour
{

    private bool isMoving;
    public float moveSpeed = 1;

    public InputAction gasChange;

    public GameObject xrRig;
    public GameObject xrRigOrigin;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
        gasChange.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //if (isMoving)
        if (isMoving && this.xrRig != null)
            {
            moveSpeed = gasChange.ReadValue<float>();
            transform.position = transform.TransformPoint(Vector3.forward * moveSpeed * 1.5f);

        }
        xrRig.transform.position = xrRigOrigin.transform.position;
        xrRig.transform.rotation = xrRigOrigin.transform.rotation;
    }

    public void OnRotateChange(float dragPercent)
    {
        //.5 is no rotation so we want 
        //put it on a range of -30 to 30 degrees
        if(xrRig != null)
        {
            float newAngle = -1 * (dragPercent * 180 - 90) * Time.deltaTime;

            this.transform.Rotate(transform.up * newAngle);
            //xrRig.transform.Rotate(transform.up * newAngle);
        }

        //this.transform.RotateAround(transform.up, newAngle);
    }

    public void SetXRRigReferenceForCar()
    {
        this.xrRig = CrossSceneRefs.XrRigPers;
    }
}
