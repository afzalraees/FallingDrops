using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DropColor
{
    pink,blue
}
public class Boundary : MonoBehaviour
{
    public DropColor color;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "pinkDrop")
        {
            if(color == DropColor.pink)
            {
                GameManager.instance.AddScore();
                Destroy(collision.gameObject);
            }
            else
                GameManager.instance.uiManager.GameOver();
            
        }
        if(collision.tag == "blueDrop")
        {
            if(color == DropColor.blue)
            {
                GameManager.instance.AddScore();
                Destroy(collision.gameObject);
            }
            else
                GameManager.instance.uiManager.GameOver();
            
        }
    }
}
