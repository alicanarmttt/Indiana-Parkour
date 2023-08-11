using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{

    public GameObject baslangic;
    public bool oyunAktif;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinSayisiText;
    public UnityEngine.UI.Button button;
    public Vector3 baslangic_konum;
    public OyuncuKontrol oyuncu;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AltýnArttýr()
    {
        altinSayisi += 1;
        altinSayisiText.text = "" + altinSayisi;
        if (altinSayisi == 3)
        {
            altinSayisiText.text = "Okey: " + altinSayisi;
        }
    }
    public void OyunBaslatma()
    {
        baslangic_konum = baslangic.transform.position;
        oyuncu.transform.position = baslangic_konum;
        oyunAktif = true;
        button.gameObject.SetActive(false);
        
    }
}

    




