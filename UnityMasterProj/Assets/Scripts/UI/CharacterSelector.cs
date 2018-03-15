using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour {

	public SO_Player[] charList;
	public GameObject player;
	private PlayerController playerController;

	void Start()
	{
		playerController = player.GetComponent<PlayerController>();
	}

	public void OnSelectCharacter(int charNum)
	{
		playerController.player = charList[charNum];
	}
}
