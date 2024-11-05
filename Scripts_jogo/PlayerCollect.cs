using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coletavel"))
        {
            score +=10;
            Destroy(other.gameObject);
            Debug.Log("Coletavel Obtido! Pontuação:"+score);
        }
    }
}
