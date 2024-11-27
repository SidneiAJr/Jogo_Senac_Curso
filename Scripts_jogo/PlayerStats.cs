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
    private float dano; // Referencia do dano para buffar o tiro do player
    public Slider ammoBar; // Slider da munição
    public TMP_Text MunicaoPlayer; // Referencia ao texto de municao do player
    public Image ammoFill;
    public Slider armorBar;
    public TMP_Text ArmaduraPlayer; // Referencia ao texto de municao do player
    public Image armorFill;
    

    void Start()
    {
        // Define a vida inicial como o valor máximo
        munition = 10;
        Armor = 10; 
        dano = 25.5;
        ammo_Muni = munition;
        ammo_Muni.ammo_muni = munition;
        ammo_Muni.value=munition;
        originalColor=ammoFill.color;
        UpdateMunicaoPlayer();
        currentHealth = maxHealth;   
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        originalColor=healthBarFill.color;
        base_armor = Armor;
        UpdateScoreText();
        baseArmor = Armor ;   
        armorBar.baseArmor = Armor;
        healthBar.value = currentHealth;
        originalColor=healthBarFill.color;
        base_armor = Armor;
        ArmaduraPlayerText();
        
    }

    // Método para atualizar a vida
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Garante que a vida não fique negativa
        healthBar.value = currentHealth;
        if(currentHealth > 0 && !isFlashing)
        {
           StartCoroutine(FlashRed());
        }
    }

    // Método para adicionar pontos
    public void Addarmor(int armadura)
    {
      Armor += armadura;
      UpdateScoreText();
    }
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }
    public void Addmunition(int cartucho)
    {
        munition += cartucho;
        UpdateScoreText();
        
    }
     public void AddDano(float dano_base )
    {
        dano_base += Dano;
        UpdateScoreText();
        
    }
    // Atualiza o texto da pontuação
    void UpdateScoreText()
    {
        scoreText.text = "Pontuação: " + score;
    }
    private IEnumerator FlashRed(){
        isFlashing=true;
        healthBarFill.color = Color.red;
        yield return new WaitForSeconds(flashDuration);
        healthBarFill.color = originalColor;
        isFlashing = false;
    }

}
