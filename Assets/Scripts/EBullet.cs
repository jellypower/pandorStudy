using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBullet : MonoBehaviour {
    
    private int atk;

	void Awake () {
        atk = 0;
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerMovement>().BeAttack(atk);
            Destroy(gameObject);
        }
        else if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    public void SetBulletAtk(int setatk)
    {
        atk = setatk;
    }
}
