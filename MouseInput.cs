using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    /*Quando pensamos em posi��o do mouse ou do touch, existem
     dois tipos de posi��es:
    1 - Posi��o na tela (f�sica): � limitada pelo tamanho e resolu��o
    do dispositivo.
    2 - Posi��o no mundo do jogo (virtual): � a posi��o dentro do
    mundo do jogo e s� � limitada pela capacidade num�rica do Unity.
    */

    //No caso de posi��o de intera��o com a tela,
    //toda posi��o � 2D
    //Input.mousePosition retorna a posi��o do ponteiro do mouse
    //no plano da TELA (sentido f�sico).
    //Vector2 position = Input.mousePosition;

    /*Haveram situa��es em que ser� necess�rio usar a posi��o
    lida direto da tela do dispositivo. E haver� outras 
    situa��es em que ser� necess�rio converter a posi��o
    do mouse para o mundo do jogo.*/

    /*Geralmente, em 2D, � poss�vel pegar com alta precis�o
    a posi��o do mouse convertida. Nesse caso utilizamos
    o m�todo ScreenToWorldPoint, que converte uma posi��o
    de tela para uma posi��o no mundo jogo.*/
    /*
    Vector3 worldPosition =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector3 touchWorldPosition =
        Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
    */

    /*No 3D, geralmente a profundidade impede uma convers�o
    direta da posi��o. Assim, � comum que se converta a posi��o
    da tela em um RAIO. Nesse caos, utilizamos o m�todo
    ScreenPointToRay, que far� essa convers�o. E com esse raio
    podemos dispara-lo em cena, e verficar com quem ele colide.*/
    /*
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    Ray rayTouch = 
        Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
    */

    void Update()
    {
        //RayExample();

    }

    //2D
    void WorldPointExample()
    {
        //Uma posi��o no mundo do jogo sempre � uma posi��o 3D
        //mesmo em um projeto 2D. Apenas o Z funciona como 'camada'.
        Vector3 worldPosition =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Criando um c�rculo centrado na mesma posi��o convertida
        //do mouse, e simulando que o ponteiro do mouse possui
        //tamanho 1.
        Collider2D col = Physics2D.OverlapCircle(worldPosition, 1f);
        if(col != null)
        {
            GameObject obj = col.gameObject;
            Renderer rend = obj.GetComponent<Renderer>();

            Color c = new Color();
            c.r = Random.Range(0f, 1f);
            c.g = Random.Range(0f, 1f);
            c.b = Random.Range(0f, 1f);

            rend.material.color = c;
        }
    }

    //3D
    void RayExample()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(mouseRay.origin, mouseRay.direction * 50f, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(mouseRay, out hit, 50f))
        {
            GameObject obj = hit.collider.gameObject;
            Renderer rend = obj.GetComponent<Renderer>();

            Color c = new Color();
            c.r = Random.Range(0f, 1f);
            c.g = Random.Range(0f, 1f);
            c.b = Random.Range(0f, 1f);

            rend.material.color = c;
        }
    }
}
