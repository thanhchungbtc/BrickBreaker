using UnityEngine;
using System.Collections;

public class BrickArray : MonoBehaviour {
    int rows;
    int columns;

    float screenWidth;
    float screenHeight;

    float brickWidth;
    float brickHeight;
    public GameObject brickPrefab;
    GameObject[,] bricks;

    void InitializeBrickArray() {
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < columns; c++) {
                bricks[r, c] = (GameObject)Instantiate(brickPrefab,
                    new Vector3(
                        -screenWidth / 2 + c * (brickWidth + Constants.BRICK_MARGIN) + brickWidth / 2 + Constants.BRICK_MARGIN, 
                        screenHeight / 2 -  r * (brickHeight + Constants.BRICK_MARGIN) - brickHeight / 2 - Constants.BRICK_MARGIN, transform.position.z),
                    Quaternion.identity);
            }
        }
    }

    void InitializeVariables() {
        screenHeight = Camera.main.orthographicSize * 2f;
        screenWidth = screenHeight * Camera.main.aspect;
        brickWidth = Constants.BRICK_WIDTH;
        brickHeight = Constants.BRICK_HEIGHT;
        columns = (int)((screenWidth - Constants.BRICK_MARGIN) / (Constants.BRICK_WIDTH + Constants.BRICK_MARGIN));
        rows = 4;
        bricks = new GameObject[rows, columns];
    }

    void Start() {
        InitializeVariables();
        InitializeBrickArray();
    }
}
