using UnityEngine;

public enum Direccion
{
    Norte,
    Sur,
    Este,
    Oeste,
    Stop
}
public class TriggerDirection : MonoBehaviour
{
   [SerializeField] Direccion direction;

   private void OnTriggerEnter(Collider other) {
    if(other.CompareTag("Player")){
        other.GetComponent<MovePlayer>().setDireccion(direction);
        
        }
   }
}
