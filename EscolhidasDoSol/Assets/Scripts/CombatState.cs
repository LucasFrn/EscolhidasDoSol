using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CombatState : MonoBehaviour, State
{
    
    private Personagem eu;
    public Personagem inimigo;
    private void Start()
    {
        eu = this.gameObject.GetComponent<Personagem>();
    }
    public void Executar()
    {
        //SELEÇÃO DE UI
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J))
        {

        }
        //
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.J)) 
        {
            eu.Atacar(inimigo,eu.ataque);
            Debug.Log("ataquei - vida do inimigo = " + inimigo.vida);
        }
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.K)) 
        {
            eu.Curar(30);
            Debug.Log("Curei - vida = " + eu.vida);
        }
    }
}
