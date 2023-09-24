using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField]
    private float minInterval = 5f;
    [SerializeField]
    private float maxInterval = 10f;

    int laserBeamCount = 0;
    bool shooting = false;
    float nextShootTime = 0f;
    float timer = 0f;

    float runningTime = 1.5f;
    float speed = 5f;

    [SerializeField]
    private GameObject laserBeamPrefab;


    // Start is called before the first frame update
    void Start()
    {
        StartShooting();
        StopShooting();
    }

    void SetNextShootTime()
    {
        nextShootTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    public void LaserShoot()
    {
        if (laserBeamCount < 2)
        {
        GameObject laserBeam = Instantiate(laserBeamPrefab, transform.position, Quaternion.identity);
        LaserMovement laserMovement = laserBeam.GetComponent<LaserMovement>();
        laserMovement.InitializeMovement();
        laserBeamCount++;
        }
        else
        {
            StopShooting();
        }
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
    public void StartShooting()
    {
        shooting = true;
    }
    public void StopShooting()
    {
        shooting = false;
    }
}
