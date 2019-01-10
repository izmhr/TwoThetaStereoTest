using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMask : MonoBehaviour
{
    Camera cam;
    LayerMask layerL;
    LayerMask layerR;
    bool toggle = false;
    // Use this for initialization
    void Start()
    {
        cam = GetComponent<Camera>();
        layerL = LayerMask.NameToLayer("L");
        layerR = LayerMask.NameToLayer("R");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            toggle = !toggle;
            if (toggle)
            {
                cam.cullingMask = (1 << layerL);
            }
            else
            {
                cam.cullingMask = (1 << layerR);
            }
            
        }
    }
}
