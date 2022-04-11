
 //Klavyemizin veya faremizin input girişlerini Unity arayüzünden Edit-->Project Setting-->Input Manager kısmından bulabiliriz.
 
 float sagsol = Input.GetAxis("Horizontal") * Time.deltatime * hiz; //klavyemizin sağ ve sol tuşlarını "sagsol" değişkenine atadık ve hız verip zamanla çarptık.
 float yukari = Input.GetAxis("Vertical") * Time.deltatime * hiz; //klavyemizin yukarı ve aşağı tuşlarını "yukari" değişkenine atadık ve hız verip zamanla çarptık.
	
 transfrom.Translate(sagsol,0,yukari); //translate kodunu kullanarak parametre olarak oyuncumuza x, y ve z yönlerine atadığımız değikenleri yazdık.
	
*******************************************************************************************************************************************************
//faremizin hareketlerinin x yönünü ve y yönünü değişkenlere atıyoruz ve bu değişkenleri playerimizi hareket ettirmek için kullanıyoruz.	
	float farex = Input.GetAxis("Mouse X") * Time.deltatime * hiz;
	float farey = Input.GetAxis("Mouse Y") * Time.deltatime * hiz;
	
	transfrom.Translate(farex, 0 , farey);
*********************************************************************************************************************************************************
if (Input.GetMouseButtonDown(0)) //if koşulumuza faremizin sol tuşuna basarsak aşağıdaki işlemleri yap dedik.
        {

        }
if (Input.GetKeyDown(KeyCode.Space)) //klavyemizin boşluk tuşuna basarsak aşağıdaki işlemleri yap.
        {

        }
if (Input.GetButtonDown("Jump")) //Klavyeden boşluk tuşuna basarsak demiş olduk. Jump nereden geliyor diyorsanız yine Input Manager içine göz atabilirsiniz.
        {

        }
	
Input.GetTouch(1); //telefon ekranına dokunmamızı verir.
