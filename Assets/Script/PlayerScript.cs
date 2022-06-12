using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float velocidade;
    public float direcao;
    public GameObject bala;
    public GameObject pontoBala;
    public bool podeAtirar = false;
    public float timer = 0;
    public bool ativaExplosao;

    // Start is called before the first frame update
    void Start()
    {
        ativaExplosao = false;
    }

    // Update is called once per frame
    void Update()
    {
        direcao = Input.GetAxisRaw("Horizontal");

        if(podeAtirar == true && timer > 0)
        {
            if(Input.GetButtonDown("Fire4"))
                Instantiate(bala, pontoBala.transform.position, Quaternion.identity);
                timer -= Time.deltaTime;           
        }

        if(timer <= 0 )
        {
            podeAtirar = false;
        }

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(direcao * velocidade, 0);
    }

    void OnTriggerEnter2D(Collider2D outro) 
    {
       if(outro.gameObject.tag == "Tamanho")
       {
           GetComponent<Animator>().Play("aumenta_player");
           Destroy(outro.gameObject);
       } 
       
       if(outro.gameObject.tag == "Tiro")
       {
           if(podeAtirar == false)
           {
                timer = 10;
                podeAtirar = true;
           }
           Destroy(outro.gameObject);
       }

       if(outro.gameObject.tag == "Fogo")
       {
           StartCoroutine(bolaFogo(10));

           Destroy(outro.gameObject);
       }
    }

    void TrocaAnimacao()
    {
        GetComponent<Animator>().Play("Parado");
    }

    IEnumerator bolaFogo(int tempoDeEspera)
    {
        ativaExplosao = true;
        Debug.Log("Pegou Fogo!");

        yield return new WaitForSeconds(tempoDeEspera);

        ativaExplosao = false;
        Debug.Log("Apagou Fogo!");
    }
}