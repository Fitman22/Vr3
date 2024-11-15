using UnityEngine;

public class NodeTrigger : MonoBehaviour
{
    /// <summary>
    /// Cambia el destino del objeto que entra al trigger hacia el siguiente
    /// nodo
    /// </summary>

    [SerializeField] Transform nextNode;

    public void OnTriggerEnter(Collider collider)
    {
        if(nextNode != null) // verificar si hay
        {
            FollowNodes movingObject;
            movingObject = collider.gameObject.GetComponent<FollowNodes>();

            movingObject.SetTarget(nextNode);
        }
    }
}
