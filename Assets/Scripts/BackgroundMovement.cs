﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (new Vector3(0, 0 + RotateWithSlider.fallSpeed, 0));

        if(transform.position.y <= -60f)
        {
            transform.position = new Vector3(transform.position.x, 60f, transform.position.z);
        }
    }
}
