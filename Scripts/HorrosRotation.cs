using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrosRotation : MonoBehaviour
{
    public float rotatorspeed;

    private void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector3 Rotation = Input.GetTouch(0).deltaPosition;
            transform.Rotate(0, - Rotation.x * rotatorspeed * Time.deltaTime, 0);
                
        }
    }
}
