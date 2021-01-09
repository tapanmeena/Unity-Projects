﻿using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
public class PlayerListItem : MonoBehaviourPunCallbacks
{
	Player player;
	[SerializeField] Text text;

	public void SetUp(Player _player)
	{
		player = _player;
		text.text = _player.NickName;
	}
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
		if(player == otherPlayer)
		{
			Destroy(gameObject);
		}
	}

	public override void OnLeftRoom()
	{
		Destroy(gameObject);
	}
}