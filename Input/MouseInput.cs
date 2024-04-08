using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    /*Quando pensamos em posição do mouse ou do touch, existem
     dois tipos de posições:
    1 - Posição na tela (física): é limitada pelo tamanho e resolução
    do dispositivo.
    2 - Posição no mundo do jogo (virtual): é a posição dentro do
    mundo do jogo e só é limitada pela capacidade numérica do Unity.
    */

    //No caso de posição de interação com a tela,
    //toda posição é 2D
    //Input.mousePosition retorna a posição do ponteiro do mouse
    //no plano da TELA (sentido físico).
    //Vector2 position = Input.mousePosition;

    /*Haveram situações em que será necessário usar a posição
    lida direto da tela do dispositivo. E haverá outras 
    situações em que será necessário converter a posição
    do mouse para o mundo do jogo.*/

    /*Geralmente, em 2D, é possível pegar com alta precisão
    a posição do mouse convertida. Nesse caso utilizamos
    o método ScreenToWorldPoint, que converte uma posição
    de tela para uma posição no mundo jogo.*/
    /*
    Vector3 worldPosition =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector3 touchWorldPosition =
        Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
    */

    /*No 3D, geralmente a profundidade impede uma conversão
    direta da posição. Assim, é comum que se converta a posição
    da tela em um RAIO. Nesse caos, utilizamos o método
    ScreenPointToRay, que fará essa conversão. E com esse raio
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
        //Uma posição no mundo do jogo sempre é uma posição 3D
        //mesmo em um projeto 2D. Apenas o Z funciona como 'camada'.
        Vector3 worldPosition =
            Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Criando um círculo centrado na mesma posição convertida
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
