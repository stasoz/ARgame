using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCock : MainBehaviour
{
    [SerializeField]
    protected GameObject OurStart;
    [SerializeField]
    protected GameObject OurFinish;
    private void Start()
    {
        health = 1;
        smooth = 0.001f;
    }
    private void Update()
    {
        Move();
        CheckOnDie();
    }
    public override void Move()
    {
        transform.position = Vector3.Lerp(OurStart.transform.position, OurFinish.transform.position, Time.deltaTime*smooth);
    }
}
