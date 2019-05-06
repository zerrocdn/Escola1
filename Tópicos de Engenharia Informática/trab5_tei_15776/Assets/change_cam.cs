using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_cam : MonoBehaviour
{
    public GameObject cameraOne, cameraTwo;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        changeCamera();
    }
    void changeCamera()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
    }
}
