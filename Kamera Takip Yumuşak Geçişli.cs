using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    GameObject target;
    Vector3 mesafe; 
    void Start()
    {
        target = GameObject.Find("Oyuncu");
        mesafe = transform.position - target.transform.position; //Kameranın takip mesafesini buluyoruz.

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetpos = target.transform.position + mesafe; //Kameranın her zaman bu mesafeden takip etmesini söyledik.
        transform.position = Vector3.Lerp(transform.position,targetpos,6f * Time.deltaTime);
        //vector.lerp ile yumuşak geçiş sağladık ve target objesi durduğunda veya hizlandığında yumuşak olarak takip edecek.

        
    }
}
