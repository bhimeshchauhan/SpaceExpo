using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipController : MonoBehaviour
{
    public float speed = 150.0f;  
    public float thrust = 90.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    // private float roll = 10.0f;
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;
    public GameObject rock5;
    public GameObject rock6;
    public GameObject rock7;
    public GameObject leftShooter;
    public GameObject rightShooter;
    private static List<GameObject> rockesAssortments;
    private float random;

    float getRandom()
    {
        random =  Random.Range(-1000.0f, 1000.0f);
        if (random < 0) 
        {
            random -= 100;
        }
        else 
        {
            random += 100;
        }
        return random;
    }

    // Start is called before the first frame update
    void Start()
    {
        rockesAssortments =  new List<GameObject> {rock1, rock2, rock3, rock4, rock5, rock6, rock7};
        Cursor.visible = false;
        for (int i = 0; i < 100; i++) 
        {
            int index = Random.Range(0, rockesAssortments.Count);
            Instantiate(rockesAssortments[index], new Vector3(getRandom(), getRandom(), getRandom()), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        yaw += yawController();
        pitch -= pitchController();
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Input.GetKey(KeyCode.W) && Input.GetKey("left shift"))
        {
           thrust = 200.0f;
        } else {
            thrust = 90.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            moveForward();
        }
    }
 
    // Move Forward - move front - Key: 'W'
    // Position - Z
    void moveForward()
    {
        transform.position += transform.forward * Time.deltaTime * thrust;
    }

    // Pitch the ship - nose and tail up-down tilt - Key: 'Mouse'
    // Rotation - X
    float pitchController()
    {
        return speed * Input.GetAxis("Mouse Y");
    }

    // Roll the ship - wing tip tilt - Key: 'A & D'
    // Rotation - Z
    Vector3 rollController()
    {
        return new Vector3();
    }

    // Yaw the ship - nose and tail side ways tilt - Key: 'Mouse'
    // Rotation - Y
    float yawController()
    {
        return speed * Input.GetAxis("Mouse X");
    }
}
