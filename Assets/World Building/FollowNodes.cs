using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FollowNodes : MonoBehaviour
{
    /// <summary>
    /// Script de movimiento, funcionalidades para hacer que el objeto siga un
    /// camino de nodos.
    /// </summary>

    [SerializeField] private Transform target;
    [SerializeField] private float speed;

    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        transform.LookAt(target);
        playerRb.linearVelocity = transform.forward * speed;
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}
