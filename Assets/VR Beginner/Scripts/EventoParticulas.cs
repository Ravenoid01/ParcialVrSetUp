using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class EventoParticulas : MonoBehaviour
{
    [SerializeField] ParticleSystem smoke;
    private float targetValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var emission = smoke.emission;
        emission.rateOverTime = targetValue;
    }
    
    public void ChangeParticles(float value)
    {
        targetValue = value/10;
    }
}
