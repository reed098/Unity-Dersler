using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{

    public Transform target;

    float t = 0.2f;
    
    void Start()
    {

    }


    void Update()
    {
        t = Mathf.PingPong(0.2f * Time.time,1f);

        transform.rotation = Quaternion.Slerp(Quaternion.Euler(0,90,0), Quaternion.Euler(0,-90,0), t);



    }


}
