using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BottomPointLightAdjuster : MonoBehaviour
{
    bool isBackward = false;
    int spinSpeed = 2;
    Vector3 RotateAmountX = new Vector3(50.0f, 0f, 0.0f);
    Vector3 RotateAmountY = new Vector3(0.0f, 50.0f, 0.0f);
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float cubeTime = Time.time;
        if(cubeTime % 1.0f == 0) {
            var valueR = Random.Range(0.0f, 1.0f);
            var valueG = Random.Range(0.0f, 1.0f);
            var valueB = Random.Range(0.0f, 1.0f);
            lt.color = new Color(valueR, valueG, valueB);
        }
    }

    void Update() {
        if(isBackward == false){
            transform.Rotate(RotateAmountY * Time.deltaTime / spinSpeed);
        }      
        else
        {
            transform.Rotate(RotateAmountY * -Time.deltaTime / spinSpeed);
        }

        if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).y <= 160) {
            isBackward = false;
        }        
        else if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).y >= 200) {
            isBackward = true;
        }
    }
}