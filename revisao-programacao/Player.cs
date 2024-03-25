using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    //Usado para fazer personagens não-beseados
    //em eventos físicos (ex. reação automatica a colisões)
    CharacterController controller;
    Vector3 velocity;//velocidade vetorial
    Vector3 direction;
    float speed = 7.5f;//rapidez

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<>() retorna um componente do GameObject
        //que contém o script que o roda
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        /*  GetAxis() retorna valores entre 1 e -1 a partir
         do eixo passado por parâmetro.
            GetAxis("Horizontal") retorna 1 enquanto a tecla
         A estiver pressionada, retorna -1 enquanto a tecla D 
         estiver pressionadac e retorna 0 quando ambas 
         estiverem soltas.
        */

        //Algoritmo de movimento
        //1 - ler os comandos de movimento do jogador
        float x = Input.GetAxis("Horizontal");
        //W pressionado retorna 1; S pressionado retorna -1
        //Ambas soltas, retorna 0;
        float z = Input.GetAxis("Vertical");

        //2 - construir a direção com os comandos
        direction = new Vector3(x, 0, z);

        //3 - construir velocidade vetorial
        velocity = direction.normalized * speed * Time.deltaTime;

        //4 - mover objeto
        controller.Move(velocity);
    }
}
