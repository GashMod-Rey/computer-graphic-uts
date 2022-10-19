using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TopSpotLightTubeAdjuster : MonoBehaviour
{
    bool isBackward = false;
    float spinSpeed = 2f;
    Vector3 RotateAmountX = new Vector3(50.0f, 0f, 0.0f);
    Vector3 TranslateAmountYZ1 = new Vector3(0.0f, 0.5f/2f, 1.1f/2f);
    Vector3 TranslateAmountYZ2 = new Vector3(0.0f, 1.4f/2f, -0.1f/2f);
    float positionY;
    // Start is called before the first frame update
    void Start()
    {
        positionY = transform.position.y;
    }

    // Update is called once per frame
    void Update() {
        if(positionY > 13) {
            if(isBackward == false){
                transform.Rotate(RotateAmountX * Time.deltaTime / spinSpeed);
                transform.Translate(TranslateAmountYZ1 * Time.deltaTime / spinSpeed);
            }      
            else
            {
                transform.Rotate(RotateAmountX * -Time.deltaTime / spinSpeed);
                transform.Translate(TranslateAmountYZ1 * -Time.deltaTime / spinSpeed);
            }

            if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x <= 0) {
                isBackward = false;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.position = new Vector3(transform.position.x, 13.03502f, 12.23554f);
            }        
            else if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x >= 90) {
                isBackward = true;
                transform.rotation = Quaternion.Euler(90, 0, 0);                           
            }
        }
        else
        {
            if(isBackward == true){
                transform.Rotate(RotateAmountX * -Time.deltaTime / spinSpeed);
                transform.Translate(TranslateAmountYZ2 * Time.deltaTime / spinSpeed);
            }      
            else
            {
                transform.Rotate(RotateAmountX * Time.deltaTime / spinSpeed);
                transform.Translate(TranslateAmountYZ2 * -Time.deltaTime / spinSpeed);
            }

            if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x <= -90) {
                isBackward = false;
                transform.rotation = Quaternion.Euler(-90, 0, 0);
            }        
            else if(UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x >= 0) {
                isBackward = true;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                transform.position = new Vector3(transform.position.x, 12.49679f, 13.15581f);
                
            }
        }
    }
}
