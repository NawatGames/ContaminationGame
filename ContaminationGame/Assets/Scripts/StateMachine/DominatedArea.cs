using UnityEngine;

public class DominatedArea : AreaBaseState
{
    public override void EnterState(AreaStateControler area)
    {
        Debug.Log("Estado da area: Dominada");
    }

    public override void UpdateState(AreaStateControler area)
    {
        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log(area.currentState);
        }
        if (Input.GetKeyDown(KeyCode.N)){
            area.SwitchState(area._viralCradleArea);
        }
    }
}
