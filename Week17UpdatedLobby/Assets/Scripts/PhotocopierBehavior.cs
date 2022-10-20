using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotocopierBehavior : MonoBehaviour
{
    public Animator anim;

    public bool isPaperOnTray = false;

    public GameObject copyAttachPoint;

    private GameObject currentDoc;

    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        
       // anim = this.gameObject.GetComponentInParent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Photocopier");

        if (other.gameObject.CompareTag("Paper"))
        {
            isPaperOnTray = true;
            currentDoc = other.gameObject;
            //anim.SetBool("runPhotocopy", true);
        }
    }

/*    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Paper"))
        {
            isPaperOnTray = false;
            currentDoc = null;
        }
    }
*/
    public void Print()
    {
        if (isPaperOnTray)
        {
            Debug.Log("Got To Print");
            anim.SetBool("runPhotocopy", true);
            StartCoroutine("stopPhotocopyAnim");
            //anim.SetBool("runPhotocopy", false);
            Instantiate(currentDoc, copyAttachPoint.transform.position, copyAttachPoint.transform.rotation);

            //try it this way, next time might play with broadcasts
            PlayerGoals.HasFinishedGoal = true;
        }

    }


    IEnumerator stopPhotocopyAnim()
    {
        yield return new WaitForSeconds(2);
        anim.SetBool("runPhotocopy", false);
    }
}
