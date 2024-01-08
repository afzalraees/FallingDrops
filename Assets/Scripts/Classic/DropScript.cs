using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropScript : MonoBehaviour
{
    public Canvas canvas;

    private void Start()
    {
        canvas.worldCamera = Camera.main;
    }
    private void Update()
    {
        
    }

    public void Tap()
    {
        GameManager.instance.AddScore();
        ClassicGamemanager.instance.dropManager.SpawnDrop();
        Destroy(gameObject);
    }
}
