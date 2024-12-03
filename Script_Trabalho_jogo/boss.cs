using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class boss : MonoBehaviour
{
    public int Health; // Vida máxima
    public GameObject player;
    private Level level;
    private int armadura;

   // Método para atualizar a vida
    void Start()
    {
        Health=10000;
        armadura=200;
    }
    void armadura_inimigo(int damage)
    {
        damage -= armadura;
        if(armadura>0)
        {
        Debug.Log("A armadura do inimigo foi quebrada");
        Health -= damage;
        }

    }

    public void DarDamage(int damage)
    {
        Health -= damage;
    }
     //comparação de tag para dar dano.
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Projétil"))
        {
        DarDamage(20);
        Destroy(other.gameObject);
        if (Health <= 0){
            level.AddExperience(5);
            Destroy(this.gameObject);
        }
        }
    }
}
