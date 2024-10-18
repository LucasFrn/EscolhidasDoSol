using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Heroi : Personagem
{
   
    private State inicial;
    private void Start()
    {
        vida = maxVida;
    }
}
