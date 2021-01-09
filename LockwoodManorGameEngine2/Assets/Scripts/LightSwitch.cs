using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{
    public bool isOn;
    public GameObject m_Light;
    private float timeRemaining = 60f;
    [SerializeField] private AudioSource switchPlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        switchPlay.GetComponent<AudioSource>();
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        if (timeRemaining <= 0)
        {
            isOn = false;
            UpdateLight();
        }
    }

    // Update is called once per frame
    void UpdateLight()
    {
        switchPlay.Play();
        m_Light.SetActive(isOn);
        if (isOn == true)
        {
            timeRemaining = 60f;
        }
    }

    public override string GetDescription()
    {
        if (isOn) return "Press [E] to <color=red>switch off</color> the light.";
        return "Press [E] to <color=green>switch on</color> the light.";
    }

    public override void Interact()
    {
        isOn = !isOn;
        UpdateLight();
    }
}
