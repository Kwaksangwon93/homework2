using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class CameraMove : MonoBehaviour
{
    public SetName setName;

    public GameObject playerPrefabs;
    public CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        if (CharacterChoice.selectedCharacter == 1)
        {
            playerPrefabs = Resources.Load("Player1")as GameObject;
        }
        else if (CharacterChoice.selectedCharacter == 2)
        {
            playerPrefabs = Resources.Load("Player2")as GameObject;
        }

        GameObject player = Instantiate(playerPrefabs);

        virtualCamera.Follow = player.transform;

        setName = player.GetComponent<SetName>();
        setName.PlayerNameInput(player);
    }

    private void LateUpdate()
    {
        if (playerPrefabs != null)
        {
            var pos = playerPrefabs.transform.position;
            pos.z = -10f;
            transform.position = pos;
        }        
    }
}