using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    float speed = 2f;

    float northLimit = 0.45f;
    float southLimit = -0.45f;
    float eastLimit = 0.75f;
    float westLimit = -0.75f;

    float laserXPosition = 0f;
    float laserYPosition = 0f;

    Vector3 direction;

    LaserTrap laserTrap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InitializeMovement(Quaternion trapRotation)
    {
        //direction = Random.insideUnitCircle.normalized;
        direction = trapRotation * Vector3.up;

        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = targetRotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        laserXPosition = transform.position.x;
        laserYPosition = transform.position.y;
        if (laserXPosition >= eastLimit || laserXPosition <= westLimit || laserYPosition >= northLimit || laserYPosition <= southLimit)
        {
            Destroy(gameObject);
        }
         
    }
    bool IsInCameraView()
    {
        return true;
    }
}
