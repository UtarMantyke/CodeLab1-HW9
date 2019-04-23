using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliceCameraMove : MonoBehaviour
{
    public AnimationCurve moving;
    public Vector3 maxPosition;
    public float duration;
    private Vector3 originalPosition;
    
    private Vector3 originalPosition2;
    public Vector3 maxPosition2;
    
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
//        if (getBack == ture)
//        {
//            
//        }
    }

    IEnumerator myCameraMoveIn()
    {
        float timer = 0f;
        while (timer<duration)
        {
            timer++;
            transform.position =
                Vector3.LerpUnclamped(originalPosition, maxPosition, moving.Evaluate(timer / duration));
            yield return 0;
        }
    }
    
    IEnumerator myCameraMoveBack()
         {
             float timer = 0f;
             while (timer<duration)
             {
                 timer++;
                 transform.position =
                     Vector3.LerpUnclamped(maxPosition, originalPosition, moving.Evaluate(timer / duration));
                 yield return 0;
             }
         }
    
    IEnumerator backToMenu()
    {
        float timer = 0f;
        while (timer<duration)
        {
            timer++;
            transform.position =
                Vector3.LerpUnclamped(originalPosition2, maxPosition2, moving.Evaluate(timer / duration));
            yield return 0;
        }
    }

    public void startAnimation()
    {
        StartCoroutine(myCameraMoveIn());
    }
    
    public void backAnimation()
    {
        StartCoroutine(myCameraMoveBack());
    }

    public void backAnimationUp()
    {
        originalPosition2 = transform.position;
        StartCoroutine(backToMenu());
    }
}
