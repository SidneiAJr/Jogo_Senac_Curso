using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class Inimigo : MonoBehaviour
{
    public int Health; // Vida máxima
    public GameObject player;
    private Level level;

   // Método para atualizar a vida
    void Start()
    {
        Health=100;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
     //comparação de tag para dar dano.
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Projétil"))
        {
        TakeDamage(50);
        Destroy(other.gameObject);
        if (Health <= 0){
            level.AddExperience(5);
            Destroy(this.gameObject);
        }
        }
    }
}
