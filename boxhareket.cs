using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boxhareket : MonoBehaviour
{
    Rigidbody2D fizik;
  public  float harekethizi = 50;
    public Text cantxt;
    public Text skortxt; 
    public int skor = 0;
    public int can = 3;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        hareket();
        skortxt.text = skor.ToString();
        cantxt.text = can.ToString();
    }

    void hareket()
    {
        if(Input.GetKeyDown(KeyCode.A))
            {
            fizik.velocity = new Vector2(0, 0);
            fizik.AddForce(Vector2.left * harekethizi);
            }

        if (Input.GetKeyDown(KeyCode.D))
        {
            fizik.velocity = new Vector2(0, 0);
            fizik.AddForce(Vector2.right * harekethizi);
        }
    }
    private void OnTriggerEnter2D(Collider2D nesne)
    {
        if(nesne.gameObject.tag == "kirmizi")
        {
            Destroy(nesne.gameObject);
            can--;
            if(can<= 0)
            {
                SceneManager.LoadScene("lvl1");
            }

        }
        if(nesne.gameObject.tag == "mavi")
        {
            Destroy(nesne.gameObject);
            skor++;
        }
    }
}
