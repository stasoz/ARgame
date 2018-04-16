using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject[] spawns;
    public static bool exit;
    public GameObject[] OurObject;

    private void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(Spawn2());
    }
    
    IEnumerator Spawn()
    {
        while(!exit)
        {
            int currValueObj = Random.Range(0, 3);
            int currValueSpawn = Random.Range(0, 5);
            Instantiate(OurObject[currValueObj], spawns[currValueSpawn].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator Spawn2()
    {
        while (!exit)
        {
            int currValueObj = Random.Range(0, 3);
            int currValueSpawn = Random.Range(5, 9);
            Instantiate(OurObject[currValueObj], spawns[currValueSpawn].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(4f);
        }
    }
}
