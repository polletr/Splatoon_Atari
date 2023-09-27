using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectableSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject paintBucketPrefab;

    [SerializeField]
    private Color pOneColor;

    [SerializeField]
    private Color pTwoColor;

    private float minX = -0.675f;

    private float maxX = 0.675f;

    private float minY = -0.305f;

    private float maxY = 0.305f;

    [SerializeField]
    private float timeToSpawn;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject paintBucketPOne = Instantiate(paintBucketPrefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
        paintBucketPOne.GetComponent<SpriteRenderer>().color = pOneColor;

        GameObject paintBucketPTwo = Instantiate(paintBucketPrefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
        paintBucketPTwo.GetComponent<SpriteRenderer>().color = pTwoColor;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToSpawn)
        {
            GameObject paintBucketPOne = Instantiate(paintBucketPrefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
            paintBucketPOne.GetComponent<SpriteRenderer>().color = pOneColor;

            GameObject paintBucketPTwo = Instantiate(paintBucketPrefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
            paintBucketPTwo.GetComponent<SpriteRenderer>().color = pTwoColor;

            timer = 0;
        }
    }
}
