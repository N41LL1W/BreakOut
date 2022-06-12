using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject bolinha;

    public SpriteRenderer renderBolinha;

    private PlayerScript scriptPlayer;

    public Sprite[] sprBolinha;

    // Start is called before the first frame update
    void Start()
    {
        scriptPlayer = GameObject.Find("Player").GetComponent<PlayerScript>();
        renderBolinha = GameObject.Find("Ball").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
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
