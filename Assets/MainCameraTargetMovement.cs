using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraTargetMovement : MonoBehaviour
{
    public GameObject Target;

    public void FixedUpdate()
    {
        MoveToTarget();

        if (Input.GetButtonDown("Reset Camera")) {
            RotateToTargetRotation();
        }
    }

    private void MoveToTarget()
    {
        transform.Translate(Target.transform.position - transform.position);
    }

    private void RotateToTargetRotation()
    {
        transform.rotation = Target.transform.rotation;
    }
}
