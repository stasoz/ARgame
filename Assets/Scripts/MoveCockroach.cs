using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCockroach : MonoBehaviour
{
    public GameObject OurPoint;
    public Transform OurStart;
    public float smooth;
    private void Update()
    {
        transform.position = Vector3.Lerp(OurStart.position, OurPoint.transform.position, smooth);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "banana")
        {
            Destroy(gameObject);
        }
    }
}
