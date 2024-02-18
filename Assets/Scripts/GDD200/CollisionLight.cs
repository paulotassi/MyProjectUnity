using UnityEngine;
using UnityEngine.Events;

public class CollisionLight : MonoBehaviour
{
    public UnityEvent OnLightCollision;
    private void OnTriggerEnter(Collider other)
    {
        OnLightCollision.Invoke();
    }

}