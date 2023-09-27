using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField]
    private float minInterval = 0.01f;
    [SerializeField]
    private float maxInterval = 0.05f;

    bool shooting = false;
    float nextShootTime = 0f;
    float timer = 0f;

    float runningTime = 1.5f;

    [SerializeField]
    private GameObject laserBeamPrefab;

    [SerializeField]
    private float spawnDistance;


    // Start is called before the first frame update
    void Start()
    {
        StartShooting();
    }
    // Update is called once per frame
    void Update()
    {
        if (shooting)
        {
            timer += Time.deltaTime;

            if (Time.time >= nextShootTime)
            {
                LaserShoot();
                SetNextShootTime();
            }
        }

    }
    void SetNextShootTime()
    {
        nextShootTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    public void LaserShoot()
    {
        if (shooting)
        {
            Vector3 spawnPosition = transform.position + transform.up * spawnDistance;

            GameObject laserBeam = Instantiate(laserBeamPrefab, spawnPosition, Quaternion.identity);
            LaserMovement laserMovement = laserBeam.GetComponent<LaserMovement>();
            laserMovement.InitializeMovement(transform.rotation);
        }
        else
        {
            StopShooting();
        }
    }
    public void StartShooting()
    {
        shooting = true;
    }
    public void StopShooting()
    {
        shooting = false;
    }
}
