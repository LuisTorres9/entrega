using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciuadano : MonoBehaviour
{

    MyStruct2 name;
    Miname nombre;

    void Start()
    {
        //se busca asignar un valor al azar de los nombres que se tienen dentro del rango estipulado 
        name.myName = (Miname)Random.Range(0, 13);
        name.edad = Random.Range(15, 101);
    }

    public MyStruct2 info2()
    {
        //retorna el valor de name 
        return name;
       
    }
   
}
//En esta función se tienen todos aquellos nombres que puede tomar el ciudadano
public enum Miname
{
    Ciro, Andres, Luisa, Alejandro, Camila, Esteban, Jose, Elkin, Alan, Rick, Valentina, Carnal
}

public struct MyStruct2
{ 
    // strut donde guardamos la informaciom de miname y edad 
    public Miname myName;
    public float edad;
}