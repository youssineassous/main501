using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamEchange : MonoBehaviour
{
    public Camera camera1; 
    public Camera camera2; 

    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}
