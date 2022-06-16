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
        if(outro.gameObject.tag == "Bloco_Amarelo" || outro.gameObject.tag == "Bloco_Azul" || outro.gameObject.tag == "Bloco_AzulClaro" || outro.gameObject.tag == "Bloco_Cinza" || outro.gameObject.tag == "Bloco_Laranja" || outro.gameObject.tag == "Bloco_Marrom" || outro.gameObject.tag == "Bloco_Roxo" || outro.gameObject.tag == "Bloco_Verde" || outro.gameObject.tag == "Bloco_VerdeEscuro" || outro.gameObject.tag == "Bloco_Vermelho")
            Destroy(outro.gameObject);    
    }
}
