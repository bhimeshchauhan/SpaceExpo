using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform target;
    private Transform move;
    public Vector3 velocity = Vector3.one;
    private Vector3 defaultDistance = new Vector3(0.0f, 9.0f, -35.0f);
    public float distanceDamp = 0.5f;

    void Awake()
    {
        move = transform;
    }

    void LateUpdate ()
    {
        follow();
    }

    void follow()
    {
        Vector3 toPos = target.position + (target.rotation * defaultDistance);
        Vector3 currentPos = Vector3.SmoothDamp(move.position, toPos, ref velocity, distanceDamp);
        move.position = currentPos;

        move.LookAt(target, target.up);
    }
}
