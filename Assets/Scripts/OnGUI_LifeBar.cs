using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUI_LifeBar : MonoBehaviour {

    NpcAttributes attributes;

    void Start()
    {
        attributes = GetComponent<NpcAttributes>();
    }

    private void OnGUI()
    {
        //Guarda a posição do inimigo no mundo para projeta a barra
        Vector2 pos = Camera.main.WorldToScreenPoint(transform.position);

        GUI.Box(new Rect(
            pos.x - 20,                                                     //posição x da barra
            Screen.height - pos.y + 60,                                     //posição y da barra
            40,                                                             //achura de la barra
            24                                                              //altura da barra
            ), attributes.hp + "/" + attributes.maxHp                       //texto na barra
            );
    }
}
