using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanelShop()
    {
        if(Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
