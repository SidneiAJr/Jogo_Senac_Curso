using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private  PlayerStats playStats;
    private  PlayerStats maxHealth;
    private PlayerStats playerStats; // Referência ao PlayerStats 

    private void Start() { 
        playerStats = GetComponent<PlayerStats>(); 
    } 

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Inimigo"))
        {
            playerStats.TakeDamage(1); 
            playerStats.maxHealth -= 1;
            Debug.Log("Voce foi Atigindo" + maxHealth);
        }
    }
}
