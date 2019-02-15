using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {

        // Check if the entering object is that Player, and if so, access the Game Manager and win the game.
        if (coll.CompareTag("Player"))
        {
             GameObject gm = GameObject.FindWithTag("GameController");
             gm.GetComponent<GameManager>().WinGame();
        }
    }
}
