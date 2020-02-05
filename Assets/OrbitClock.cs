using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitClock : MonoBehaviour
{
    //tutorial: https://www.youtube.com/watch?v=3PHc6vEckvc
    public GameObject centerObject; // the object our target will be orbiting around
    public float speed; //the rotation speed

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        OrbitAround();
    }

    void OrbitAround()
    {
        this.transform.RotateAround(centerObject.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
