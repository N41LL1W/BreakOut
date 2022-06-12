using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaExplosao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    void OnTriggerEnter2D(Collider2D outro) 
    {
        if(outro.gameObject.tag == "Bloco")
            Destroy(outro.gameObject);    
    }
}
