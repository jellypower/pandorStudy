using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector3 dir;
    public float speed;

	void Awake () {
        dir = Vector3.zero;
        speed = 0;
    }
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Mathf.Sign(dir.y) * Vector3.Angle(Vector3.right, dir) + 180));
    }

    void Update () {
        transform.position += dir * speed * Time.deltaTime;
	}

    public void SetDirection(Vector3 setdir, float setspeed)
    {
        this.dir = setdir.normalized;
        this.speed = setspeed;
    }
}
