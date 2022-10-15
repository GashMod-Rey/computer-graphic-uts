using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SunRotation : MonoBehaviour
{

    public float theta = 0.1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(Vector3.zero,
                                    Vector3.right,
                                    theta);
    }
}
