using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private GameObject player;
    public GameObject Bullet;
    private GameObject myBullet;

    private int hp,hpMax;

    private float shootCool = 10.0f;
    private float shootTimer = 0;
    private float shootinterv = 0.5f;

    void Start () {
        hpMax = 100;
        hp = hpMax;
	}
	
	void Update () {

        if (shootTimer <= 0)
        {
            player = GameObject.Find("Player");
            myBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            myBullet.GetComponent<Bullet>().SetDirection(player.transform.position - transform.position, 15);
            myBullet.GetComponent<EBullet>().SetBulletAtk(10);
            shootTimer = shootCool;
        }
        shootTimer -= shootinterv;

        if (hp <= 0) die();
    }

    public void BeAttack(int dmg)
    {
        hp -= dmg;
    }

    private void die()
    {
        Debug.Log(this + ",died");
        Destroy(gameObject);
    }
}
