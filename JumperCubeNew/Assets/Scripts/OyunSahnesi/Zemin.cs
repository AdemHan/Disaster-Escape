using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float zıplamaKuvveti;
    public bool zemineTemasEdildi;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    //Sert temas oldugu durumlarda oncollison enter kullanilir. İcinden gecme durumlarinda on trigger enter kullanilir.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0) //çarpan nesnenin kinetik enerjisi 0 dan küçükse
        { 
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>(); //rb degerini temas ettiğimizin rigidbodysine esitledik.

            if (rb != null)
            {
                Vector2 zıplamaVelocity = rb.velocity;
                zıplamaVelocity.y = zıplamaKuvveti;
                rb.velocity = zıplamaVelocity;

                if (zemineTemasEdildi == false)  //zemine temas edilince
                {
                    Yonetici.skorSayisi++;      //skor sayisi bir artar
                    zemineTemasEdildi = true;   //Ayni zeminde birden kez ziplarsa puan almasin diye true yapildi
                }

                anim.SetBool("TemasEdildi", true);
                Destroy(gameObject, 1f);
            }
        }
    }
}
