using UnityEngine;
using System.Collections;

public class Brick: MonoBehaviour {

    void OnCollisionExit2D(Collision2D other) {
        Destroy(gameObject);
    }
}
