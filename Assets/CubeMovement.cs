using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
