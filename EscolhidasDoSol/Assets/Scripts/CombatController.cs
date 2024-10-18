using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatController : MonoBehaviour
{
    public List<GameObject> Inimigos;
    public List<GameObject> Herois;
    private int inimigosVivos, heroisVivos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verificacaoDeCombate();
    }
    private void verificacaoDeCombate()
    {
        inimigosVivos = 0;
        heroisVivos = 0;
        foreach (GameObject ini in Inimigos)
        {
            if (ini != null) inimigosVivos += 1;
        }
        foreach (GameObject hero in Herois)
        {
            if (hero != null) heroisVivos += 1;
        }
        if (inimigosVivos == 0) SceneManager.LoadScene(0);
        else if (heroisVivos == 0) Debug.Log("Derrota");
    }
}
