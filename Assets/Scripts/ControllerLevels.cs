using System.Collections;
using TMPro;
using UnityEngine;

public class ControllerLevels : MonoBehaviour
{
    public static ControllerLevels instance;
    [SerializeField] TextMeshProUGUI txSeconds;
    [SerializeField] Animator anim;
    [SerializeField] public int initialSeconds;
    public bool looking;

    private void Awake() {
        instance=this;
        txSeconds.text=initialSeconds.ToString();
    }

    public IEnumerator timeLook(int seconds){
        seconds--;
        txSeconds.text=seconds.ToString();

        if (seconds<=0) {
            anim.SetTrigger("end");
        } else {
            yield return new WaitForSeconds(1f);

            if (looking) {
                StartCoroutine(timeLook(seconds));
            } else {
                txSeconds.text=initialSeconds.ToString();
            }
        }
    }

}
