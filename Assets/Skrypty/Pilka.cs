using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilka : MonoBehaviour
{
    public Rigidbody2D pilka;
    public float predkoscPilki = 300f;
    public bool czyPilkaWGrze;
    public Transform kladka;
    public Transform ceglaWybuch;
    public GameManager gm;
    AudioSource audio;
    public AudioSource audioSpadania;

    // Start is called before the first frame update
    void Start()
    {
        pilka = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.koniecGry)
        {
            return;
        }
        if (!czyPilkaWGrze)
        {
            transform.position = kladka.position;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !czyPilkaWGrze){
            czyPilkaWGrze = true;
            pilka.AddForce(Vector2.up * predkoscPilki);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "ScianaDol")
        {
            //Debug.Log("spadlo");
            audioSpadania.Play();
            pilka.velocity = Vector2.zero;
            czyPilkaWGrze = false;
            gm.UpdateZycia(-1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.Play();
        if (collision.gameObject.tag == "cegla")
        {
            //Debug.Log("cegla");
            if (collision.gameObject.GetComponent<Cegla>().hpCegly > 1)
            {
                collision.gameObject.GetComponent<Cegla>().RozbijCegle();
            }
            else 
            {
                Transform newceglaWybuch = Instantiate(ceglaWybuch, collision.transform.position, collision.transform.rotation);
                Destroy(newceglaWybuch.gameObject, 2f);
                Destroy(collision.gameObject);
                gm.UpdatePunkty(collision.gameObject.GetComponent<Cegla>().punktyZaCegle);
                gm.UpdateCegly();
            }
        }
    }
}
