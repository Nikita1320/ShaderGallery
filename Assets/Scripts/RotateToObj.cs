using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToObj : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private Vector3 vectorFromObj;
    private Vector3 target;

    private void Update()
    {
        vectorFromObj = transform.position - obj.transform.position;
        target = Vector3.ProjectOnPlane(vectorFromObj, transform.up);

        transform.forward = target;
    }
}
