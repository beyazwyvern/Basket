using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float turnSpeed = 2.0f;

    private float x = 0.0f;
    private float y = 0.0f;
    bool closed = true;

    private void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, 0.0f);
        Invoke(nameof(OpenIt), 0.5f);
    }

    void OpenIt()
    {
        closed = false;
    }

    void Update()
    {
        if (!closed)
        {
            x += turnSpeed * Input.GetAxis("Mouse X");
            y -= turnSpeed * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(y, x, 0.0f);
        }
    }
}
