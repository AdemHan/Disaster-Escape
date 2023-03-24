using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float hareketHizi;
    private float yatayHareket;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // rb degiskenine karakterin rigidbody'sini almasini sagliyoruz.
    }

    void Update()
    {
        yatayHareket = Input.GetAxis("Horizontal"); //yatay hareketin yon tuslarina basildiginda -1 0 ve 1 degerlerini almasini saglar.
        rb.velocity = new Vector2(yatayHareket * hareketHizi * Time.deltaTime, rb.velocity.y); // karakterin hizi burada ayarlaniyor

        Vector2 yeniScale = transform.localScale; // karakterin boyutunu tutcak yeniScale degiskeni olusturduk.

        /*
         Tus saga basma tusuysa 1 degerini alir ve 0 dan buyuk olmus olur.  karakter saga bakar
         Tus saga basma tusuysa -1 degerini alir ve 0 dan kucuk olmus olur.  karakter sola bakar   
         */
        if (yatayHareket > 0)
        {
            yeniScale.x = 0.7f;
        }

        if (yatayHareket < 0)
        {
            yeniScale.x = -0.7f;
        }

        transform.localScale = yeniScale;
    }
}
