using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class MainBehaviour : MonoBehaviour
{
    public int health;
    public float smooth;
    public static int count;
    public abstract void Move();
    public virtual void OnTriggerEnter(Collider other)
    {
        if(other.tag=="banana")
        {
            Destroy(gameObject);
            count++;
        }
    }
    public virtual void CheckOnDie()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            count++;
        }
    }
    public virtual void OnMouseDown()
    {
        health -= 1;
    }
}