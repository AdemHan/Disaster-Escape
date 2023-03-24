using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenerator : MonoBehaviour
{
    public GameObject zemin;
    private Transform tr;
    public int zeminSayisi;
    public float zeminGenislik;
    public float minimumY, maksimumY;

    void Start()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 spawnKonumu = new Vector3();
        Vector2 yeniScale = new Vector2();

        for (int i = 0; i < zeminSayisi; i++)
        {
            yeniScale.x = Random.Range(0.9f, 1.1f); //zeminin genisligini belirledigimiz degerler arasinda random deger almasini sagliyoruz
            yeniScale.y = Random.Range(0.9f, 1.1f); //zeminin yuksekliginin belirledigimiz degerler arasinda random deger almasini sagliyoruz
            tr.localScale = yeniScale; //random ürettigimiz degerleri yeni olusturdugumuz zeminin scaleine esitledik

            spawnKonumu.y += Random.Range(minimumY, maksimumY); //var olan yukseklık degerinin uzerine parametrelede belirttigimiz deger kadar ekleme yapıyoruz. spawn olan zemin bu yükseklikte olusmus oluyor.
            spawnKonumu.x = Random.Range(-zeminGenislik, zeminGenislik); // random olusturacagimiz zemin saga ve sola ekleme yapmadan tekrar belirttigimiz aralıkta random deger alacak. Eger toplarsak Merve'nin yaptıgı gibi sahneden cikar :)

            Instantiate(zemin, spawnKonumu, Quaternion.identity); //belirttigimiz nesnenin, belirttigimiz konuma, aynı kalmasını istedigimiz rotasyon ile olusmasini cagirdik

        }
    }
}
