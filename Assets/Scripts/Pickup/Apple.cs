using UnityEngine;

public class Apple : Pickup
{
    [SerializeField] float adjustChangeMoveSpeed = 3f;

    LevelGenerator levelGenerator;

    public void Init(LevelGenerator lg)
    {
        levelGenerator = lg;
    }

    protected override void OnPickup()
    {
        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeed);
    }
}
