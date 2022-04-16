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
        //float xClamp = Mathf.Clamp(transform.position.x,0,0); //Kamerann nesneyi x yönünde takip etmemesini isterseniz burayı ve targetpos.x = xClamp kodunu açın.
        Vector3 targetpos = target.transform.position + mesafe; //Kameranın her zaman bu mesafeden takip etmesini söyledik.
        //targetpos.x = xClamp; //Nesnemizi her zaman takip etmesi için yazdığımız kod olan targetpos.x e xClamp ı atıyoruz.
        transform.position = Vector3.Lerp(transform.position,targetpos,6f * Time.deltaTime);
            //vector.lerp ile yumuşak geçiş sağladık ve target objesi durduğunda veya hizlandığında yumuşak olarak takip edecek.

        
    }
}
