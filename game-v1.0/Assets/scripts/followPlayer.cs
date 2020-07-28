using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    // public Transform player;
    // public float smoothSpeed = 5.0f;
    // public Vector3 offset;
    // private float yaw = 0.0f;
    // private float pitch = 0.0f;
    // public float rollSpeed = 5.0f; 

    void Update ()
    {
        // if(player)
        // {
        //     offset = new Vector3(0.0f, 30.0f, -40.0f);
        //     Vector3 desiredPosition = player.TransformPoint(offset);
        //     Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //     transform.position = smoothedPosition;
        //     transform.LookAt(player);
        // }
        // yaw += rollSpeed * Input.GetAxis("Mouse X");
        // pitch -= rollSpeed * Input.GetAxis("Mouse Y");

        // transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
