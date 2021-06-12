using UnityEngine;

public class CloseShop : MonoBehaviour
{
    public GameObject Panel;

    public void ClosePanelShop()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}
