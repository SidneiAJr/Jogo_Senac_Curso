using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class Level : MonoBehaviour
{
    public int xp_inicial = 0;
    public int xp_requerido=100;
    public int LeveldoPlayer=0;
    public TMP_Text LevelText;

    public void AddExperience(int experiencePoints)
    {
     xp_inicial +=experiencePoints;
     if(xp_inicial>=xp_requerido)
     {
      LevelUp();
     }
    }
    void LevelUp()
    {
        LeveldoPlayer++;
        Debug.Log("Parabens Subiu de level"+LeveldoPlayer);
        xp_requerido = CalculateRequiredExperience();
        xp_inicial = 0;
    }
    int CalculateRequiredExperience()
    {
        return xp_requerido *2;
    }
}
