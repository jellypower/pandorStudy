using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviour에서 상속받고
//접근 지정자가 public인(클래스 외부에서 접근 가능한)
//PlayerMovement라는 이름의 클래스
public class PlayerMovement : MonoBehaviour {

    Vector3 velocity;
    float speed;
    private int hp, maxhp;

    //Start 실행 전 실행
    void Awake()
    {
        maxhp = 100;
    }
    //오브젝트 생성 시 한번 실행
    void Start () {
        velocity = new Vector3(1, 0, 0);
        speed = 7.5f;
        hp = maxhp;
	}
	
    //매 프레임마다 실행, 프레임=60fps -> Update함수는 1/60초에 한번 실행
	void Update () {
        ////좌표 3,3,3 으로 이동
        //transform.position = new Vector3(3, 3, 3);

        ////플레이어 기준으로 3,3,3에 이동
        //transform.Translate(new Vector3(3, 3, 3));

        ////플레이어 위치 -> 목표 좌표로 속도 1로 이동
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(3, 3, 3), 1);

        ////이동
        //transform.position += velocity * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            //Vector3.up=Vector3(0, 1, 0)
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            //Vector3.left=Vector3(-1, 0, 0)
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            //Vector3.down=Vector3(0, -1, 0)
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            //Vector3.right=Vector3(1, 0, 0)
        }
    }
    //Update 실행후 실행
    void FixedUpdate()
    {
    }

    public void BeAttack(int dmg)
    {
        hp -= dmg;
    }
}
