using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVCameraController : MonoBehaviour
{
    public float turnSpeed = 5f;

    public float turnAngle = 90;
    // Start is called before the first frame update
    bool turningRight = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(turningRight)
        {
            TurnRight();
        }
        else
        {
            TurnLeft(); 
        CheckAngle();
        }
    }
    void TurnRight() {
        transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
    }

    void TurnLeft()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
    }
    void CheckAngle()
    {
        //TODO: zawracaj kamere
        ///Debug.Log("y: " + transform.eulerAngles.y + ", a ")
    }
}
