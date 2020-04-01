using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody2D rgbody;
    public Vector2 jumpForce = new Vector2(0, 200);
    int score;
    public static bool isGameOver = false;
    private static bool hasPlayed = false;

    public Text scoreText;
    public GameObject gameOverText;
    public GameObject playagain;
    public GameObject quitGame;
    

    // Use this for initialization

    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
        SoundManager.playSound("voice");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SoundManager.playSound("jump");
            rgbody.velocity = Vector2.zero;
            rgbody.AddForce(jumpForce);
            
        }
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height)
        {
            Die();
        }

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        score++;
        scoreText.text = "Score: " + score;
    }


    void Die()
    {
        SoundManager.playSound("gameover");
        Time.timeScale = 0.0f;
        isGameOver = true;
        gameOverText.SetActive(true);
        playagain.SetActive(true);
        quitGame.SetActive(true);

    }

   
}
