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
        //Quaternion.Euler //bir nesneyi istediðimiz derecede döndürmeyi saðlýyor.
        transform.rotation = Quaternion.Euler(0, 90, 0); // Nesneyi y ekseninde 90 derece döndürdük.
                                                 //quaternion.euler local da farklý olarak nesneyi döndürebilir. Eðer farklýlýk oluyorsa globale çevir.
        //-------------------------------------------------------------------------------------------------------
        //Quaternion.identity //olduðu gibi býrak demek. Deðerleri deðiþtirme, nasýl kayýt edilmiþse öyle kullan demek.
        transform.rotation = Quaternion.identity;
        //--------------------------------------------------------------------------------------------------------
        //Quaternion.Inverse //rotationu ters çevirir
        transform.rotation = Quaternion.Inverse(Quaternion.Euler(0, 90, 0)); //yazýlan deðerleri tersine çevirir yani -90 olarak çevirecek.
        //-----------------------------------------------------------------------------------------------------------------------------------
        //Quaternion.Lerp // Ýki deðer arasýnda 
        t = Mathf.PingPong(0.2f * Time.time, 1f);//0.2f hýzýnda nesne y ekseninde 90 ile -90 arasýnda durmadan dönecek.
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 90, 0), Quaternion.Euler(0, -90, 0), t);//t deðeri 0 ile 1 arasýnda deðer alýr.
                                                                                                         //slerp e göre daha hýzlýdýr.Ancak rotasyonlar birbirinden çok uzaktaysa kötü görünür.
        //-------------------------------------------------------------------------------------------------------------------------------------
        //Quaternion.slerp

        t = Mathf.PingPong(Time.time* 0.2f, 1); //mathf.pingpong ile nesne 0.2f hýzýnda y ekseninde 45 ile 90 derece arasýnda gidip gelecek.
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(0,45,0), Quaternion.Euler(0,90,0), t);//t deðeri 0 ile 1 arasýnda deðer alýr.
        //-------------------------------------------------------------------------------------------------------
        //Quaternion.LookRotation

        //LookAt kodu gibi

        Vector3 direction = target.position - transform.position; //aradaki mesafeyi belirledik.

        transform.rotation = Quaternion.LookRotation(direction); //target nereye giderse nesnemizin z yönü oraya dönecek.

        //transform.rotation = Quaternion.LookRotation(target.position - transform.position); //veya böyle de kullanýlabilir.

        //-------------------------------------------------------------------------------------------------------
        //Quaternion.RotateTowards

        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, t);
        //target nesnemiz nereye dönerse bizim nesnemiz de o yöne t deðerindeki hýz kadar hýzlý dönecek.

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(90,0,0),t);
        //böyle de kullanýlabilir. istediðimiz yöne tek seferlik x yönüne 90 derece dönecektir.

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Inverse(Quaternion.Euler(90,0,0)),t);
        //üstteki kodun tam tersidir. Üstteki kod tek seferlik olduðu için baþlangýç yönüne döndürmek için bunu kullanabiliriz.
        //---------------------------------------------------------------------------------------------------------
        //Quaternion.FromToRotation

        transform.rotation = Quaternion.FromToRotation(transform.up, transform.right);
        //bu kod nesnenin eksenlerini istenilen yönde çeviriyor.
        //-------------------------------------------------------------------------------------------------------------
        //Quaternion.Angel //Ýki deðer arasýndaki rotation farkýný verir bize
        float angle = Quaternion.Angle(transform.rotation, target.rotation);
        //-------------------------------------------------------------------------------------------------------------
        //Quaternion.AngelAxis //vector3 türünde nesneyi belli bir yönde döndürür.
        transform.rotation =  Quaternion.AngleAxis(45f, transform.up);// y ekseninde nesneyi 45 derece döndürmesini söyledik.





}


}
