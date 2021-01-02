using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject PlayerPrefab;
	public GameObject GameCanvas;
	public GameObject SceneCamera;
	Color[] colors = {Color.white,Color.black,Color.green,Color.red,Color.blue,Color.cyan};

	private void Awake()
	{
		GameCanvas.SetActive(true);
	}

	public void SpawnPlayer()
	{
		//		float randomValue = Random.Range(-1f, 1f);
		Vector3 PlayerPosition = new Vector3(156f,3.84f,-187f);
		Debug.Log("Player Object name: " + PlayerPrefab.transform.GetChild(0));
		Debug.Log("Player Object name: " + PlayerPrefab.transform.GetChild(1));
		Renderer renderer = PlayerPrefab.transform.GetChild(1).GetComponent<Renderer>();
		Debug.Log("Renderer: " + renderer);
		int randomInt = Random.Range(0, 5);
		renderer.sharedMaterial.SetColor("_Color",colors[randomInt]);
		Debug.Log("Player Object name: ", PlayerPrefab);

		PhotonNetwork.Instantiate(PlayerPrefab.name,PlayerPosition, Quaternion.identity, 0);
		GameCanvas.SetActive(false);
		SceneCamera.SetActive(false);
	//	sce
	}
}
