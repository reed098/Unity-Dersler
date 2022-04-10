
        //Quaternion.Euler //bir nesneyi istediğimiz derecede döndürmeyi sağlar.
        transform.rotation = Quaternion.Euler(0, 90, 0); // Nesneyi y ekseninde 90 derece döndürdük.
        //quaternion.euler local da farklı olarak nesneyi döndürebilir. eğer farklılık oluyorsa globale çevir.
--------------------------------------------------------------------------------------------------------
        //Quaternion.identity //olduğu gibi bırak demek. Değerleri değiştirme, nasıl kayıt edilmişse öyle kullan demek.
        transform.rotation = Quaternion.identity;
---------------------------------------------------------------------------------------------------------
        //Quaternion.Inverse //rotationu ters çevirir
        transform.rotation = Quaternion.Inverse(Quaternion.Euler(0, 90, 0)); //yazılan değerleri tersine çevirir yani -90 olarak çevirecek.
------------------------------------------------------------------------------------------------------------------------------------
        //Quaternion.Lerp // iki deðer arasýnda 
        t = Mathf.PingPong(0.2f * Time.time, 1f);//0.2f hızında nesne y ekseninde 90 ile -90 arasında durmadan dönecek.
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 90, 0), Quaternion.Euler(0, -90, 0), t);//t değeri 0 ile 1 arasında değer alır.
        //slerp e göre daha hızlıdır.Ancak rotasyonlar birbirinden çok uzaktaysa kötü görünür.
--------------------------------------------------------------------------------------------------------------------------------------
        //Quaternion.slerp

        t = Mathf.PingPong(Time.time* 0.2f, 1); //mathf.pingpong ile nesne 0.2f hızında y ekseninde 45 ile 90 derece arsında gidip gelecek.
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(0,45,0), Quaternion.Euler(0,90,0), t);//t değeri 0 ile 1 arasýnda değer alır.
-------------------------------------------------------------------------------------------------------
        //Quaternion.LookRotation

        //LookAt kodu gibi

        Vector3 direction = target.position - transform.position; //aradaki mesafeyi belirledik.

        transform.rotation = Quaternion.LookRotation(direction); //target nereye giderse nesnemizin z yönü oraya dönecek.

        //transform.rotation = Quaternion.LookRotation(target.position - transform.position); //veya böyle de kullanılabilir.

--------------------------------------------------------------------------------------------------------
        //Quaternion.RotateTowards

        transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, t);
        //target nesnemiz nereye dönerse bizim nesnemiz de o yöne t değerindeki hız kadar hızlı dönecek.

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(90,0,0),t);
        //böyle de kullanılabilir. istediğimiz yöne tek seferlik x yönüne 90 derece dönecektir.

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Inverse(Quaternion.Euler(90,0,0)),t);
        //üstteki kodun tam tersidir. Üstteki kod tek seferlik olguğu için başlangıç yönüne döndürmek için bunu kullanabiliriz.
----------------------------------------------------------------------------------------------------------
        //Quaternion.FromToRotation

        transform.rotation = Quaternion.FromToRotation(transform.up, transform.right);
        //bu kod nesnenin eksenlerini istenilen yönde çeviriyor.
--------------------------------------------------------------------------------------------------------------
        //Quaternion.Angel //iki değer arasındaki rotation farkını verir bize
        float angle = Quaternion.Angle(transform.rotation, target.rotation);
--------------------------------------------------------------------------------------------------------------
        //Quaternion.AngelAxis //vector3 türünde nesneyi belli bir yönde döndürür.
        transform.rotation =  Quaternion.AngleAxis(45f, transform.up);// y ekseninde nesneyi 45 derece döndürmesini söyledik.
