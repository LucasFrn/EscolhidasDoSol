using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AIExploringState : MonoBehaviour, State
{
    public void Executar()
    {
        //Alterar o update para executar
    }
    public GameObject player;
    public float speed;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;

        if(distance<30)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        if (distance < 2)
        {
            SceneManager.LoadScene(1);
        }
    }
}
