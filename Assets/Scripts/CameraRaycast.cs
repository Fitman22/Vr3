using System.Collections;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    // Variable pública para asignar la cámara VR
    public Camera vrCamera;

    // Longitud máxima del rayo
    public float maxDistance = 100f;

    // LayerMask para filtrar los objetos que quieres que el raycast detecte (opcional)
    public LayerMask raycastLayerMask;

    void Update()
    {
        // Verificar si la cámara VR está asignada
        if (vrCamera == null)
        {
            Debug.LogWarning("No se ha asignado la cámara VR.");
            return;
        }

        // Posición de la cámara (origen del rayo)
        Vector3 rayOrigin = vrCamera.transform.position;
        
        // Dirección del rayo (hacia adelante desde la cámara)
        Vector3 rayDirection = vrCamera.transform.forward;

        // Realizar el Raycast All
        RaycastHit[] hitInfos = Physics.RaycastAll(rayOrigin, rayDirection, maxDistance, raycastLayerMask);

        // Verificar si se golpearon objetos
        bool looking=false;
        if (hitInfos.Length > 0)
        {
            // Iterar sobre todos los impactos
            foreach (RaycastHit hitInfo in hitInfos)
            {
                if(hitInfo.transform.CompareTag("Event")){
                    hitInfo.transform.gameObject.GetComponent<ActiveEvents>().callEvents();
                }
                if(hitInfo.transform.CompareTag("NextLevel")){
                    looking=true;
                }
            }
        }
        if(!ControllerLevels.instance.looking&&looking){
            Debug.Log("start");
            ControllerLevels.instance.looking=true;
            StartCoroutine(ControllerLevels.instance.timeLook(ControllerLevels.instance.initialSeconds));
            }
         if(ControllerLevels.instance.looking&&!looking){
             ControllerLevels.instance.looking=false;
            }
    }

}
