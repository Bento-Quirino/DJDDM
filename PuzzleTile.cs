using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleTile : MonoBehaviour
{
    public bool mouseReleased;

    void OnTriggerStay2D(Collider2D incoming)
    {
        //Quando a pe�a entra em colis�o com o tile do 
        //tabuleiro, o "snap-to-grip" � ativado
        //quando o jogador soltar o bot�o
        //(parar de segurar a pe�a)
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
