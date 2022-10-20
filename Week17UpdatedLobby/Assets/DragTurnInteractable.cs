using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragTurnInteractable : DragInteractable
{

    public Vector3 startAngle = Vector3.zero;

    public bool startAngleSet = false;

    public float angleChange = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void StartDrag()
    {
        if (grabCalculationRoutine != null)
        {
            StopCoroutine(grabCalculationRoutine);
        }
        startAngle = GetLocalRotation(interactor.transform.rotation).eulerAngles;
        onGrabStart?.Invoke();
        grabCalculationRoutine = StartCoroutine(CalculateDrag());
    }

    public Quaternion GetLocalRotation(Quaternion targetInWorld)
    {
        return Quaternion.Inverse(targetInWorld) * transform.rotation;
    }
    protected override IEnumerator CalculateDrag()
    {
/*        if (!startAngleSet)
        {
            //get start angle
            startAngle = GetLocalRotation(interactor.transform.rotation).eulerAngles;
            startAngleSet = true;
        }*/
        while(interactor != null)
        {
            Quaternion localRotation = GetLocalRotation(interactor.transform.rotation);

            angleChange = startAngle.z - localRotation.eulerAngles.z;
            onDragUpdate?.Invoke(angleChange);
            yield return null;
        }
    }
}
