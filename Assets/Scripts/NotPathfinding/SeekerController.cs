﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CountPath))]
public class SeekerController : MonoBehaviour {

    CountPath counter;
    public Transform target;

    public bool autoCountPath;

    void Start () {
        counter = GetComponent<CountPath>();
    }

    void Update () {
        if (autoCountPath)
        {
            counter.FindPath(transform, target);
        }
        else {
            if (Input.GetButtonDown("Jump"))
            {
                counter.FindPath(transform, target);
            }
        }
    }
}
