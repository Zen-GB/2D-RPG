using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableType type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player != null )
        {
            player.inventory.Add(type);
            Destroy(this.gameObject);
        }
    }

    public enum CollectableType
    {
        NONE, CARROT_SEED, STRAWBERRY_SEED, CORN_SEED
    }
}
