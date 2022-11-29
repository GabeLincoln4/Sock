using UnityEngine;

public class CollisionRespond : MonoBehaviour
{
    ICollidable currentCollidable;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        currentCollidable = collision.gameObject.GetComponent<ICollidable>();
        currentCollidable.CollisionRespond();
    }
}
