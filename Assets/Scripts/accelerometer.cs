using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour
{   
    public float speed = 20.0f;
    private bool isFlat = true;
    private Rigidbody rb;

    private void Start(){
        rb = GetComponent<Rigidbody>();
        PlayerPrefs.DeleteAll();
        Screen.sleepTimeout = SleepTimeout.NeverSleep;


    }
    private void Update(){

        Vector3 tilt = Input.acceleration * speed;
        if(isFlat){
            tilt= Quaternion.Euler(90,0,0) * tilt;
        }
        rb.AddForce(tilt);
        Debug.DrawRay(transform.position + Vector3.up, tilt);

    }
}
