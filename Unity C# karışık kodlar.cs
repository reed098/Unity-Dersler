Sahne değiştirme 		      : SceneManager.LoadScene ( SceneManager.GetActiveScene().buildIndex);
Bir sonraki sahneye geçme             : SceneManager.LoadScene ( SceneManager.GetActiveScene().buildIndex + 1);
değilse ..... yap "if" metodu : if(ilkKod =! ikinciKod)  =!   işaretinin anlamı "değilse" demektir.
Invoke("fonksiyon_adı", 1.0f);    -------- Bir fonksiyonu belli bir saniye sonra 1 kez çalıştırabiliriz . Start Fonkisyonuna yazılır.
InvokeRepeating("fonksiyon_adı" , 1.0f, 5.0f);  Oyun başladıktan 1 saniye sonra başlıyor. 5 saniye aralıklarla devam ediyor.Start Fonkisyonuna yazılır.
************************************************************************************************************************************************************
---nesne yaratma---

float xpos,zpos;  //pozisyonları tanımladık.
public Gameobject nesne ; //yaratılacak nesneyi tanımladık.

xpos = Random.Range(-5.0f,5.0f);  //xpos değişkenine rastgele -5 ile 5 arasında bir sayı atadık.
zpos = Random.Range(-3.0f,3.0f);  //zpos değişkenine rastgele -3 ile 3 arasında bir sayı atadık.

Instantiate(nesne, new Vector3(xpos,3,zpos), Quaternion.identy); //Instantiate(yaratılacak nesne, pozisyon, açı);
*************************************************************************************************************************************************************
---Çarpışma Kontrolü---
private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "carp")
        {
            player_rigi.AddForce(Vector2.up * guc);
			Destroy(other.gameObject); //other.gameObject "carp" taglı nesne silinecek.
			Destroy(gameObject);       //sadece gameObject yazdığımız zaman scriptin bağlı olduğu nesne silinecek.
        }
    }
	
	
**************************************************************************************************************************************************************
---Coroutineler---
StartCoroutine(fonksiyon_coro());      //start fonksiyonunda çağırılır.

IEnumerator fonksiyon_coro()
{
	yield return new WaitForSeconds(1.0f);     //Bu kod timescale den etkilenir. Ancak WaitForSecondsRealTime kodu etkilenmez.
	Kodlar.......
}
**************************************************************************************************************************************************************
