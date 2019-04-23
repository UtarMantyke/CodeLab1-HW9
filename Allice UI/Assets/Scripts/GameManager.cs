using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject lamp;
    public GameObject mirror;
    public GameObject teapot;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("lampGenerator",1,3);
        InvokeRepeating("mirrorGenerator",1,4);
        InvokeRepeating("teapotGenerator",1,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void lampGenerator()
    {
        GameObject newLamp = Instantiate(lamp);
        newLamp.transform.position = new Vector3(Random.Range(-8,8),-8,2);
    }
    
    void mirrorGenerator()
    {
        GameObject newMirror = Instantiate(mirror);
        newMirror.transform.position = new Vector3(Random.Range(-8,8),-8,2);
    }
    
    void teapotGenerator()
    {
        GameObject newTeapot = Instantiate(teapot);
        newTeapot.transform.position = new Vector3(Random.Range(-8,8),-8,2);
    }
}
