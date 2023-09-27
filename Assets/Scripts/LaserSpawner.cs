using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>();

    [SerializeField]
    private List<Vector3> spawnRotations = new List<Vector3>();

    [SerializeField]
    private GameObject laserTrapPrefab;

    private float spawnInterval = 8f;
    private float timer = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0f)
        {
            SpawnLaserTrap();

            timer = spawnInterval;
        }
    }

    void SpawnLaserTrap()
    {
        if (spawnPoints.Count > 0)
        {
            int randomIndex = Random.Range(0, spawnPoints.Count);
            Transform spawnPoint = spawnPoints[randomIndex];

            Vector3 spawnRotation = spawnRotations[randomIndex];

            Quaternion rotation = Quaternion.Euler(spawnRotation);

            GameObject laserTrap = Instantiate(laserTrapPrefab, spawnPoint.position, rotation);

            Destroy(laserTrap, 8f);
        }
    }
}
