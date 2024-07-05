using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]
    float JUMP_VELOCITY = 1000; // ジャンプ力の定義

    Rigidbody2D _rigidbody; 

    
    void Start()
    {
        // 物理挙動コンポーネントを取得
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spaceキーを押したのでジャンプ処理
            _rigidbody.velocity = Vector2.zero; // 落下速度を一度リセットする
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY)); // 上方向に力を加える
        }
    }

    
    private void FixedUpdate()
    {

        Vector3 position = transform.position;
        // 画面外に出ないようにする
        float y = transform.position.y;
        float vx = _rigidbody.velocity.x;
        if (y > GetTop())
        {
            _rigidbody.velocity = Vector2.zero; 
            position.y = GetTop(); 
        }
        if (y < GetBottom())
        {
           
            _rigidbody.velocity = Vector2.zero; 
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY));
            position.y = GetBottom(); 
        }

        
        transform.position = position;
    }

    // 画面上を取得する
    float GetTop()
    {
        // 画面の右上のワールド座標を取得する
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        return max.y;
    }

    // 画面下を取得する
    float GetBottom()
    {
        // 画面の左下のワールド座標を取得する
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        return min.y;
    }
}
