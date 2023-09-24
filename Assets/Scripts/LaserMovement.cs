using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    float speed = 5f;

    Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void InitializeMovement()
    {
        direction = Random.insideUnitCircle.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
        if(!IsInCameraView())
        {
            Destroy(gameObject);
        }
         
    }
    bool IsInCameraView()
    {
        return true;
    }
}
