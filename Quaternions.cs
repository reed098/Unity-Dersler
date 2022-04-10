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
        //Quaternion.Euler //bir nesneyi istedi�imiz derecede d�nd�rmeyi sa�l�yor.
        transform.rotation = Quaternion.Euler(0, 90, 0); // Nesneyi y ekseninde 90 derece d�nd�rd�k.
                                                 //quaternion.euler local da farkl� olarak nesneyi d�nd�rebilir. E�er farkl�l�k oluyorsa globale �evir.
        //-------------------------------------------------------------------------------------------------------
        //Quaternion.identity //oldu�u gibi b�rak demek. De�erleri de�i�tirme, nas�l kay�t edilmi�se �yle kullan demek.
        transform.rotation = Quaternion.identity;
        //--------------------------------------------------------------------------------------------------------
        //Quaternion.Inverse //rotationu ters �evirir
        transform.rotation = Quaternion.Inverse(Quaternion.Euler(0, 90, 0)); //yaz�lan de�erleri tersine �evirir yani -90 olarak �evirecek.
        //-----------------------------------------------------------------------------------------------------------------------------------
        //Quaternion.Lerp // �ki de�er aras�nda 
        t = Mathf.PingPong(0.2f * Time.time, 1f);//0.2f h�z�nda nesne y ekseninde 90 ile -90 aras�nda durmadan d�necek.
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 90, 0), Quaternion.Euler(0, -90, 0), t);//t de�eri 0 ile 1 aras�nda de�er al�r.
                                                                                                         //slerp e g�re daha h�zl�d�r.Ancak rotasyonlar birbirinden �ok uzaktaysa k�t� g�r�n�r.
        //-------------------------------------------------------------------------------------------------------------------------------------
        //Quaternion.slerp

        t = Mathf.PingPong(Time.time* 0.2f, 1); //mathf.pingpong ile nesne 0.2f h�z�nda y ekseninde 45 ile 90 derece aras�nda gidip gelecek.
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(0,45,0), Quaternion.Euler(0,90,0), t);//t de�eri 0 ile 1 aras�nda de�er al�r.
        //-------------------------------------------------------------------------------------------------------
        //Quaternion.LookRotation

        //LookAt kodu gibi

        Vector3 direction = target.position - transform.position; //aradaki mesafeyi belirledik.

        transform.rotation = Quaternion.LookRotation(direction); //target nereye giderse nesnemizin z y�n� oraya d�necek.

        //transform.rotation = Quaternion.LookRotation(target.position - transform.position); //veya b�yle de kullan�labilir.

        //-------------------------------------------------------------------------------------------------------
        //Quaternion.RotateTowards

        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, t);
        //target nesnemiz nereye d�nerse bizim nesnemiz de o y�ne t de�erindeki h�z kadar h�zl� d�necek.

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(90,0,0),t);
        //b�yle de kullan�labilir. istedi�imiz y�ne tek seferlik x y�n�ne 90 derece d�necektir.

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Inverse(Quaternion.Euler(90,0,0)),t);
        //�stteki kodun tam tersidir. �stteki kod tek seferlik oldu�u i�in ba�lang�� y�n�ne d�nd�rmek i�in bunu kullanabiliriz.
        //---------------------------------------------------------------------------------------------------------
        //Quaternion.FromToRotation

        transform.rotation = Quaternion.FromToRotation(transform.up, transform.right);
        //bu kod nesnenin eksenlerini istenilen y�nde �eviriyor.
        //-------------------------------------------------------------------------------------------------------------
        //Quaternion.Angel //�ki de�er aras�ndaki rotation fark�n� verir bize
        float angle = Quaternion.Angle(transform.rotation, target.rotation);
        //-------------------------------------------------------------------------------------------------------------
        //Quaternion.AngelAxis //vector3 t�r�nde nesneyi belli bir y�nde d�nd�r�r.
        transform.rotation =  Quaternion.AngleAxis(45f, transform.up);// y ekseninde nesneyi 45 derece d�nd�rmesini s�yledik.





}


}
