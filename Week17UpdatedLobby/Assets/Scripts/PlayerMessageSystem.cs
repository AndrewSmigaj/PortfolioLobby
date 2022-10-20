using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMessageSystem : MonoBehaviour
{
    public TMPro.TextMeshProUGUI playerMessageDisplay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SwitchOffIntroMessage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SwitchOffIntroMessage()
    {
        yield return new WaitForSeconds(5);
        playerMessageDisplay.text = "";
        
    }
}
