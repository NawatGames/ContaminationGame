using UnityEngine;

public class ContaminedArea : AreaBaseState
{
    public override void EnterState(AreaStateManager area)
    {
        Debug.Log("Estado da area: Contaminada");
    }

    public override void UpdateState(AreaStateManager area)
    {
        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log(area.currentState);
        }
        if (Input.GetKeyDown(KeyCode.N)){
            area.SwitchState(area._dominatedArea);
        }        
    }
}
