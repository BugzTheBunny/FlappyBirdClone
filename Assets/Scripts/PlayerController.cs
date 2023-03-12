using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField] float jumpVelocity = 9.0f;
    [SerializeField] LogicManager logic;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        Flap();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !logic.isGameOver) {
            Flap();
        }
    }

    void Flap() {
        rb.velocity = Vector2.up * jumpVelocity;            
    }

    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
    }

}
