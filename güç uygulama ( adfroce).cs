public Rigidbody myrigid ;
float guc = 100.0f;


void Update{
	
	
	
	if(Input.GetMouseButton(0) & myrigid.gameobject.tag =="cikis")  //farenin sol tuşuna basılıyorsa ve basılan nesnenin tagı "cikis" ise...
	{
		
		myrigid.AddForce(transform.forward * guc); //Objenin z ekseninde güç uygulanacak.
		
	}		
	
	
	
}
