using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redball : MonoBehaviour
{
    public Rigidbody rb;
    public float x, y, z;
    public int jumpforce, force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpforce = 50;
        force = 35;
        x = 0;
        y = 0;
        z = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(x, y, z, ForceMode.Impulse);
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(x, jumpforce, z, ForceMode.Impulse);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(x, y, force, ForceMode.Force);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1 * force, y, z, ForceMode.Force);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(x, y, -1 * force, ForceMode.Force);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(force, y, z, ForceMode.Force);
        }




    }
}
