using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok : MonoBehaviour
{

    Rigidbody rigi;
    BoxCollider box;
    yonetici yonet;
    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }


    // Update is called once per frame
    void Update()
    {

        RaycastHit temas;
        if(Physics.Raycast(transform.position,transform.forward,out temas,3.0f))
        {

            string isim = temas.collider.gameObject.name;
            if(isim == "sari")
            {
                yonet.puan_arttir(12);
            }
            else if (isim == "kirmizi")
            {
                yonet.puan_arttir(10);
            }

            else if (isim == "mavi")
            {
                yonet.puan_arttir(8);
            }

            else if (isim == "siyah")
            {
                yonet.puan_arttir(6);
            }

            sil();

        }

        transform.LookAt(transform.position + GetComponent<Rigidbody>().velocity);

    }

    void sil ()
    {
        Destroy(rigi);
        Destroy(box);
        Destroy(this);
    }
}
