using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player;

    public Vector3 offset;
    public float positionOfset;

    private void FixedUpdate()
    {
        Vector3 TargetPosition = Player.position + offset;

        if (Player.position.y < transform.position.y + positionOfset)
        {
            transform.position = TargetPosition;
        }
    }
}
