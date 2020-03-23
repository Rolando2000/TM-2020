using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag"))
        {
            GameObject.Find("gameManagerObj").GetComponent<Manager>().Player1Scored();
        }
    }
}