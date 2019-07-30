using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour
{
   
    public GameObject kirmizi;
    public GameObject mavi;
    public GameObject arkaplan1;
    public GameObject arkaplan2;
    

    int x1 = -8;
    int x2 = 0;
    int x3 = 8;
    int sayac = 1;
    
    public int can = 3;
    public int skor = 0;
    float zaman = 0;
    float arkaplanuzunluk = 0;

    Rigidbody2D f1;
    Rigidbody2D f2;
    Rigidbody2D fizik1;
    Rigidbody2D fizik2;
    
    void Start()
    {
      

    }


   

    void FixedUpdate()
    {
        kutuolustur();
        

    }

     void kutuolustur()
    {
        if (sayac == 1)
        {
            int sayi = Random.Range(0, 3);


            if (sayi == 0)
            {
                Instantiate(mavi, new Vector2(x1, 4), Quaternion.identity);
                Instantiate(kirmizi, new Vector2(x2, 4), Quaternion.identity);
                Instantiate(kirmizi, new Vector2(x3, 4), Quaternion.identity);

            }
            else if (sayi == 1)
            {
                Instantiate(mavi, new Vector2(x2, 4), Quaternion.identity);
                Instantiate(kirmizi, new Vector2(x1, 4), Quaternion.identity);
                Instantiate(kirmizi, new Vector2(x3, 4), Quaternion.identity);

            }
            else if (sayi == 2)
            {
                Instantiate(mavi, new Vector2(x3, 4), Quaternion.identity);
                Instantiate(kirmizi, new Vector2(x2, 4), Quaternion.identity);
                Instantiate(kirmizi, new Vector2(x1, 4), Quaternion.identity);

            }


        }
        sayac = 0;
        zaman += Time.deltaTime;
        if (zaman >= 3)
        {
            sayac = 1;
            zaman = 0;
        }
    }


   
}
