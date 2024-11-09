using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    Direccion currentDirection;
    private void Start() {
        setDireccion(Direccion.Norte);
    }
  public void setDireccion(Direccion dir){
     currentDirection=dir;
    Vector3 nextDirection = Vector3.zero;
    if(dir==Direccion.Norte)nextDirection= Vector3.left;
    if(dir==Direccion.Sur)nextDirection= Vector3.right;
    if(dir==Direccion.Este)nextDirection= Vector3.forward;
    if(dir==Direccion.Oeste)nextDirection= Vector3.back;
    if(dir==Direccion.Stop)nextDirection= Vector3.zero;
    rb.linearVelocity= nextDirection*speed;
  }
}
