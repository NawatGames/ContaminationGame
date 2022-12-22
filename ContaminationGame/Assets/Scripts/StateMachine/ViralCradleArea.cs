using UnityEngine;

public class ViralCradleArea : AreaBaseState
{
    public override void EnterState(AreaStateControler area)
    {
        Debug.Log("Estado da area: Berço Viral");
    }

    public override void UpdateState(AreaStateControler area)
    {
        if (Input.GetKeyDown(KeyCode.B)){
            Debug.Log(area.currentState);
        }
    }
}
