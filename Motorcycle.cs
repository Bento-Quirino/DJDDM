using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motorcycle : MonoBehaviour
{
    float sides; //velocidade para os lados
    
    float forward; // velocidade da moto para frente
    float force; // aceleração do jogador

    public float acceleration;
    public float friction;
    public float maxSpeed;

    void Update()
    {
        force = 0;
        if(Input.GetKey(KeyCode.W))
        { force += acceleration; }
        else if(Input.GetKey(KeyCode.S))
        { force -= acceleration; }

        forward += force * Time.deltaTime;
        forward = Mathf.Min(forward, maxSpeed);

        //se force for virtualmente zero
        if (Mathf.Abs(force) < 0.0001))
        {
            forward = Mathf.Lerp(forward, 0f, friction * Time.deltaTime);
        }

        // frenagem
        if(Input.GetKey(KeyCode.Space))
        {
            forward = Mathf.Lerp(forward, 0f, 3 * friction * Time.deltaTime);
        }

        transform.position += forward *
                                transform.forward * Time.deltaTime;
    }
}
