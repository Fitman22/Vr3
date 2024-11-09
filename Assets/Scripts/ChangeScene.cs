using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] int sceneLoad;
 public void nexScene(){
    SceneManager.LoadScene(sceneLoad);
 }
}
