using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GrabObjectSceneChanger : MonoBehaviour
{
    /// <summary>
    /// Script que sigue el movimiento de otro gameObject
    /// </summary>
    [SerializeField] private float timeInTrigger;
    [SerializeField] private string sceneName;
    [SerializeField] private FadeBlack fadeBlack;

    private float timer;
    private bool isActive;

    private void StartSceneChangingTimer()
    {
        isActive = true;
        timer = timeInTrigger;
        StartCoroutine(Timer());
    }

    public void StopSceneChangingTimer()
    {
        isActive = false;
    }

    public IEnumerator Timer()
    {
        while (isActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;
                SceneManager.LoadScene(sceneName);
                isActive = false; // break
            }
            yield return null;
        }

    }
}
