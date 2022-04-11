using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{

    float sayi;
    float sayi2;
    
    void Start()
    {
        
    }


    void Update()
    {

        sayi = Mathf.Abs(-10); //matematikteki mutlak değerdir. İçine yazılan kodu her zaman pozitif yapar. 

        Mathf.Clamp(sayi, 5f,10f); //bir değeri minimum ile maksimum arasında tutar. Kelepçeler.
        // Bu kod ile oyuncumuzun ekran içinde kalmasını sağlayabiliriz. Ekran dışına çıkmasını engelleyebiliriz.

        sayi = Mathf.Ceil(9.2f); //bir üst sayıya int olarak eşitler. Yani 9.2f olan sayi konsolda 10 olarak görünecek.

        sayi = Mathf.Floor(10.8f); //en düşük sayıya eşitler. Noktadan sonrasını saymaz. 10.8f konsolda 10 olarak görünecektir.

        sayi = Mathf.Max(10.5f,14f); //içindeki en büyük sayıyı alır. Yani konsolda 14f görünecektir.

        sayi = Mathf.Min(5.2f, 7.8f); //mathf.max ın tam tersidir. İçindeki en küçük sayıyı verir. Yani konsolda 5.2f görünecektir.

        sayi = Mathf.Round(10.4f);// En yakın tam sayıya yuvarlar. Konsolda 10 görünecektir. Ancak 10.6 olsaydı konsolda 11 yazacaktı.

        sayi = Mathf.Sqrt(16); //yazılan sayının karekökünü verir.

        sayi = Mathf.PingPong(Time.time,5); //2 sayi veya değer arasında durmadan gidip gelir. 
        //time.time dan başlayıp yani 0 dan 5 e kadar gidecek ve 5 olduğunda tekrar 0 a doğru inecek devamlı.

        sayi = Mathf.Lerp(2f,7f,0.7f*Time.deltaTime); //2 değer arasında yumuşatmayı sağlar. Bu komutla çok yumuşak geçişler yapılabilir.



    }
}
