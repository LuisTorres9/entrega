using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fps : MonoBehaviour
{
    float mouseX;  //se define la posicion en x
    float mouseY;   //se define  la posicion en y


    public float minAngle = -45.0f; //se define el rango maximo de rotacion en x
    public float maxAngle = 45.0f; //se define el rango maximo de rotacion en x

    public bool InvertedMouse; //variable tipo bool, si esta activa se invierte la rotacion en y

    public float a;

    void Update()
    {
        if (a == 1)
        {
            mouseX += Input.GetAxis("Mouse X"); //se almasena la posicion en x

            if (InvertedMouse) //si el bool InvertedMouse es falso 
            {
                mouseY += Input.GetAxis("Mouse Y"); //se almasena la posicion en y
                mouseY = Mathf.Clamp(mouseY, minAngle, maxAngle); // se limita la rotacion de la camara 

            }
            else //si el bool InvertedMouse es verdadero 
            {
                mouseY -= Input.GetAxis("Mouse Y"); //se almasena la posicion en x
                mouseY = Mathf.Clamp(mouseY, minAngle, maxAngle); // se limita la rotacion de la camara 
            }
            transform.eulerAngles = new Vector3(mouseY, mouseX, 0); // La rotación como ángulos de Euler en grados.
        }

        if (a == 2)
        {
            mouseX += Input.GetAxis("Mouse X"); //se almasena la posicion en x

            if (InvertedMouse) //si el bool InvertedMouse es falso 
            {
                mouseY += Input.GetAxis("Mouse Y"); //se almasena la posicion en y
                mouseY = Mathf.Clamp(mouseY, minAngle, maxAngle); // se limita la rotacion de la camara 

            }
            else //si el bool InvertedMouse es verdadero 
            {
                mouseY -= Input.GetAxis("Mouse Y"); //se almasena la posicion en x
                mouseY = Mathf.Clamp(mouseY, minAngle, maxAngle); // se limita la rotacion de la camara 
            }
            transform.eulerAngles = new Vector3(0, mouseX, 0); // La rotación como ángulos de Euler en grados.
        }
       
    }
}
