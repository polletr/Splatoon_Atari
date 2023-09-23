using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField]
    private float minInterval = 3f;
    [SerializeField]
    private float maxInterval = 10f;

    float runningTime = 1.5f;
    private float timerRange;
    float speed = 5f;

    [SerializeField]
    private GameObject laserBeamPrefab;


    // Start is called before the first frame update
    void Start()
    {
        timerRange = Random.Range(minInterval, maxInterval);
        LaserShoot();
    }

    public void LaserShoot()
    {
        Instantiate(laserBeamPrefab, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
