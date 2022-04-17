    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "carpma") //çarptığımız objenin tagı "carpma" ise
        {
            if (altinObje.activeSelf == true) //altinObje adlı GameObject nesnesi setActifliği True ya eşit ise
            {
                altinObje.SetActive(false);  //altinObje nesnesinin aktifliğini false yap.
                Invoke("Ekle", 2.0f);       //ardından Invoke fonksinonu 2 saniye sonra gerçekleştir. //Her çarpışma gerçekleştiğinde bu fonksiyon tetiklenecek.
            }
        }
        
    }

    void Ekle()
    {
        altinObje.SetActive(true);
    }
