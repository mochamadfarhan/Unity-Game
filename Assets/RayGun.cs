using System.Collections;
using UnityEngine.InputSystem;

using UnityEngine;

public class RayGun : MonoBehaviour
{
    public float shootRate;
    private float m_shootRateTimeStamp;

    public GameObject m_shotPrefab;
	
	
	public int maxAmmo =35;
	


    RaycastHit hit;
    float range = 1000.0f;
	AudioSource m_shootingSound;

	void Start()
	{
		m_shootingSound = GetComponent<AudioSource>();
	}

    void Update()
    {

        if (Input.GetMouseButton(0))
        {
			if( maxAmmo > 0)
			{
            if (Time.time > m_shootRateTimeStamp)
            {
				
				m_shootingSound.Play();
                shootRay();
				maxAmmo--;
                m_shootRateTimeStamp = Time.time + shootRate;
            }
			}
        }

    }

    void shootRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, range))
        {
			EnemyController enemy = hit.transform.GetComponent<EnemyController>();

			if(enemy != null) 
			{
			enemy.die();
			}
            GameObject laser = GameObject.Instantiate(m_shotPrefab, transform.position, transform.rotation) as GameObject;
            laser.GetComponent<ShotBehavior>().setTarget(hit.point);
            GameObject.Destroy(laser, 2f);


        }

    }



}