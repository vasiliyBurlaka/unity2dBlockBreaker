using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16;
    [SerializeField] float minX = 1;
    [SerializeField] float maxX = 15;

    // cached references
    GameSession gameSession;
    Ball ball;

    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddlePos = new Vector2(GetXPos(), transform.position.y);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        float Xpos = 0;
        if (gameSession.IsAutoplayEnabled()) 
        {
            Xpos = ball.transform.position.x;
        } else {
            Xpos = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }

        return Mathf.Clamp(Xpos, minX, maxX);
    } 
}
