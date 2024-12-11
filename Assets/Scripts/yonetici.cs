using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{

    public GameObject ok;
    float firlatma_hizi = 4000.0f;
    float reset_firlatma_degeri = 4000.0f;

    public Image atishizibari;

    Transform kamera;

    int puan = 0;
    public Text puantxt;

    int kalanok = 5;
    public Text kalanoktxt;

    int bolumgecmepuan = 30;

    public TMPro.TextMeshProUGUI sonuc;

    // Start is called before the first frame update
    void Start()
    {

        kamera = GameObject.Find("kamera").transform;

        kalanoktxt.text = kalanok.ToString();
    }

    public void puan_arttir(int deger)
    {
        puan += deger;
        puantxt.text = puan.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if(kalanok > 0)
            {
                GameObject yeni_ok = Instantiate(ok, kamera.position, kamera.transform.rotation);

                firlatma_hizi *= atishizibari.fillAmount;

                yeni_ok.GetComponent<Rigidbody>().AddForce(yeni_ok.transform.forward * firlatma_hizi);

                firlatma_hizi = reset_firlatma_degeri;

                

                oku_azalt();
            }

           
        }
    }

    void oku_azalt()
    {
        kalanok--;

        kalanoktxt.text = kalanok.ToString();

        if(kalanok == 0)
        {
            oyunu_bitir();

            if (puan >= bolumgecmepuan) 
            {
                sonuc.text = ("Kazandınız !");
            }
            else
            {
                sonuc.text = ("Kaybettiniz !");
            }
        }

    }
    void oyunu_bitir()
    {
        sonuc.gameObject.transform.parent.gameObject.SetActive(true);
    }
    public void tekrar_oyna()
    {
        SceneManager.LoadScene("Scenes/Level");
    }
}


