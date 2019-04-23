using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliceAutoFloat : MonoBehaviour
{

    public AnimationCurve moving;
    public Vector3 maxPosition;
    public float duration;
    private Vector3 originalPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        StartCoroutine(autoFloat());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator autoFloat()
    {
        float timer = 0f;
        while (timer<duration)
        {
            timer++;
            transform.position =
                Vector3.LerpUnclamped(originalPosition, maxPosition, moving.Evaluate(timer / duration));
            yield return 0;
        }
        StartCoroutine(autoFloat());
    }
}
