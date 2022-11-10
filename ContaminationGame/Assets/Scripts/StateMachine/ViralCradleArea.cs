using UnityEngine;

public class ViralCradleArea : AreaBaseState
{
    public override void EnterState(AreaStateManager area)
    {
        Debug.Log("Estado da area: Berço Viral");
    }

    public override void UpdateState(AreaStateManager area)
    {
        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log(area.currentState);
        }
    }
}
