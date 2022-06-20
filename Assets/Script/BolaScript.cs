using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{
    public float velBola;
    public Transform jogador;
    public float posicaoBolinha;

    private bool comecou;

    public GameObject[] powerUps;

    public float porcentagem;

    private PlayerScript scriptPlayer;

    public GameObject Explosion;

    private gameManager gManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gManagerScript = GameObject.Find("GameManager").GetComponent<gameManager>();
        scriptPlayer = GameObject.Find("Player").GetComponent<PlayerScript>();
        //GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2, 2), velBola);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !comecou)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(UnityEngine.Random.Range(-2f, 2f), velBola);
            comecou = true;
        }

        if (!comecou)
        {
            transform.position = new Vector2(jogador.position.x, transform.position.y);
        }
    }

    void FixedUpdade()
    {
        if (comecou)
        {

            if (GetComponent<Rigidbody2D>().velocity.y < 2 && GetComponent<Rigidbody2D>().velocity.y > -2)
            {
                GetComponent<Rigidbody2D>().gravityScale = 3;
            }
            else
            {
                GetComponent<Rigidbody2D>().gravityScale = 0;
            }
        }
    }


    float colisaoBolinha (Vector2 posicaoBolinha, Vector2 posicaoJogador, float larguaJogador)
    {
        return (posicaoBolinha.x - posicaoJogador.x) / larguaJogador;
    }

    void OnCollisionEnter2D(Collision2D outro)
    {
        if(outro.gameObject.tag == "Bloco_Amarelo" || outro.gameObject.tag == "Bloco_Azul" || outro.gameObject.tag == "Bloco_AzulClaro" || outro.gameObject.tag == "Bloco_Cinza" || outro.gameObject.tag == "Bloco_Laranja" || outro.gameObject.tag == "Bloco_Marrom" || outro.gameObject.tag == "Bloco_Roxo" || outro.gameObject.tag == "Bloco_Verde" || outro.gameObject.tag == "Bloco_VerdeEscuro" || outro.gameObject.tag == "Bloco_Vermelho")
        {
            if(scriptPlayer.ativaExplosao)
                Instantiate(Explosion, outro.transform.position, Quaternion.identity);

            if(UnityEngine.Random.Range(0f,1f) <= porcentagem)
            {
                Instantiate(powerUps[UnityEngine.Random.Range(0,powerUps.Length)], outro.gameObject.transform.position, Quaternion.identity);
            }

            Destroy(outro.gameObject);
        }

        if (outro.gameObject.tag == "Player")
        {
            float resultadoCalculo = colisaoBolinha(transform.position, outro.transform.position, ((BoxCollider2D)outro.collider).size.x);

            Vector2 novaDirecao = new Vector2(resultadoCalculo, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = novaDirecao * velBola;
        }

        if (outro.gameObject.tag == "ColisorBaixo")
        {
            if(gManagerScript.Vidas > 1)
            {
                gManagerScript.Vidas -= 1;
                transform.position = new Vector2(jogador.transform.position.x, jogador.position.y + posicaoBolinha);
                comecou = false;

                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }

            else
            {
                gManagerScript.Vidas -= 1;
                Destroy(gameObject);
            }
        }
    }

}
