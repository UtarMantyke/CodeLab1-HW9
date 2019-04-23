using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AliceRotate : MonoBehaviour
{
    public AnimationCurve floating;
    public Vector3 maxAngle;
    public float duration;
    private Vector3 originalAngle;

    // Start is called before the first frame update
    void Start()
    {
        originalAngle = transform.localEulerAngles;
        StartCoroutine(myAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator myAnimation()
    {
        float timer = 0f;

        while (timer < duration)
        {
            timer++;
            /*Vector3 originalAngleInVector3 = new Vector3(0, 0, originalAngle);
            Vector3 maxAngleInVector3 = new Vector3(0, 0, maxAngle);*/
            transform.localEulerAngles = Vector3.LerpUnclamped(originalAngle, maxAngle, floating.Evaluate(timer/duration));
            yield return 0;

        }
        StartCoroutine(myAnimation());
    }
}
