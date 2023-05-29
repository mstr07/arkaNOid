using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoruszanieKladki : MonoBehaviour
{
    private float szybkoscKladki = 6f;
    private float granicaPrawo = 2.72f;
    private float granicaLewo = -2.72f;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.koniecGry)
        {
            return;
        }
        float h;
        h = Input.GetAxis("Horizontal") * szybkoscKladki * Time.deltaTime;

        transform.Translate(Vector2.right * h);
        if(transform.position.x < granicaLewo)
        {
            transform.position = new Vector2(granicaLewo, transform.position.y);
        }
        if (transform.position.x > granicaPrawo)
        {
            transform.position = new Vector2(granicaPrawo, transform.position.y);
        }
    }
}
