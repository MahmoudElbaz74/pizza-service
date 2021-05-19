using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public Rigidbody rb;

    public float f = 500f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(f * Time.deltaTime ,0 , 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce( 0,  0 , f * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce( 0 , 0, -f * Time.deltaTime);
        }
    }
}
