using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcAttributes : MonoBehaviour {

    ///-----
    [Tooltip("Puntos de Vida")]
    public int maxHp = 3;
    [Tooltip("Velocidade de Deslocamento")]
    public float speed;

    //
    public int hp;

    //
    void Awake()
    {
        hp = maxHp;    
    }
}
