using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gamemanager;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<PlayerCollectCoins>().allPoints += other.GetComponent<PlayerCollectCoins>().points;
        gamemanager.CompleteLevel();
    }
}
