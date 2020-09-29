using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    public GameObject log;
    public Transform[] spawnpoints;

    public float minDelay=.5f;
    public float maxDelay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnLogs());        
    }

    IEnumerator SpawnLogs()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnindex = Random.Range(0, spawnpoints.Length);
            Transform spawnpoint = spawnpoints[spawnindex];

            Instantiate(log, spawnpoint.position, spawnpoint.rotation);

        }
    }
}
