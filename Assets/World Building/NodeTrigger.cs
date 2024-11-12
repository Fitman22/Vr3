using UnityEngine;

public class No : MonoBehaviour
{
    /// <summary>
    /// Cambia el destino del objeto que entra al trigger hacia el siguiente
    /// nodo
    /// </summary>

    [SerializeField] Transform nextNode;

    public void OnTriggerEnter(Collider collider)
    {

            Debug.Log("Collider entrado!!!");
        if(nextNode != null) // verificar si hay
        {
            Debug.Log("Collider Encontrado!!!");
            FollowNodes movingObject;
            movingObject = collider.gameObject.GetComponent<FollowNodes>();

            movingObject.SetTarget(nextNode);
        }
    }
}
