using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip collectSound; // Som de coleta
    private AudioSource audioSource;

    private void Start()
    {
        // Obtém o componente de áudio
        audioSource = gameObject.AddComponent<AudioSource>();
    }
    // Método chamado automaticamente quando o jogador colide com outro objeto
   private void OnControllerColliderHit(ControllerColliderHit hit)
   {
    // Verifica se o objeto com o qual colidimos possui a tag "Collectible"
    if(hit.gameObject.CompareTag("item"))
    {
        Debug.Log("Item Coletado com sucesso");
        // Exibe uma mensagem no console indicando a colisão
        // Aqui você pode adicionar outras interações, como efeitos sonoros, pontos, etc.
        // Desativa o item coletado
        audioSource.PlayOneShot(collectSound);
        hit.gameObject.SetActive(false);
    }
   }
}
