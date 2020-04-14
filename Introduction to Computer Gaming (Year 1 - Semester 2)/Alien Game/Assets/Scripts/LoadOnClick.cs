using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour 
{
	public GameObject loadingImage;

	public void LoadScence(string level)
	{
		Application.LoadLevel ("Level1");
		loadingImage.SetActive (true);

	}
}
