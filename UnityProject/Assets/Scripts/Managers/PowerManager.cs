using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public GameObject[] powers;

    void Start()
    {
        Invoke("SpawnPower", 5);
    }

    private void SpawnPower()
    {
        int randomPower = Random.Range(0, 3);
        Vector3 randLoc = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));
        Instantiate(powers[randomPower], randLoc, Quaternion.identity);
        Invoke("SpawnPower", 5);
    }

}
