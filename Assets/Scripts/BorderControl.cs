using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag.Contains("drop"))
        {
            GameManager.instance.uiManager.GameOver();

        }
        if (collision.transform.tag.Contains("pinkDrop"))
        {
            GameManager.instance.uiManager.GameOver();

        }
        if (collision.transform.tag.Contains("blueDrop"))
        {
            GameManager.instance.uiManager.GameOver();

        }
    }
}
