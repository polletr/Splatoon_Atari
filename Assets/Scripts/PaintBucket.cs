using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBucket : MonoBehaviour
{

    [SerializeField]
    private Color color;

    private float timer;

    [SerializeField]
    private float flashLimit;

    [SerializeField]
    private float destroyLimit;

    private bool blinking;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > flashLimit && !blinking)
        {
            StartCoroutine(Blink());

        }


    }

    private IEnumerator Blink()
    {
        blinking = true;
        Renderer objRend = GetComponent<Renderer>();
        while (timer < destroyLimit)
        {
            objRend.enabled = !objRend.enabled;
            yield return new WaitForSeconds(0.3f);
        }

        Destroy(gameObject);
    }
}
