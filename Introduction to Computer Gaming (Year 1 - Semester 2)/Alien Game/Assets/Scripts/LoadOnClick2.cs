using UnityEngine;
using System.Collections;

public class LoadOnClick2 : MonoBehaviour 
{
	public GameObject loadingImage;

	public void LoadScence(string level)
	{
		Application.LoadLevel ("Story");
		loadingImage.SetActive (true);

	}
}
