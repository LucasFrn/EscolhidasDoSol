using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Personagem : MonoBehaviour
{
    public int vida { get; set; }
    public float destreza { get; set; }
    public int ataque { get; set; }
    public int ataqueMagico { get; set; }
    public int energia { get; set; }
    public int recuperacao { get; set; }
    public List<Item> inventario { get; set; }
    public List<Habilidade> habilidades { get; set; }
    public int equipe { get; set; }
    public void IniciaCombate()
    {
        //Update do observer Batalha
    }
    
    public void UsarItem(Item item)
    {
        item.Efeito();
        inventario.Remove(item);
    }
    public void AddItem(Item item)
    {
        inventario.Add(item);
    }
    public void DropItem(Item item)
    {
        inventario.Remove(item);
        //TODO instanciar item no chão
    }
    public void SofrerDano(int dano)
    {
        vida -= dano;
    }
    public void Curar(int cura)
    {
        vida += cura;
    }
    public void Atacar(Personagem alvo, int dano)
    {
        energia += recuperacao;
        alvo.SofrerDano(dano);
    }
    public void UsarHabilidade(Personagem alvo, Habilidade habilidade)
    {
        habilidade.Efeito(alvo);
    }
}
