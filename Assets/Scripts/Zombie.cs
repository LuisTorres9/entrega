using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zombie : MonoBehaviour
{
    ColorType mycolor;
    MyGustoAseessino myGusto;
  
    MyStruct str; //almacenamos la informacion del struct "MyStruct" en "str"

    int mov; //swich donde selecionamos el estado del zombie 
    int altM; //Velocidad a la que rotara el zombie 

 

    void Start()
    {
        //se adquiere un valor rando para mycolor y mygusto ademas de eso se ejecuta la corrutina MovimientoZombie 
        mycolor = (ColorType)Random.Range(0, 3); 
        str.myGusto2 = (MyGustoAseessino)Random.Range(0, 5);
        StartCoroutine(MovimientoZombie());
       
    }

    void Update()
    {
       
        //dependiendo del valor que nos haiga dado mycolor, pintamos el zombien de color cyan, green o magenta
        if (mycolor == ColorType.cyan)
        {
            this.GetComponent<Renderer>().material.color = Color.cyan;
        }

        if(mycolor == ColorType.green)
        {
            this.GetComponent<Renderer>().material.color = Color.green;
        }

        if (mycolor == ColorType.magenta)
        {
            this.GetComponent<Renderer>().material.color = Color.magenta;
        }

        //Switch con el cual escojeremos cada uno de los estados de zombie 
        switch (mov)
        {
            case 1:

                transform.position += transform.forward * Time.deltaTime;
                break;

            case 2:
                altM = Random.Range(10, 20);
                transform.Rotate(0, Time.deltaTime * altM, 0);
                break;

                case 3:

                transform.position += transform.right * Time.deltaTime;
                break;

            case 4:
                transform.position -= transform.right * Time.deltaTime;
                break;

            case 5:
                transform.position += new Vector3(0, 0, 0);
                break;

            case 6:
                transform.position -= transform.forward * Time.deltaTime;
                break;

        }



    }

    public void InfoMove()
    {
        //si el estado del enum Movimiento es moving entonces, mov escoje un valor random entre 1 y 6 y se ejecuta la corrutina "MovimientoZombie"
        //si no mov adquiere un valor de 6 y se ejecuta la corrutina "MovimientoZombie
        if (str.myMovimiento == Movimiento.moving)
        {
            mov = Random.Range(1,6);
            StartCoroutine(MovimientoZombie());
        }
        else
        {
            mov = 6;
            StartCoroutine(MovimientoZombie());
        }
    }

    public MyStruct Info()
    {
        //retorna el str (MyStruct)
        return str;
        
    }
    IEnumerator MovimientoZombie ()
    {
        //se esperan 3 segundo, luego de eso , se le da un valor rando a myMovimiento, se ejecuta InfoMove y se incia la corrutina MovimientoZombie
        yield return new WaitForSeconds(3);
        str.myMovimiento = (Movimiento)Random.Range(0, 2);
        InfoMove();
        StartCoroutine(MovimientoZombie());
 
    }

   
}
//enun donde temos los estados del ZOmbie
public enum Movimiento
{
    idle,moving,rotation
}
//enum donde tenemos los tres colores que puede tener el zombie 
public enum ColorType
{
    cyan, magenta, green
}
//enum donde tenemos la parte del cuerpo que le gusta comer al zombie 
public enum MyGustoAseessino
{
    torso, mano, corazon, cerebro, pie
}


//struct donde guardamos la informacion de "ColorType, MyGustoAssesino y movimiento"
public struct MyStruct
{
    public ColorType mycolor2;
    public MyGustoAseessino myGusto2;
    public Movimiento myMovimiento;
}

