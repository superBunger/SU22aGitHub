using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boll : MonoBehaviour
{
    public float speed = 10.0f;
    Vector3 dir;
    TextMeshProUGUI scoreText;

    int player1goal = 0;
    int player2goal = 0;

    private void ResetBall()
    {
        scoreText.text = player1goal + " - " + player2goal;
        transform.position = new Vector3(0, 0, 0);
        int x = Random.Range(0, 2);
        speed = 10.0f;
        if (x == 0)
        {
            x = -1;
        }
        dir = new Vector3(x, Random.Range(-1, 2), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            dir.x = -dir.x;
            if(speed < 20 && collision.gameObject.tag == "Player")
            {
                speed += 0.5f;
            }
        }
        else
        {
            dir.y = -dir.y;
        }
    }

    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
        ResetBall();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
        transform.position += dir * speed * Time.deltaTime;
        if(transform.position.x > 10)
        {
            player1goal += 1;
            ResetBall();
            print("player 1 scored");
        }
        else if(transform.position.x < -10)
        {
            player2goal += 1;
            ResetBall();
            print("player 2 scored");
            
        }
    }
}
