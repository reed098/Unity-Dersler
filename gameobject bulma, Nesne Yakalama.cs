private Gameobject nesne;


void Start()
{
  nesne = Gameobject.Find("silindir");
  //Objeyi ismiyle bulduk
  
  nesne = Gameobject.tag("silindirtag");
  //Objeyi tagıyla bulduk
  
  Gameobject.Find("obje")GetComponent<MeshRenderer>().enabled = false;
  //Objeyi ismiyle bulduk ve ardından get componetine erişip işlem yaptık.
  
  Scriptim = Object.FindObjectOfType<sScriptNesnesi>();
  //Scripti böyle bulabiliriz.
  
  _altinObj = GameObject.FindGameObjectWithTag("carpma");
  //objeyi tagıyla bulduk ve değikene atadık.
  
  rb = GameObject.Find("kursun").GetComponent<Rigidbody2D>();
  //objenin içindeki rigidbodysine eriştik ve atadık.
  
}
