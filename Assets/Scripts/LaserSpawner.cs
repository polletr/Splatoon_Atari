using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    Vector3[] laserTrapPositions = new Vector3[4];

    [SerializeField]
    private GameObject laserTrapPrefab;

    private List<LaserTrap> laserTraps = new List<LaserTrap>(); // List for kept the LaserTraps

    // Start is called before the first frame update
    void Start()
    {
        laserTrapPositions[0] = new Vector3(0.1875f, 0.225f, 0f);
        laserTrapPositions[1] = new Vector3(-0.1875f, -0.225f, 0f);
        laserTrapPositions[2] = new Vector3(0.1875f, -0.225f, 0f);
        laserTrapPositions[3] = new Vector3(-0.1875f, 0.225f, 0f);

        for (int i = 0; i < laserTrapPositions.Length; i++)
        {
            GameObject instantiateLaserTrap = Instantiate(laserTrapPrefab, laserTrapPositions[i], Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
