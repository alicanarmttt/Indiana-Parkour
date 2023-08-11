using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    
    private float hiz = 5f;
    public OyunKontrol oyunK;
    public AudioClip altin, fall ,dusman, bitisMuzigi;
    public UnityEngine.UI.Text bitisText;
    public UnityEngine.UI.Button button;
    public KameraKontrol oyuncuObjesi;


    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunK.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;
            transform.Translate(x, 0f, y);
        }

    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("Cylinder"))
        {
            GetComponent<AudioSource>().PlayOneShot(altin, 1f);
            oyunK.AltýnArttýr();
            Destroy(c.gameObject);
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {
            oyunK.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(dusman, 1f);
            button.gameObject.SetActive(true);
            
         

        }
        else if (c.gameObject.tag.Equals("plane"))
        {

            oyunK.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);

        }
        else if (c.gameObject.tag.Equals("finish"))
        {
            oyunK.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(bitisMuzigi, 1f);
            bitisText.text = "Well Done!";

        }
    }
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("plane"))
        {
            oyunK.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);
            button.gameObject.SetActive(true);
        }

        if (c.gameObject.CompareTag("dusman"))
        {
            oyunK.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(dusman, 1f);
        }
        
    }
    
}
