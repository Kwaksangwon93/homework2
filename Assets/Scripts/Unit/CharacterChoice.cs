using UnityEngine;
using UnityEngine.UI;

public class CharacterChoice : MonoBehaviour
{
    public static int selectedCharacter = 0;

    public Button Character1Btn;
    public Button Character2Btn;
    
    public void OnClickCharacterChoice(int num)
    {
        selectedCharacter = num;
    }
}