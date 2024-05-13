using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    Text text;

    public void PlayerNameInput(GameObject gameObject)
    {
        text = gameObject.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Text>();
        text.text = DataManager.playerNameInput;
    }
}