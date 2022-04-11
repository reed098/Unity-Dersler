using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakipClamp : MonoBehaviour
{
   //Bu script kameranın içine atılacaktır.
   //Bu script ile kamera, player nesnemizi sabit olarak x yönünde takip edecek.Eğer playerimiz y yönünde hareket ederse kamera onu takip etmeyecek.
   
    public GameObject target; //takip edilecek nesne
    float _kameraMesafesi; //kameranın nesneye olan uzaklığını tanımlamak için yazdığımız değişken
    float _yClamp; //y yönünde kameranın hareket etmemesi için yazdığımız değişken.
    
    void Start()
    {
        _kameraMesafesi = transform.position.x - target.transform.position.x;
        // kameranın x ini hedef in x pozisyonundan çıkarıyoruz ve ikisinin arasındaki mesafeyi buluyoruz.

        _yClamp = Mathf.Clamp(target.transform.position.y,0,0);
        //Kameranın y yönünde bizi takip etmemesi için y yönüne clamp yapıyoruz.
        //Sadece x yönünde takip etmesini istediğimiz için yaptık.
    }


    void Update()
    {

        transform.position = new Vector3(target.transform.position.x + _kameraMesafesi, _yClamp, transform.position.z);
        //hedefin x pozisyonunuyla oyun başladığında bulduğumuz mesafeyi topluyoruz ve kameranın bizi hep bu mesafeden takip etmesini sağladık.
        //y yönüne mathf.clamp yaptığımız _yClamp değişkenini yazıyoruz
        //z yönünü olduğu gibi bırak diyoruz.

    }
}
