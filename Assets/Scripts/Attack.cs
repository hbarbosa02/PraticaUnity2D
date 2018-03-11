using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    [Tooltip("Define se esse ataque pertence a um inimigo ou ao jogador")]
    public bool isPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" && isPlayer) collision.SendMessage("Attacked");
        else if (collision.tag == "Player" && !isPlayer) collision.SendMessage("Attacked");
    }
}
