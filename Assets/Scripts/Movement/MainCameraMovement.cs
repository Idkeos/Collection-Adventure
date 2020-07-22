using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraMovement : MonoBehaviour
{
    public float TurnSpeed = 200f;
    private float TurnInputValue;

    private Vector3 LocalStartPos;
    private Quaternion LocalStartRot;

    private void Start()
    {
        LocalStartPos = gameObject.transform.localPosition;
        LocalStartRot = gameObject.transform.localRotation;
    }

    private void Update()
    {
        TurnInputValue = Input.GetAxis("Horizontal Camera");
    }

    private void LateUpdate()
    {   
        RoateCamera();

        if (Input.GetButtonDown("Reset Camera")) {
            ResetCamera();
        }
    }

    private void RoateCamera()
    {
        transform.RotateAround(transform.parent.position, Vector3.up, -1 * TurnInputValue * TurnSpeed * Time.deltaTime);
    }

    private void ResetCamera()
    {
        transform.localPosition = LocalStartPos;
        transform.localRotation = LocalStartRot;
    }
}
