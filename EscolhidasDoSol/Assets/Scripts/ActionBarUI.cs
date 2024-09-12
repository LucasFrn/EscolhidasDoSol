using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBarUI : MonoBehaviour
{
    // Referências para os painéis de UI
    public GameObject actionBar;
    public GameObject skillBar;

    void Start()
    {
        // Garantir que a barra de ações esteja ativa e a de habilidades desativada inicialmente
        actionBar.SetActive(true);
        skillBar.SetActive(false);
    }

    // Método para ativar a barra de habilidades e desativar a barra de ações
    public void ShowSkillsBar()
    {
        actionBar.SetActive(false);
        skillBar.SetActive(true);
    }

    // Método para voltar para a barra de ações
    public void ShowActionBar()
    {
        actionBar.SetActive(true);
        skillBar.SetActive(false);
    }
}
