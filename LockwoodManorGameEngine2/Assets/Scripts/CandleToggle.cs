using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleToggle : Interactable
{
    public Light m_Candle;
    public ParticleSystem m_particle;
    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCandle();
    }

    // Update is called once per frame
    void UpdateCandle()
    {
        m_Candle.enabled = isOn;
        m_particle.enableEmission = isOn;
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
