using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public int score = 0;
    public float speed = 5.0f;
    public GameObject door;
    public GameObject winText; // Tambahkan GameObject untuk menampilkan pesan kemenangan.

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false); // Sembunyikan pesan kemenangan saat awal permainan.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Keys")
        {
            score++;
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(collision.gameObject.tag == "Walls")
        {
            Debug.Log("Wall Hit");
        }

        if(collision.gameObject.tag == "Door")
        {
            if (score >= 3)
            {
                Destroy(collision.gameObject);
                WinGame(); // Panggil metode untuk menang saat pintu dihancurkan.
            }
        }
    }

    // Tambahkan metode untuk menang.
    void WinGame()
    {
        winText.SetActive(true); // Tampilkan pesan kemenangan.
        // Di sini Anda dapat memuat layar kemenangan atau melakukan tindakan kemenangan lainnya.
    }
}

