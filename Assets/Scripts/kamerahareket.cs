using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerahareket : MonoBehaviour
{
    float x_mouse;
    float y_mouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_mouse = Input.GetAxis("Mouse Y");
        y_mouse = Input.GetAxis("Mouse X");

        transform.Rotate(-x_mouse, y_mouse, 0);
        transform.Rotate(0, y_mouse, 0,Space.World);
    }
}
