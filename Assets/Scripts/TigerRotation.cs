using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerRotation : MonoBehaviour
{
    private float accely = 0;
    private const float add = 30f;
    void Update()
    {
        accely = Input.acceleration.y+add;
        this.transform.Rotate(0, accely * Time.deltaTime, 0);
    }
}
