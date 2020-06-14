using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCamMove : MonoBehaviour
{
    public Camera cam;
    Vector3 camPos;
    public float camSpeed = 0.25f;
    void Start()
    {
        cam = this.GetComponent<Camera>();
        camPos = this.transform.position;
    }
    void Update()
    {
        //up
        if (Input.GetKey(KeyCode.W))
        {
            camPos = new Vector3(this.transform.position.x, this.transform.position.y + camSpeed, this.transform.position.z);
            this.transform.position = camPos;
        }
        //down
        if (Input.GetKey(KeyCode.S))
        {
            camPos = new Vector3(this.transform.position.x, this.transform.position.y - camSpeed, this.transform.position.z);
            this.transform.position = camPos;
        }
        //Left
        if (Input.GetKey(KeyCode.A))
        {
            camPos = new Vector3(this.transform.position.x - camSpeed, this.transform.position.y, this.transform.position.z);
            this.transform.position = camPos;
        }
        //Right
        if (Input.GetKey(KeyCode.D))
        {
            camPos = new Vector3(this.transform.position.x + camSpeed, this.transform.position.y, this.transform.position.z);
            this.transform.position = camPos;
        }
    }
}
