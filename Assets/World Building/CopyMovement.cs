using UnityEngine;

public class CopyMovement : MonoBehaviour
{
    /// <summary>
    /// Script que sigue el movimiento de otro gameObject
    /// </summary>

    [SerializeField] private Transform target;

    private void Update()
    {
        transform.position = target.position;
    }
}
