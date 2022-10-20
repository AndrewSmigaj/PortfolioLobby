using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class OpenSafeBehavior : MonoBehaviour
{

    public List<int> code = new List<int>(new int[] { 2, 3, 1 });
    public List<int> attempt = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterNextNum(int num)
    {
        attempt.Add(num);

        if(attempt.Count == 3)
        {
            if (attempt.SequenceEqual(code))
            {
                Debug.Log("Equal!");
            }
            else
            {
                Debug.Log("Not Equal!");
            }

            attempt = new List<int>();
        }
    }
}
