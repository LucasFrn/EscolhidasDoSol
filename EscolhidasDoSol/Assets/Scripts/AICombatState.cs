using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICombatState : MonoBehaviour
{
    private Personagem eu;
    public Personagem inimigo;
    // Start is called before the first frame update
    void Start()
    {
        eu = this.gameObject.GetComponent<Personagem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            eu.Atacar(inimigo, eu.ataque);
            Debug.Log("ataquei - vida do inimigo = " + inimigo.vida);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            eu.Atacar(inimigo, 100);
            Debug.Log("Super - vida do inimigo = " + inimigo.vida);
        }
    }
}
