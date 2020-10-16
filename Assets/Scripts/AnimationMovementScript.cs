using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMovementScript : MonoBehaviour
{
    public bool canBe = false;
    public void MovementCoin(GameObject coin)
    {
        coin.transform.position = Vector3.MoveTowards(coin.transform.position, new Vector3(coin.transform.position.x, coin.transform.position.y, 0.9f), Time.deltaTime);
    }

    private void Update()
    {
        if (canBe)
            MovementCoin(this.gameObject);
    }
}
