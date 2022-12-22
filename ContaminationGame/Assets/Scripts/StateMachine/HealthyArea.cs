using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyArea : AreaBaseState
{
    public override void EnterState(AreaStateControler area)
    {
        Debug.Log("Estado da area: Saudavel");
    }

    public override void UpdateState(AreaStateControler area)
    {
        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log(area.currentState);
        }
        if (Input.GetKeyDown(KeyCode.N)){
            area.SwitchState(area._contaminedArea);
        }
    }
}
