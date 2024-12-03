using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth; // Vida máxima
    public int currentHealth; // Vida atual do personagem
    public int Experiencia; // Pontuação do jogador
    public Slider healthBar; // Referência à barra de vida
    public Image healthBarFill;
    private Color originalColor;
    private bool isFlashing = false;
    private float flashDuration = 0.2f;
    private int Armor; // Referencia a armadura do player
    public Image ammoFill; // fill da ammo
    public TMP_Text ArmaduraPlayer; // Referencia ao texto de municao do player
    public Image armorFill; //fill da armadura
    public int stamina;
    public TMP_Text StaminaPlayer; // Referencia ao texto de municao do player
    public TMP_Text VidaPlayer; // Referencia ao texto de municao do player
    public double regenlife;
    public Level level;
    void Start()
    {
        // Define a armadura
        Armor = 30; // Armadura base do Player
        stamina = 30; //Stamina do player
        maxHealth= 300;
        regenlife = 0.25;
        //Munição Player
        currentHealth = maxHealth;   
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        originalColor=healthBarFill.color;
        //Vida do player 
        UpdateArmaduraPlayerText();
        UpdateStamina();
        UpdateVidaPlayer();
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
    // Método para adicionar Stamina
    public void AddStamina(int cansado)
    {
        cansado += stamina;
        UpdateStamina();

    }
    public void AddVida(int vidapl)
    {
        currentHealth += vidapl;
        UpdateVidaPlayer();

    }
    public void UpdateVidaPlayer()
    {
      VidaPlayer.text = "Sua Vida Atual é:" + currentHealth;
    }
    //Da Update Na Stamina do Player no TMP
    void UpdateStamina()
    {
      StaminaPlayer.text = "Stamina:" + stamina;
    }
    //Da Update Na armor TMP
    void UpdateArmaduraPlayerText()
    {
        ArmaduraPlayer.text = "Armadura " + Armor;
    }
    //Luzinha da vida do player
    private IEnumerator FlashRed(){
        isFlashing=true;
        healthBarFill.color = Color.red;
        yield return new WaitForSeconds(flashDuration);
        healthBarFill.color = originalColor;
        isFlashing = false;
    }

}
