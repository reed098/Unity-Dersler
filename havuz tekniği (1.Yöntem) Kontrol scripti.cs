using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Havuz tekniği 1. yöntemin 1. scriptidir.
//Havuz tekniği kontrol scripti Bu script kontrol nesnesine veya player nesnesine atılabilir.
//Buradaki kodlar orta seviyedir.
//Bu teknik ile durmadan nesneleri klonyayıp destroy etmek yerine ilk başta oluşturulan nesneler durmadan kullanılır.

public class Oyun : MonoBehaviour
{

    public GameObject mermi; //Bu havuz tekniğinde kullanacağımız nesnedir.
    List <GameObject> nesne;  //nesne adında GameObject türünde list oluşturuyoruz. Bu havuz tekniğinde kullanacağımız nesnedir.
    
    public float nesneZamani;

    void Start()
    {
        nesne = new List<GameObject>();

        for (int i = 0; i < 10; i++) //havuz tekniğinde kullanılacak nesne adedini for döngüsüyle belirliyoruz.
        {
            nesne.Add(Instantiate(mermi)); //10 adet mermi klonladık ve bu klonları nesne listimizin içine attık.
            nesne[i].SetActive(false); //klonlanan nesnelerin görünürlüğünü false konumuna getirdik.
        }
        
        InvokeRepeating("ekle", 0, nesneZamani); //bu Invoke fonksiyonu ile oyun açıldığında nesneZamani kadar klonlanan nesnenin konumları true olacak.
    }


    void Update()
    {
        
    }

    void ekle()
    {
        foreach (GameObject n in nesne)
        {
            if (n.activeSelf == false)
            {
                n.SetActive(true);
                float Xdeger = Random.Range(-4.5f, 4.5f);
                float Zdeger = Random.Range(-4.5f, 4.5f);
                n.transform.position = new Vector3(Xdeger, 5, Zdeger);
                return;
            }
        }
    }


}
