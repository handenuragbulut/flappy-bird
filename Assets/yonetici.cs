using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yonetici : MonoBehaviour
{
    public GameObject boru;

    int skor = 0;
    public Text skor_txt;

    void Start()
    {
        InvokeRepeating("boru_ekle", 0.0f, 3.0f);

        skor_txt.text = skor.ToString();
    }

    void boru_ekle()
    {
        GameObject yeni_boru = Instantiate(boru);
    }

    public void skor_arttir(int deger) 
    {
    	skor += deger;
    	skor_txt.text = skor.ToString();
    }
}
