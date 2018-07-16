using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe : MonoBehaviour
{
    public string n;
    MyStruct zombieInfo; //struc donde se guardo toda aquella información respecto al zombie 
    MyStruct2 ciudadanoInfo; //struct donde se tiene guardad toda la información de el mismo 

    private GameObject healtBar;

    [Header("Shoot")]
    public GameObject shot;
    public Transform sootspawn;
    public float fireRate;
    private float nextFire;

     void Start()
    {
        healtBar = GameObject.Find("HealthBar");
    }
    //si el heroe toca al el zombie o el ciudadano se ejecuta el mensaje correspondiente 
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Zombie>())
        {
            zombieInfo = collision.gameObject.GetComponent<Zombie>().Info();
            //Se ejecuta el mensaje
            Debug.Log("awrrr quiero comer tu " + zombieInfo.myGusto2);
            healtBar.SendMessage("TakeDamage", 15);

        }

        if (collision.gameObject.GetComponent<Ciuadano>())
        {
            ciudadanoInfo = collision.gameObject.GetComponent<Ciuadano>().info2();
            //Se ejecuta el mensaje
            Debug.Log("Hola soy " + ciudadanoInfo.myName + " y tengo " + ciudadanoInfo.edad);
        }
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; 
            Instantiate(shot, sootspawn.position, sootspawn.rotation); 
        }
    }
}
