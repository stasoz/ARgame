﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MainBehaviour
{
    [SerializeField]
    protected GameObject OurStart;
    [SerializeField]
    protected GameObject OurFinish;
    private void Start()
    {
        smooth = 0.0007f;
        health = 3;
    }
    private void Update()
    {
        Move();
        CheckOnDie();
    }
    public override void Move()
    {
        transform.position = Vector3.Lerp(OurStart.transform.position, OurFinish.transform.position, Time.time * smooth);
    }
}
