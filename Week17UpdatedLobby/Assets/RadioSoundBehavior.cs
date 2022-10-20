using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSoundBehavior : MonoBehaviour
{

    public Vector3 startRotation;
    //bool hasGottenStartRotation = false;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetStartRotation()
    {
        startRotation = transform.localEulerAngles;
    }


    public void HandleDialTurn(float turnAmount)
    {
        Vector3 angles = startRotation;
        angles.y -= turnAmount;
        angles.y = Mathf.Clamp(angles.y, 0, 90);

        audio.volume = angles.y / 90;
        transform.localEulerAngles = angles;
        Debug.Log("Turn Amount: " + turnAmount);
    }
}
