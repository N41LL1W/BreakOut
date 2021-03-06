using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    //Aqui você coloca a velocidade que o PowerUp desce.
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = -Vector2.up * velocidade;
    }

    //Aqui você destroi o PowerUp quando pega ele.
    void OnTriggerEnter2D(Collider2D outro) 
    {
        if(outro.gameObject.tag == "ColisorBaixo")
        {
            Destroy(gameObject);
        }           
    }
}
