using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaStateControler : MonoBehaviour
{
    public AreaBaseState currentState;
    public HealthyArea _healthyArea = new HealthyArea();
    public ContaminedArea _contaminedArea = new ContaminedArea();
    public DominatedArea _dominatedArea = new DominatedArea();
    public ViralCradleArea _viralCradleArea = new ViralCradleArea();
    
    void Start()
    {
        currentState = _healthyArea;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(AreaBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
