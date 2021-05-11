using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticlesManager : MonoBehaviour
{

    public GameObject obsticlePrefab;
    public float spawnDelay = 3;
    float currentTime;

    public Vector2 min_max_random_pos;

    public Transform spawnPosition;

    void Start()
    {
        currentTime = spawnDelay;
    }

    void Update()
    {
        if(currentTime <= 0)
        {
            currentTime = spawnDelay;
            SpawnObsticle();
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    void SpawnObsticle()
    {
        GameObject obsticle;
        obsticle = Instantiate(obsticlePrefab, spawnPosition.position + (Vector3.up * Random.Range(min_max_random_pos.x, min_max_random_pos.y)), spawnPosition.rotation);
        Destroy(obsticle, 10);
    }
}
