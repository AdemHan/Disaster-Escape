using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{
    public Text skor;
    public static float skorSayisi;  //scriptler arasi kullanmak icin static koymak gerekiyor


    void Update()
    {
        skor.text = skorSayisi.ToString();
    }
}
