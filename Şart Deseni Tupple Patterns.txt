using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deneme : MonoBehaviour
{

    string deger1 = "makas";
    string deger2 = "tas";
	
	//if else veya switch case yerine bu deseni kullanabiliriz.
 
    
    void Start()
    {
	
			
		//alttaki if else ve switch case şartlarının aynısı çok şart varsa bu desene kullanmak daha mantıklı
        string taskagitmakas(string bir, string iki) => (bir, iki) switch
        {
            ("tas", "kagit") => "Kağıt Kazandı",
            ("tas", "makas") => "Taş Kazandı",
            ("tas", "tas") => "Berabere",
            ("kağıt", "makas") => "Makas Kazandı",
            ("kağıt", "kağıt") => "Berabere",
            ("makas", "makas") => "Berabere",
            (_, _) => "Değerler Boş" //değerler boş demek if deki else nin aynısı


        };
		
        Debug.Log(taskagitmakas("tas", "kagit"));
-------------------------------------------------------------------------------------------------------------------------------	
        #region
        /*
          if (deger1 == "tas" && deger2 == "kagit")
          {
              Debug.Log("Kağıt kazandı");

          }
          else if (deger1 == "tas" && deger2 == "makas")
          {
              Debug.Log("Taş kazandı");

          }
          else if (deger1 == "kagit" && deger2 == "tas")
          {
              Debug.Log("Kağıt kazandı");

          }
          else if (deger1 == "kagit" && deger2 == "makas")
          {
              Debug.Log("Makas kazandı");

          }
          else if (deger1 == "makas" && deger2 == "tas")
          {
              Debug.Log("Taş kazandı");

          }
          else if (deger1 == "makas" && deger2 == "kagit")
          {
              Debug.Log("Makas kazandı");

          }
          else
          {
              Debug.Log("Berabere");

          }
          */
        #endregion
-----------------------------------------------------------------------------------------------------------------------------
        #region
        /*
        
                switch (deger1)
                {
                    case "tas":
                        if (deger2 == "kagit")
                            Debug.Log("Kağıt kazandı");
                        if (deger2 == "makas")
                            Debug.Log("Taş kazandı");
                        break;

                    case "kagit":
                        if (deger2 == "tas")
                            Debug.Log("Kağıt kazandı");
                        if (deger2 == "makas")
                            Debug.Log("Makas kazandı");
                        break;

                    case "makas":
                        if (deger2 == "tas")
                            Debug.Log("Taş kazandı");
                        if (deger2 == "kagit")
                            Debug.Log("Makas kazandı");
                        break;

                    default:
                        Debug.Log("Berabere");
                        break;
                }        
        */
        #endregion
    }

   
}
