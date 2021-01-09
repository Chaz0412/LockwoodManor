using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleToggle : Interactable
{
    public Light m_Candle;
    public ParticleSystem m_particle;
    public bool isOn;
    private float timeRemaining = 60f;
    [SerializeField]private AudioSource ignitePlay;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCandle();
        
    }

    void Update()
    {
        ignitePlay.GetComponent<AudioSource>();
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        if(timeRemaining <= 0)
        {
            isOn = false;
            UpdateCandle();
        }
    }

    // Update is called once per frame
    void UpdateCandle()
    {
        m_Candle.enabled = isOn;
        m_particle.enableEmission = isOn;
        if(isOn == true)
        {
            timeRemaining = 60f;
            ignitePlay.Play();

        }
    }

    public override string GetDescription()
    {
        if (isOn) return "Press [E] to <color=red>put out</color> the candle.";
        return "Press [E] to <color=green>light</color> the candle.";
    }

    public override void Interact()
    {
        isOn = !isOn;
        UpdateCandle();
    }
}
