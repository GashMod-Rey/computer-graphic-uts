using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopSpotLightTubeAdjuster : MonoBehaviour
{
    bool isBackward = false;
    float spinSpeed = 2f;
    Vector3 RotateAmountX = new Vector3(50.0f, 0f, 0.0f);
    Vector3 TranslateAmountYZ = new Vector3(0.0f, 0.8f/2f, -1.2f/2f);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update() {
        if(isBackward == false){
            transform.Rotate(RotateAmountX * Time.deltaTime / spinSpeed);
            transform.Translate(TranslateAmountYZ * Time.deltaTime / spinSpeed);
        }      
        else
        {
            transform.Rotate(RotateAmountX * -Time.deltaTime / spinSpeed);
            transform.Translate(TranslateAmountYZ * -Time.deltaTime / spinSpeed);
        }

        if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x <= 120) {
            isBackward = false;
        }        
        else if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x >= 225) {
            isBackward = true;
        }
    }
}
