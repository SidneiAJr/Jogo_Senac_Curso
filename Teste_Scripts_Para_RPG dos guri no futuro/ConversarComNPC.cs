using UnityEngine;
using UnityEngine.UI;  // Necessário para UI
using TMPro;

public class ConversarComNPC : MonoBehaviour
{
    // Referência ao Canvas de UI e ao Text de diálogo
    public GameObject canvasUI;  // O Canvas onde o diálogo será exibido
    public Text textoDialogo; // O Text que exibirá o diálogo
    public string[] dialogo;     // O conjunto de frases do NPC
    private int indiceDialogo = 0;  // Índice atual do diálogo

    private bool jogadorProximo = false;  // Verifica se o jogador está perto o suficiente para interagir

    void Start()
    {
        canvasUI.SetActive(false);  // Desativa o Canvas no início
    }

    void Update()
    {
        // Verifica se o jogador está perto e pressiona a tecla "E" para iniciar a conversa
        if (jogadorProximo && Input.GetKeyDown(KeyCode.E))
        {
            IniciarConversacao();
        }
    }

    // Função chamada quando o jogador entra na área de interação
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Verifica se o objeto é o jogador
        {
            jogadorProximo = true;  // Jogador está perto do NPC
        }
    }

    // Função chamada quando o jogador sai da área de interação
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jogadorProximo = false;  // Jogador saiu da área de interação
        }
    }

    // Inicia a conversa
    private void IniciarConversacao()
    {
        if (indiceDialogo < dialogo.Length)
        {
            // Exibe o próximo diálogo
            textoDialogo.text = dialogo[indiceDialogo];
            indiceDialogo++;
            canvasUI.SetActive(true);  // Ativa a interface de conversa
        }
        else
        {
            // Se o diálogo terminar, desativa a interface de conversa
            canvasUI.SetActive(false);
            indiceDialogo = 0;  // Reseta o índice para começar novamente da primeira fala, se desejado
        }
    }
}
