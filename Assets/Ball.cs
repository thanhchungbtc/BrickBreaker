using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float speed = 200.0f;

    private Rigidbody2D myBody;


    float getXPositionRelative(float paddleXPosition, float paddleWidth) {
        float xPositionOfBall = transform.position.x;
        return (xPositionOfBall - paddleXPosition) / paddleWidth;  
    }

    void Awake() {
        myBody = GetComponent<Rigidbody2D>();        
    }

    void Start() {
        myBody.velocity = Vector2.up * speed;
    }

    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        // get relative x position of ball on paddle
        if (other.collider.name == "paddle") {
            var paddleXPosition = other.collider.transform.position.x;
            var paddleWidth = other.gameObject.GetComponent<BoxCollider2D>().size.x;
            float xFactor = getXPositionRelative(paddleXPosition, paddleWidth);
            myBody.velocity = new Vector2(xFactor, 1).normalized * speed;
        }        
    }
}

