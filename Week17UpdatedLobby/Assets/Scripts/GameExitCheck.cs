using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameExitCheck : MonoBehaviour
{
    public GameObject playerObject;
    public TMPro.TextMeshProUGUI exitMessage;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerGoals.HasFinishedGoal)
        {
            exitMessage.text = "Mission Accomplished!";
            StartCoroutine(FinishMazeReturnToLobby());
            
        }
        else
        {
            exitMessage.text = "You have not copied the\nsecret documents yet.";
        }
    }

    IEnumerator FinishMazeReturnToLobby()
    {
        yield return new WaitForSeconds(5);
        SceneLoader.Instance.ChangeScene(SceneUtils.scenes[1]);
    }
}
