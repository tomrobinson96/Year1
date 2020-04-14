using UnityEngine;
using System.Collections;

public class LoadOnClick1 : MonoBehaviour 
{
	public GameObject loadingImage;

	public void LoadScence(string level)
	{
		Application.LoadLevel (0);
		loadingImage.SetActive (true);

	}
}
