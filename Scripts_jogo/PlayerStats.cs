using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima
    public int currentHealth; // Vida atual do personagem
    public int score = 0; // Pontuação do jogador
    public Slider healthBar; // Referência à barra de vida
    public TMP_Text scoreText; // Referência ao texto de pontuação
    public Image healthBarFill;
    private Color originalColor;
    private bool isFlashing = false;
    private float flashDuration = 0.2f;
    public int munition; // Referencia a munição
    private int ammo_Muni; //Referencia a quantidade de munição
    private int Armor; // Referencia a armadura do player
    private int baseArmor; // Referencia a armadura base para variavel
    public TMP_Text MunicaoPlayer; // Referencia ao texto de municao do player
    public Image ammoFill; // fill da ammo
    public TMP_Text ArmaduraPlayer; // Referencia ao texto de municao do player
    public Image armorFill; //fill da armadura

    void Start()
    {
        // Define a armadura
        munition = 10; //Munição do player
        Armor = 10; // Armadura base do Player
        UpdateMunicaoPlayerText();
        //Munição Player
        currentHealth = maxHealth;   
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        originalColor=healthBarFill.color;
        UpdateScoreText();
        //Vida do player
        baseArmor = Armor ;   
        baseArmor = Armor;
        UpdateArmaduraPlayerText();
    }
    // Método para atualizar a vida
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Garante que a vida não fique negativa
        healthBar.value = currentHealth;
        if(currentHealth > 0 && !isFlashing)
        {
           StartCoroutine(FlashRed());
        }
    }

    // Método para adicionar armadura
    public void Addarmor(int armadura)
    {
      Armor += armadura;
      UpdateArmaduraPlayerText();
    }
    // Método para adicionar pontos
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }
    // Método para adicionar Munição
    public void Addmunition(int cartucho)
    {
        munition += cartucho;
        UpdateMunicaoPlayerText();
        
    }
    // Atualiza o texto da pontuação
    void UpdateScoreText()
    {
        scoreText.text = "Pontuação: " + score;
    }
    void UpdateArmaduraPlayerText()
    {
        ArmaduraPlayer.text = "Armadura " + Armor;
    }
    void UpdateMunicaoPlayerText()
    {
        MunicaoPlayer.text = "Municação " + munition;
    }
    private IEnumerator FlashRed(){
        isFlashing=true;
        healthBarFill.color = Color.red;
        yield return new WaitForSeconds(flashDuration);
        healthBarFill.color = originalColor;
        isFlashing = false;
    }

}
