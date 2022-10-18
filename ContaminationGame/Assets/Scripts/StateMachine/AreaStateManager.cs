using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaStateManager : MonoBehaviour
{
    private AreaBaseState currentState;
    private HealthyArea _healthyArea = new HealthyArea();
    private ContaminedArea _contaminedArea = new ContaminedArea();
    private DominatedArea _dominatedArea = new DominatedArea();
    private ViralCradleArea _viralCradleArea = new ViralCradleArea();
    
    void Start()
    {
        currentState = _healthyArea;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
