using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    private const float Speed = 10f;

    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z -= Speed * Time.deltaTime;
        transform.position = nextPosition;
    }
}