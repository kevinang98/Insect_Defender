using UnityEngine;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour {

    public GameObject ui;

    private Node target;

    public Text sellAmount;

    public void SetTarget (Node Target)
    {
        target = Target;

        transform.position = target.GetBuildPosition();

        //sellAmount.text = "" + target.turretBluePrint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide ()
    {
        ui.SetActive(false);
    }

    public void Sell ()
    {
        target.sellTurret();
        BuildManager.instance.DeselectedNode();
    }
}
