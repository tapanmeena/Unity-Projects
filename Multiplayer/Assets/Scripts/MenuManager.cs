using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
	public static MenuManager Instance;
	[SerializeField] Menu[] MenuList;

	void Awake()
	{
		Instance = this;
	}

	public void OpenMenu(string menuName)
	{
//		Debug.Log("Menu Name: " + menuName);
		for (int i = 0; i < MenuList.Length; i++)
		{
	//		Debug.Log("MenuLists:" + MenuList[i].name);
			if(MenuList[i].menuName == menuName)
			{
				OpenMenu(MenuList[i]);
			}
			else if(MenuList[i].open)
			{
				CloseMenu(MenuList[i]);
			}
		} 
	}

	public void OpenMenu(Menu _menu)
	{
		for (int i = 0; i < MenuList.Length; i++)
		{
			if (MenuList[i].open)
			{
				CloseMenu(MenuList[i]);
			}
		}
		_menu.Open();
	}

	public void CloseMenu(Menu _menu)
	{
		_menu.Close();
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}