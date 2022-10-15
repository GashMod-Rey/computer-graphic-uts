using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdjuster : MonoBehaviour
{
    // float translateSpeed = 1.0f;
    int spinSpeed = 2;

    Vector3 TranslateAmountX = new Vector3(10.0f, 0.0f, 0.0f);
    Vector3 TranslateAmountY = new Vector3(0.0f, 0.0f, 10.0f);

    public Vector2 rotation;
    public float sensitivity = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W)) {
            transform.Translate(TranslateAmountY * Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.S)) {
            transform.Translate(TranslateAmountY * -Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.A)) {
            transform.Translate(TranslateAmountX * -Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.D)) {
            transform.Translate(TranslateAmountX * Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(TranslateAmountY * Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(TranslateAmountY * -Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(TranslateAmountX * Time.deltaTime / spinSpeed);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(TranslateAmountX * -Time.deltaTime / spinSpeed);
        }

        rotation.x += Input.GetAxis("Mouse X") * sensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(-rotation.y, rotation.x, 0);
    }
}
