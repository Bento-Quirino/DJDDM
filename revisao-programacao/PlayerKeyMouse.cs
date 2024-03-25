using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyMouse : MonoBehaviour
{
    float angularSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        /*Detecter botão do mouse:
         * Input.GetMouseButton() retorna verdadeiro
         * se o código do botão passado como parâmetro
         * foi pressionado.
         */

        //Se o botão esquerdo (código 0) estiver pressionado
        //o objeto gira para a esquerda
        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0, -angularSpeed, 0);
        }

        //Se o botão direito (código 1) estiver pressionado
        //o objeto gira para a esquerda
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, angularSpeed, 0);
        }

        /*Detecter se teclas foram pressionadas:
         * Input.GetKey() retorna verdadeiro equanto a tecla
         * passada por parametro estiver pressionada
         */
        //Podemos fazer a mesma rotação usando "Q" e "E"
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -angularSpeed, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, angularSpeed, 0);
        }

        /* Cada uma delas possuem duas variações
         * Down e Up.
         * GetKeyDown e GetMouseButtonDown retornam verdadeiro
         * uma vez quando o jogador pressiona a tecla.
         * GetKeyUp e GetMouseButtonUp retornam verdadeiro
         * uma vez quando o jogador solta a tecla
         */
    }
}
