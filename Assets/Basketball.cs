using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    public int speed = 1000;
    public GameObject basketballPrefab;
    public bool originalBall = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!originalBall)
            {
                transform.parent = null;
                GetComponent<Rigidbody>().useGravity = true;
                GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
            }            
            if (originalBall)
            {
                gameObject.SetActive(false);
                Invoke(nameof(BasketballGenerator), 1.5f);
            }                
        }
    }

    public void BasketballGenerator()
    {
        GameObject newBasketball = Instantiate(basketballPrefab, basketballPrefab.transform.position, Quaternion.identity);
        newBasketball.GetComponent<Basketball>().originalBall = false;
        newBasketball.transform.parent = Camera.main.transform;
        newBasketball.gameObject.SetActive(true);        
    }
}
