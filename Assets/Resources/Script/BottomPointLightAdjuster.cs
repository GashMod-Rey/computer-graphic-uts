using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BottomPointLightAdjuster : MonoBehaviour
{

    public float theta = 0.1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(Vector3.zero,
                                    Vector3.right,
                                    theta);
    }

    void FixedUpdate() {
        if(Input.GetKey("-")) {
            theta -= 0.001f;
        }
        else if(Input.GetKey("=")) {
            theta += 0.001f;
        }    
    }
}
