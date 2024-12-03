using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    private  PlayerStats playStats;
    private  PlayerStats currentHealth;
    private PlayerStats playerStats; // Referência ao PlayerStats 

    private void Start() { 
        playerStats = GetComponent<PlayerStats>(); 
    } 

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Inimigo"))
        {
        playerStats.TakeDamage(10); 
        playerStats.currentHealth -= 10;
           if(playerStats.currentHealth<=0)
           {
           }else{
            Debug.Log("Seu HP esta baixo Cuidado!" + currentHealth);
           }
            
        }
    }
}
