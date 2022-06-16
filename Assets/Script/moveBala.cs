using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBala : MonoBehaviour
{

    private Rigidbody2D rb2d;
    public float VelInicial;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, VelInicial);
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if(outro.gameObject.tag == "Bloco_Amarelo" || outro.gameObject.tag == "Bloco_Azul" || outro.gameObject.tag == "Bloco_AzulClaro" || outro.gameObject.tag == "Bloco_Cinza" || outro.gameObject.tag == "Bloco_Laranja" || outro.gameObject.tag == "Bloco_Marrom" || outro.gameObject.tag == "Bloco_Roxo" || outro.gameObject.tag == "Bloco_Verde" || outro.gameObject.tag == "Bloco_VerdeEscuro" || outro.gameObject.tag == "Bloco_Vermelho")
        {
            Destroy(outro.gameObject);
            Destroy(gameObject);

        }

        if(outro.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
 
    }
}
