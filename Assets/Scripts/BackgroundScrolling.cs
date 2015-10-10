﻿using UnityEngine;
using System.Collections;

public class BackgroundScrolling : MonoBehaviour
{
    public Vector2 speed = new Vector2(1, 1); // scrolling speed
    public Vector2 direction = new Vector2(-1, 0); // moving direction

    void Update()
    {
        Vector3 movement = new Vector3(
          speed.x * direction.x,
          speed.y * direction.y,
          0);

        movement *= Time.deltaTime;
        transform.Translate(movement);
    }
}
