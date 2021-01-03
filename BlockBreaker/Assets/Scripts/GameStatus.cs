using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }
}
