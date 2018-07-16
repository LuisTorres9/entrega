using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    int nC; //variable tipo entero que sera encargada de la asignacion de las instancias 
    public GameObject player; //jugador
    GameObject zombieMesh; //objeto que cumplira funcion de zombie y ciudadano al azar 
    int randomZC; // Variabke que se encarga de elegir entre zombie o ciudadano 
    List<GameObject> lista = new List<GameObject>(); // lista donde estaran todos los zombies y ciudadanos 
    readonly int minNum = 5; // limita el numero minimo a 5 
    public int cont1; // contador de zombie 
    public int cont2; // contado de ciudadano 

    Text ciudadano; 
    Text zombie;
    void Start()
    {
        //instanciamos player
        Instantiate(player);

        //nc toma un valor entre 5 y 10 para la cantidad de instancias
        nC = Random.Range(minNum, 15);
    
        for (int i = 0; i < nC; i++)
        {
            randomZC = Random.Range(1, 3);
            if(randomZC == 1)
            {
                zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube); //Instancia el cubo 
                zombieMesh.tag = "Zombie";
                //define la posicion del GameObject 
                Vector3 pos = new Vector3();
                pos.x = Random.Range(-10, 10); pos.y = 0f; pos.z = Random.Range(-10, 10);
                zombieMesh.transform.position = pos;
                lista.Add(zombieMesh);
                zombieMesh.AddComponent<Zombie>();
                
            }
            else
            {
                zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Cube); //Instancia el cubo 
                zombieMesh.tag = "Ciudadano";
                //define la posicion del GameObject 
                Vector3 pos = new Vector3();
                pos.x = Random.Range(-10, 10); pos.y = 0f; pos.z = Random.Range(-10, 10);
                zombieMesh.transform.position = pos;
                lista.Add(zombieMesh);
                zombieMesh.AddComponent<Ciuadano>();
            }
          
          

        }

        //si un gameobject en la lista tiene el componente zombie el contador "cont1" aumentara su valor a 1 si no el contador "cont2" aumentara su valor a 1
        foreach(GameObject objeto in lista)
        {
            if (objeto.GetComponent<Zombie>())
            {
                cont1 += 1;
            }
            else
            {
                cont2 += 1;
            }
            
        }
        //le agregamos el componete text a ciudadano y a zombie 
        ciudadano = GameObject.Find("Ciudadano").GetComponent<Text>();
        zombie = GameObject.Find("Zombie").GetComponent<Text>();
    }


    void Update()
    {  //se acutualiza los textos en la Scena con el nombre de Ciudadano Y zombie 
       //se le da el valor de cont1 y cont2 
        ciudadano.text = "Ciudadano = " + cont2; 
        zombie.text = "Zombie = " + cont1;
    }
}
