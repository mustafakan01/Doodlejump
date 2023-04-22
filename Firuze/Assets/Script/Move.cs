using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D rb;
    private float hareketinput;
    public TextMeshProUGUI skoryazi;
    private int skor;

    // Update is called once per frame
    void Update()
    {
        skoryazi.text = "Skor:" + skor;
        hareketinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hiz*hareketinput,rb.velocity.y);

    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (temas.gameObject.tag=="Platform")
        {
            skor++;
        }
    }
}
