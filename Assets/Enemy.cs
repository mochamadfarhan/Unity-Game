using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public GameObject projectile;
	public Transform projectilePoint;
	
	AudioSource m_shootingSound;

	void Start()
	{
		m_shootingSound = GetComponent<AudioSource>();
	}
    


	
	public void shoot()
	{
		m_shootingSound.Play();
		Rigidbody rb = Instantiate(projectile, projectilePoint.position, Quaternion.identity).GetComponent<Rigidbody>();
		rb.AddForce(transform.forward * 500f, ForceMode.Impulse);
		rb.AddForce(transform.up * 7, ForceMode.Impulse);
	}
	

}
