using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16;
    [SerializeField] float minX = 1;
    [SerializeField] float maxX = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePointsInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        float clampedMouseUnit = Mathf.Clamp(mousePointsInUnits, minX, maxX);
        Vector2 paddlePos = new Vector2(clampedMouseUnit, transform.position.y);
        transform.position = paddlePos;
    }
}
