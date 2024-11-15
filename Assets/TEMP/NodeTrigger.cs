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
        FollowNodes movingObject;
        movingObject = collider.gameObject.GetComponent<FollowNodes>();

        if(nextNode != null) // verificar si hay
        {
            movingObject.SetTarget(nextNode);
            return;
        }

        movingObject.Stop();
    }
}
