using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    /* Trabalhlar com Touch � sempre feito
     dentro do Update, porque estamos verificando
     os comandos do jogador.
    */
    void Update()
    {
        //Input.touchCount � a propridade
        //que guarda o numero de toques
        //sendo registrados no momento
        
        //Verifica se existe de 1 a 3 toques
        //ao mesmo tempo
        /*if (Input.touchCount > 0 &&
            Input.touchCounter <= 3)
        {
        }*/

        if(Input.touchCount > 0)
        {
            /* Input.GetTouch() retorna
            um objeto da classe Touch
            a partir de seu �ndice*/
            //GetTouch(0) retorna o primeiro
            //toque sendo registrado
            Touch firstTouch = 
                Input.GetTouch(0);

            //a classe Touch � a classe
            //que abstrai o que � um toque
            //Na pr�tica, ela armazena
            //as informa��es de um toque
            print(firstTouch.position);

            //deltaPosition � a propriedade
            //que guarda a varia��o da posi��o
            //do toque a partir do frame anterior
            print(firstTouch.deltaPosition);

            //H� tamb�m as fases de um toque
            //Began	A finger touched the screen.
            //Moved A finger moved on the screen.
            //Stationary A finger is touching the screen but hasn't moved.
            //Ended A finger was lifted from the screen. This is the final phase of a touch.
            //Canceled The system cancelled tracking for the touch.
            print(firstTouch.phase);
        }
    }
}
