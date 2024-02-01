using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Movment_Script : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject endGameText;
    private Vector2 movement;
    private Rigidbody rb;
    private TextMeshProUGUI TextComponent;
    public int speed = 1;
    int score;
    bool gameRunning;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        gameRunning = true;
        {
            TextComponent = scoreText.GetComponent<TextMeshProUGUI>();
            TextComponent.text = "Hi";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 5)
        {
            EndGame();
        }
    }

    void OnMove(InputValue moveval)
    {
        if (gameRunning)
        {
            movement = moveval.Get<Vector2>();
            float movex = movement.x;
            float movey = movement.y;
            Vector3 movement3 = new Vector3(movex, 0.0f, movey);
            rb.AddForce(movement3 * speed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"));
        {
            score += 1;
            TextComponent.text = score.ToString();
            other.gameObject.SetActive(false);
        }
    }

    void EndGame()
    {
        endGameText.SetActive(true);
        gameRunning = false;
    }
}
