using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{

    void Start()
    {
        float Xdeger = Random.Range(-4.5f, 4.5f);
        float Zdeger = Random.Range(-4.5f, 4.5f);
        gameObject.transform.position = new Vector3(Xdeger, 1.0f, Zdeger);
    }


    void Update()
    {
        
    }

    private void OnEnable()
    {
        float Xdeger = Random.Range(-4.5f, 4.5f);
        float Zdeger = Random.Range(-4.5f, 4.5f);
        gameObject.transform.position = new Vector3(Xdeger, 1.0f, Zdeger);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "zemin")
        {
            //other.collider.gameObject.SetActive(false);
            Debug.Log("Çarptı");
            gameObject.SetActive(false);
        }
    }
}
