using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    //public int health = 100;  // Vida do jogador
    private PlayerStats playerStats; // Referência ao PlayerStats -----------------------

    private void Start() { // -----------------------
        playerStats = GetComponent<PlayerStats>(); // -----------------------
    } // -----------------------

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstáculo"))
        {
            playerStats.TakeDamage(1); // -----------------------
            //health -= 20;  // Reduz a vida
            //Debug.Log("Colidiu com obstáculo! Vida: " + health);
        }
    }
}
