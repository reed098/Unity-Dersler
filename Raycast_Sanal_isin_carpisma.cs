using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    RaycastHit dusman1;
    void Start()
    {

    }


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.right, out dusman1, 2.0f))
        {
            //!null boş değilse demektir.Yani sanal ışın bir yere çarptıysa demektir.
            if (dusman1.collider != null)
            {
                //dusman1.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                dusman1.collider.gameObject.SetActive(false);
                //Destroy(dusman1.collider.gameObject);
                Debug.Log(dusman1.distance); 
            }
        }
        //Bu şekilde de kullanılabilir.
        if (Physics.Raycast(transform.position, new Vector3(1, 0, 0), out dusman1, 2.0f))
        {
            if (dusman1.collider.gameObject.tag == "dusman")
            {
                dusman1.collider.gameObject.SetActive(false);
                Debug.Log(dusman1.distance);
            }
        }
    }
}
