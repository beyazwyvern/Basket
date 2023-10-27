using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float turnSpeed = 2.0f;
    private float x = 0.0f;
    private float y = 0.0f;

    void Update()
    {
        x += turnSpeed * Input.GetAxis("Mouse X");
        y -= turnSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(y, x, 0.0f);
    }

}
