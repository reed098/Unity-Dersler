//Plane oluşturuyoruz. Plane nin içine box collider atıyoruz.
//box collideri ikinci plane nesnesinin ortasına gelecek şekilde ayarlıyoruz. Toplam 3 adet plane nesnesi olacak(bunu değiştirebiliriz)
//bu scripti plane nesnesinin içine atıyotız.
//Plane objesini kopyalıyoruz yukarıda dediğim gibi 3 adet yapıyoruz yol gibi birbirine ekliyoruz.

int _planeNesneSayisi = 3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "oyuncu")
        {
            transform.position += new Vector3(0, 0, GetComponent<Renderer>().bounds.size.z * _planeNesneSayisi); 
        }
    }
