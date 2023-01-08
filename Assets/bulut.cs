using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulut : MonoBehaviour
{
    //-8.3'da başa al 8.3f
    //10  yukarı 0 aşağı yükseklik
    //
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x <= -8.3f)
        {
        	float y_degeri = Random.Range(0.0f, 5.8f);

        	transform.position = new Vector3(8.3f, y_degeri, transform.position.z);
        }

        transform.Translate(-3.2f * Time.deltaTime, 0, 0);
    }
}
