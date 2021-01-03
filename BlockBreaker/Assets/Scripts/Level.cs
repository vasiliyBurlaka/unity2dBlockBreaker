using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    SceneLoader sceneLoader;

    private int breakableBlocksCount;

    void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void AddBlock()
    {
        breakableBlocksCount++;
    }

    public void RemoveBlock()
    {
        breakableBlocksCount--;
        if (breakableBlocksCount <= 0) {
            sceneLoader.LoadNextScene();
        }
    }
}
