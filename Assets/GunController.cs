using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
	AudioSource m_shootingSound;
    Animator m_animator;
	
	public int maxAmmo =35;

	
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {	
		if(maxAmmo > 0 ){
			
        if(Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Shoot");
			m_shootingSound = GetComponent<AudioSource>();
			maxAmmo--;
		}
		}

	}
	
}
