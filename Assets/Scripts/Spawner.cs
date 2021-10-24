using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 0.5f;

    public GameObject spawnObject;

    private float nextTimeToSpawn = 0f;

    private void Update()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(spawnObject, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }

}
