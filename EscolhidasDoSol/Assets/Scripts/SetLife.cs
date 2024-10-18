using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetLife : MonoBehaviour
{
    TextMeshPro txt;
    public GameObject personagem;
    Personagem ps;
    private void Start()
    {
        txt = GetComponent<TextMeshPro>();
        ps = personagem.GetComponent<Heroi>();
    }
    void Update()
    {
        txt.text = "PV: " + ps.vida;
    }
}
