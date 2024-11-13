using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerChangeScene : MonoBehaviour
{
    /// <summary>
    /// Script que sigue el movimiento de otro gameObject
    /// </summary>
    [SerializeField] private float timeInTrigger;
    [SerializeField] private string sceneName;
    [SerializeField] private FadeBlack fadeBlack;

    private float timer;

    private void Start()
    {
        timer = timeInTrigger;
    }

    public void OnTriggerEnter()
    {
        timer = timeInTrigger;
    }

    public void OnTriggerStay()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SceneManager.LoadScene(sceneName);
            fadeBlack.ChangeVisibility((timeInTrigger - timer) / timeInTrigger);
        }
    }
}
