using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
	public GameObject loadingScreen;
	public Slider slider;
	public void LoadLevel (int sceneIndex){
		
		StartCoroutine(LoadAsynchronously(sceneIndex));
	}
	
	IEnumerator LoadAsynchronously (int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
		
		loadingScreen.SetActive(true);
		
		while (!operation.isDone)
		{
			float progress = Mathf.Clamp01(operation.progress / .9f);
			slider.value = progress;
			
			yield return null;
		}
	}
}
