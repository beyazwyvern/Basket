using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public int speed = 1000;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject basket = transform.GetChild(1).gameObject;
            basket.transform.parent = null;
            basket.GetComponent<Rigidbody>().useGravity = true;
            basket.GetComponent<Rigidbody>().isKinematic = false;
            basket.GetComponent<Rigidbody>().AddForce(transform.GetChild(0).transform.forward * speed);
            Invoke(nameof(NewBall), 0.5f);
            source.PlayOneShot(clip);
        }
    }
    void NewBall()
    {
        GetComponent<TopOlusturma>().CreateBall();
    }
}
