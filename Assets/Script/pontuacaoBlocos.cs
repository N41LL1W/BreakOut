using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pontuacaoBlocos : MonoBehaviour
{
    private gameManager gManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gManagerScript = GameObject.Find("GameManager").GetComponent<gameManager>();
    }

    void OnDestroy()
    {
        if(gameObject.tag == "Bloco_Amarelo")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 10;
        }

        if(gameObject.tag == "Bloco_Azul")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 20;
        }

        if(gameObject.tag == "Bloco_AzulClaro")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 30;
        }

        if(gameObject.tag == "Bloco_Cinza")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 40;
        }

        if(gameObject.tag == "Bloco_Laranja")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 50;
        }

        if(gameObject.tag == "Bloco_Marrom")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 60;
        }

        if(gameObject.tag == "Bloco_Roxo")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 70;
        }

        if(gameObject.tag == "Bloco_Verde")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 80;
        }

        if(gameObject.tag == "Bloco_VerdeEscuro")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 90;
        }

        if(gameObject.tag == "Bloco_Vermelho")
        {
            gManagerScript.pontuacao = gManagerScript.pontuacao + 100;
        }
    }
}
