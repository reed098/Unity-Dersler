using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patterns2 : MonoBehaviour
{
    // Property patterns - Özellik desenleri

    string MulkTipi;
    string BlokTipi;
    //int AidatCarpanKatsayisi = 2;
    int BenimKatsayim = 2;
    void Start()
    {
        //alttaki iff else ve switch case ile aynı işlevi görür.
        int AidatHesapla(patterns2 classimbenim, int AidatCarpanKatsayisi)
            => classimbenim switch
            {
                { MulkTipi: "Daire", BlokTipi: "A" } => AidatCarpanKatsayisi * 1,
                { MulkTipi: "Villa", BlokTipi: "B" } => AidatCarpanKatsayisi * 2,
                { MulkTipi: "Rezidans", BlokTipi: "C" } => AidatCarpanKatsayisi * 3,
                _ => 0 //if else deki else gibi kullanılır.

            };

        MulkTipi = "Daire";
        BlokTipi = "A";
        Debug.Log(AidatHesapla(this, BenimKatsayim));
----------------------------------------------------------------------------------------------------------------


        /*
                if (MulkTipi == "Daire")
                    Debug.Log(AidatCarpanKatsayisi * 1.5);
                else if (MulkTipi == "Villa")
                    Debug.Log(AidatCarpanKatsayisi * 2.5);
                else if (MulkTipi == "Rezidans")
                    Debug.Log(AidatCarpanKatsayisi * 3.5);
                else
                    Debug.Log("Tanımsız");
        */
------------------------------------------------------------------------------------------------------------------		
        /*
                switch (MulkTipi)
                {

                    case "Daire":
                        Debug.Log(AidatCarpanKatsayisi * 1.5);
                        break;
                    case "Villa":
                        Debug.Log(AidatCarpanKatsayisi * 2.5);
                        break;
                    case "Rezidans":
                        Debug.Log(AidatCarpanKatsayisi * 3.5);
                        break;
                    default:
                        Debug.Log("Tanımsız");
                        break;

                }
        */


    }


}
