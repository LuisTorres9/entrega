using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsMove : MonoBehaviour
{
    public float speed; // se define la la velosidad con la cual se movera el personaje 
    public string gusto;

    void Start()
    {
        speed = Random.Range(0.1f, 2);
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.S)) //si se preciona la tecla s 
        {
            transform.position -= transform.forward * speed; //el GameObject se mueve hacia atras 
        }

        if (Input.GetKey(KeyCode.W)) //si se preciona la tecla w 
        {
            transform.position += transform.forward * speed; //el GameObject se mueve hacia delante  
        }

        if (Input.GetKey(KeyCode.D)) //si se preciona la tecla d 
        {
            transform.position += transform.right * speed;//el GameObject se mueve hacia derecha 
        }
        if (Input.GetKey(KeyCode.A)) //si se preciona la tecla a 
        {
            transform.position -= transform.right * speed; //el GameObject se mueve hacia izquierda 
        }
    }
    

}
