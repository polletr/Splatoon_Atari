using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField]
    private float minInterval = 1f;
    [SerializeField]
    private float maxInterval = 3f;

    bool shooting = false;
    float nextShootTime = 0f;
    float timer = 0f;

    float runningTime = 1.5f;

    [SerializeField]
    private GameObject laserBeamPrefab;


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
            GameObject laserBeam = Instantiate(laserBeamPrefab, transform.position, Quaternion.identity);
            LaserMovement laserMovement = laserBeam.GetComponent<LaserMovement>();
            laserMovement.InitializeMovement();
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
