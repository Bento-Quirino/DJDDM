using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AulaAcelerometro : MonoBehaviour
{
    // Acelerometro no Unity é um tipo de 
    //comando do jogador
    void Update()
    {
        //  Input.acceleration retorna o valor 
        //de aceleração lido a partir da rotação
        //do celular.
        //  O valor sempre é um Vector3, pois consiste
        //nas rotações em cada eixo
        //https://docs.unity3d.com/ScriptReference/Input-acceleration.html
        // Portanto, para acessar cada rotação,
        //utilizamos os componentes vetoriais:
        //      Input.acceleration.x
        //      Input.acceleration.y
        //      Input.acceleration.z

        Vector2 direction;
        //a aceleração vai de -1.0 a 1.0
        //assim, se o celular estiver parado numa mesa,
        //sua aceleração será 0.0, porque não existe rotação
        //do celular nessa posição.
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
