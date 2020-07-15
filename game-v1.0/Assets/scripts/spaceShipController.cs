using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipController : MonoBehaviour
{
    public float speedH = 50.0f;
    public float speedV = 50.0f;  
    public float rollSpeed = 5.0f;  
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private float roll = 0.0f;
    private float thrust = 0.0f;
    GameObject ss;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        ss = GameObject.Find("spaceShip");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        // position and rotation
        Vector3 position = transform.position;
        Vector3 rotation = transform.rotation.eulerAngles;

        // roll
        // if (Input.GetKey("d"))
        // {
        //     transform.Rotate(0.0f, 0.0f, roll * Input.GetAxis( "Horizontal" ) * speedV * Time.deltaTime);
        // } 
        // else if (Input.GetKey("a"))
        // {
        //     transform.Rotate(0.0f, 0.0f, roll * Input.GetAxis( "Horizontal" ) * speedV * Time.deltaTime);
        // }else 
        if (Input.GetKey("w"))
        {
            Debug.Log("Move Forward");
            position = transform.forward * Time.deltaTime * speedV;
            transform.position += position;
        }
        yaw += rollSpeed * Input.GetAxis("Mouse X");
        pitch -= rollSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
 
    // Move Forward - move front - Key: 'W'
    // Position - Z
    Vector3 moveController()
    {
        return new Vector3();
    }

    // Pitch the ship - nose and tail up-down tilt - Key: 'Mouse'
    // Rotation - X
    Vector3 pitchController()
    {
        return new Vector3();
    }

    // Roll the ship - wing tip tilt - Key: 'A & D'
    // Rotation - Z
    Vector3 rollController()
    {
        return new Vector3();
    }

    // Yaw the ship - nose and tail side ways tilt - Key: 'Mouse'
    // Rotation - Y
    Vector3 yawController()
    {
        return new Vector3();
    }
}
