   //Oyunlarda belirli bir nesneye hareket sınırı için kullanılan kod.
		float xposSinir = Mathf.Clamp(transform.position.x, -2.6f, 2.6f);
        float yposSinir = Mathf.Clamp(transform.position.y, -60.0f, 5.0f);
        transform.position = new Vector2(xposSinir, yposSinir);




//İkinci Kullanım Örneği
//-----------------------


        float yYonu = Input.GetAxis("Vertical");
        transform.Translate(ucakHizi * Time.deltaTime, yYonu * Time.deltaTime* ucakHizi,0);
	
	
	//player nesnemize hız verdikten sonra bunları yapıyoruz.(translate, addforce veya velocity)
        float yClamp = Mathf.Clamp(transform.position.y, -4.35f, 4.35f);
        transform.position = new Vector2(transform.position.x, yClamp);



//Nesne Rotation Clamp - quaternion clamp
//----------------
        _namluY += donusHizi * Input.GetAxis("Horizontal") * Time.deltaTime; //yatay input klavye tuşarını _namluY değişkenine ekledik.
        _namluX += donusHizi * Input.GetAxis("Vertical") * Time.deltaTime;  //dikey input klavye tuşlarını _namluX değişkenine ekledik.

        _namluX = Mathf.Clamp(_namluX,-45.0f,45.0f); //_namluX değikenini kelepçeledik.
        _namluY = Mathf.Clamp(_namluY, -45.0f, 45.0f); //_namluY değişkenini kelepçeledik.
        Namlu.transform.eulerAngles = new Vector3(_namluX, _namluY); //namlunun dönüşünün X ine _namluX değikenini Y sine de _namluY yi verdik.
