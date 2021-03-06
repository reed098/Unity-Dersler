   List<GameObject> objeler;
    public GameObject dusman;
    bool seta;


 void Start()
     {
	objeler = new List<GameObject>();  //objeler adında yeni bir list çağırıyoruz.
        for (int i = 0; i < 15; i++)
        {
            objeler.Add(Instantiate(dusman)); //objeler listine dusman objesini spawnlayıp içine atıyoruz.
            objeler[i].SetActive(false); //spawnladıktan hemen sonra aktifliklerini false yapıyoruz.
            seta = false; //seta bool değişkenini false olarak tanımlıyoruz.
        }

   
       
     }




private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "carpma")
        {
            DusmanEkle(); //fonksiyonu çağırıyoruz.
        }
    }

    public void DusmanEkle()
    {
        for (int i = 0; i < objeler.Count; i++) 
        {
            if(seta == false)  //başta false olarak tanımlamıştık.
            {
                
		float Xdeger = Random.Range(-8.0f, 8.0f); //x yönünde rastgele pozisyon oluşturuyoruz.
                float Zdeger = Random.Range(-8.0f, 8.0f); //z yönünde tastgele pozsiyon oluşturuyoruz.
                objeler[i].SetActive(true); //spawnladığımız objeleri true ya çeviriyoruz.
                
                objeler[i].transform.position = new Vector3(Xdeger, 1, Zdeger); //objeler listinin içindeki spawnlanmış nesnelere pozisyon atıyoruz.
                //return; //return ü tanımlarsak sadece bir kere yapıp bu döngüden çıkacak.
            }
