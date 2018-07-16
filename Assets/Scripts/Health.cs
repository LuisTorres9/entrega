using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Image health; 
    float hp, maxHp = 100f ;
    private GameObject healtBar;
    public Text defeat;
    void Start()
    {
        hp = maxHp;
    }

    public void TakeDamage(float amount)
    {
        hp = Mathf.Clamp(hp - amount, 0f, maxHp);
        health.transform.localScale = new Vector2(hp / maxHp, 1);
        if (hp == 0)
        {
            Debug.Log("You Lose... Defeat");
            defeat.IsActive();
        }
    }
}
