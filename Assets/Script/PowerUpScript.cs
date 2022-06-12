using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = -Vector2.up * velocidade;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D outro) 
    {
        if(outro.gameObject.tag == "ColisorBaixo")
        {
            Destroy(gameObject);
        }           
    }
}
