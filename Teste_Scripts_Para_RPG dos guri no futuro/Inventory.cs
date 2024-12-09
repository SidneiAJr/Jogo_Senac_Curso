using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();  // Lista de itens no inventário

    // Função para adicionar um item ao inventário
    public void AddItem(Item item)
    {
        items.Add(item);
        Debug.Log("Item Adicionado: " + item.itemName);
    }

    // Função para remover um item do inventário
    public void RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log("Item Removido: " + item.itemName);
        }
        else
        {
            Debug.Log("Item não encontrado!");
        }
    }

    // Função para exibir os itens no inventário
    public void ShowInventory()
    {
        Debug.Log("Inventário:");
        foreach (Item item in items)
        {
            Debug.Log(item.itemName);  // Mostra o nome de cada item na lista
        }
    }
}
