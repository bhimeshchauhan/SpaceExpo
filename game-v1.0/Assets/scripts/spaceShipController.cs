using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipController : MonoBehaviour
{
    public float rotate = 150.0f;  
    public float thrust = 90.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // private float roll = 10.0f;
    public GameObject leftShooter;
    public GameObject rightShooter;
    private Transform move;

    void Awake()
    {
        move = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yawController();
        pitchController();
        moveForward();
        throttle();
    }

    void throttle()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey("left shift"))
        {
           thrust = 500.0f;
        } else 
        {
            thrust = 90.0f;
        }
    }
 
    // Move Forward - move front - Key: ' W'
    void moveForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            move.position += move.forward * Time.deltaTime * thrust * Input.GetAxis("Vertical");
        }
    }

    // Pitch the ship - nose and tail up-down tilt - Key: 'Mouse'
    // Rotation - X
    float pitchController()
    {
        return rotate * Input.GetAxis("Mouse Y");
    }

    // Roll the ship - wing tip tilt - Key: 'A & D'
    // Rotation - Z
    Vector3 rollController()
    {
        return new Vector3();
    }

    // Yaw the ship - nose and tail side ways tilt - Key: 'Mouse'
    // Rotation - Y
    void yawController()
    {
        yaw = rotate * Time.deltaTime * Input.GetAxis("Horizontal");
        move.Rotate(0.0f, yaw, 0.0f);
        // return rotate * Input.GetAxis("Mouse X");
    }
}
