using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    public static int playerHP=100;
	public TextMeshProUGUI playerHPText,ammo;
	public GameObject Blood;
	public GameObject GameOverUI;
	public static int maxAmmo = 35;
	

	
	
	public static bool isGameOver;
	
    void Start()
    {
		playerHP= 100;
		playerHPText.text = "+" + playerHP;
        isGameOver = false;
		maxAmmo = 35;

		
    }

    // Update is called once per frame
    void Update()
    {
		playerHPText.text = "+" + playerHP;
		ammo.text = maxAmmo.ToString();
        if (isGameOver)
		{
			GameOverUI.SetActive(true);
			Time.timeScale = 0f;
			Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
			//SceneManager.LoadScene("Menu");
		}
		
		if(maxAmmo > 0 ){
        if(Input.GetMouseButtonDown(0))
        {
			maxAmmo--;
		}
		}
    }
	public IEnumerator TakeDamage(int damageAmount)
	{
		Blood.SetActive(true);
		playerHP -= damageAmount;
		Debug.Log(playerHP);
		if (playerHP <= 0)
			isGameOver = true;
		
		yield return new WaitForSeconds(1.5f);
		Blood.SetActive(false);
	}
	
	public void kemenu()
	{
		SceneManager.LoadScene("Menu");
	}
	
	public void ammoo()
	{
		
	}


}
