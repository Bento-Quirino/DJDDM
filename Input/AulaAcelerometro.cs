using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaAcelerometro : MonoBehaviour
{
    // Acelerometro no Unity � um tipo de 
    //comando do jogador
    void Update()
    {
        //  Input.acceleration retorna o valor 
        //de acelera��o lido a partir da rota��o
        //do celular.
        //  O valor sempre � um Vector3, pois consiste
        //nas rota��es em cada eixo
        //https://docs.unity3d.com/ScriptReference/Input-acceleration.html
        // Portanto, para acessar cada rota��o,
        //utilizamos os componentes vetoriais:
        //      Input.acceleration.x
        //      Input.acceleration.y
        //      Input.acceleration.z

        Vector2 direction;
        //a acelera��o vai de -1.0 a 1.0
        //assim, se o celular estiver parado numa mesa,
        //sua acelera��o ser� 0.0, porque n�o existe rota��o
        //do celular nessa posi��o.
        direction.x = Input.acceleration.x;
        direction.y = Input.acceleration.y;

        if (direction.magnitude >= 1)
        { direction.Normalize(); }
        
        float speed = 10f;
        Vector2 velocity = direction.normalized *
                            speed * Time.deltaTime;
        transform.Translate(velocity);
    }
}
