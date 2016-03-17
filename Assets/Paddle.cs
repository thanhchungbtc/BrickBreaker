using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    public float speed = 100.0f;
    private Rigidbody2D myBody;    

    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float h = Input.GetAxisRaw("Horizontal");
        myBody.velocity = Vector2.right * h * speed;
    }
}
