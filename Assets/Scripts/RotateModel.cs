using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModel : MonoBehaviour {

    float rotateSpeed = 100;

    void OnMouseDrag()
    {
        //float x = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;
        float y = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;
        //transform.Rotate(Vector3.up,-x);
        transform.Rotate(Vector3.right, y);
    }
}
