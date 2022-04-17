   RaycastHit Nesne;
   
    void Start()
    {
        
    }

 
    void Update()
    {

        //Ray isik_yolla = GameObject.Find("Main Camera").GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
		//kameranın tam ortasından ışın gönderdik.

        Ray isik_yolla = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
		//mouse pozisyonunu ray değişkenine atadık.

        if(Physics.Raycast(isik_yolla, out Nesne)) 
        {
            if(Nesne.collider != null)  //ışık bir objeye çarptıysa, boş değilse demektir.
            {
                Debug.Log(Nesne.collider.name); //Işığın çarptığı objenin ismini konsola yazdırıyoruz.
            }
        }  
    }

