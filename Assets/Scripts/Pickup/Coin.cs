using UnityEngine;

public class Coin : Pickup
{
    [SerializeField] int scoreAmount = 100;

    ScoreManager scoreManager;

    public void Init(ScoreManager sm)
    {
        scoreManager = sm;
    }

    protected override void OnPickup()
    {
        scoreManager.IncreaseScore(scoreAmount);
    }
}
