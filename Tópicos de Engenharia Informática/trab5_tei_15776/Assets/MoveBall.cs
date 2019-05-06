using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBall : MonoBehaviour
{
    public Text clickLabel;
    public Rigidbody rb;
    public float x, y, z;
    public int force, clicks;
   
    void Start()
    {

      rb =  GameObject.Find("Sphere").GetComponent<Rigidbody>();
        x = 0;
        y = 0;
        z = 0;
        force = 35;
        clicks = 0;
    }

    public void frente()
    {
        rb.AddForce(x, y, force, ForceMode.Impulse);
    }
    public void tras()
    {
        rb.AddForce(x, y, -1 * force, ForceMode.Impulse);
    }
    public void esquerda()
    {
        rb.AddForce(-1 * force, y, z, ForceMode.Impulse);
    }
    public void direita()
    {
        rb.AddForce(force, y, z, ForceMode.Impulse);
    }

    public void clicked()
    {

    }
    private void Update()
    {
        counter();
    }
    public void counter()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.rigidbody != null) {
                    clicks++;
                    clickLabel.text = clicks + "";
                }
                
            }
        }
    }
}
