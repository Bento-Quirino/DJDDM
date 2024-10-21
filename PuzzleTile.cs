using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTile : MonoBehaviour
{
    public bool mouseReleased;

    void OnTriggerStay2D(Collider2D incoming)
    {
        //Quando a peça entra em colisão com o tile do 
        //tabuleiro, o "snap-to-grip" é ativado
        //quando o jogador soltar o botão
        //(parar de segurar a peça)
        if(mouseReleased)
        {
            print("sdfsdf");
            incoming.transform.position = transform.position;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mouseReleased = true;
            print("asd");
        }
        //else { mouseReleased = false; }
    }
}
