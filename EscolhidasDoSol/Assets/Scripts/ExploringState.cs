using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploringState : MonoBehaviour, State
{
    private Personagem personagem;
    public void Executar()
    {
        //MOVIMENTAÇÃO
        if (Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow))
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
}
