using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
	public GameObject Manager;
	void Start(){
		
	}
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag =="Player")
        {
			
			Manager.GetComponent<Load>().LoadLevel(2);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
