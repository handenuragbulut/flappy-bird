using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boru : MonoBehaviour
{
    // -8.9f sil 6.9f ekle x pozisyonu
    // y degeri -7.8f ve -15.2f

	yonetici yonet;

    void Start()
    {
        float rast = Random.Range(-15.2f, -7.8f);

        transform.position = new Vector3 (6.9f, rast, transform.position.z);

        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }

    void Update()
    {
        if(transform.position.x <= -8.3f)
        {
        	yonet.skor_arttir(1);

        	Destroy(gameObject);
        }

        transform.Translate(-3.2f * Time.deltaTime, 0, 0);
    }
}
