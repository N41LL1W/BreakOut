using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject bolinha;

    public SpriteRenderer renderBolinha;

    private PlayerScript scriptPlayer;

    public Sprite[] sprBolinha;

    public int pontuacao;

    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
        scriptPlayer = GameObject.Find("Player").GetComponent<PlayerScript>();
        renderBolinha = GameObject.Find("Ball").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = pontuacao.ToString();

        if(scriptPlayer.podeAtirar && !scriptPlayer.ativaExplosao)
            renderBolinha.sprite = sprBolinha[1];
        
        else if(!scriptPlayer.podeAtirar && scriptPlayer.ativaExplosao)
            renderBolinha.sprite = sprBolinha[2];

        else if(scriptPlayer.podeAtirar && scriptPlayer.ativaExplosao)
            renderBolinha.sprite = sprBolinha[3];
        else
            renderBolinha.sprite = sprBolinha[0];

    }
}
