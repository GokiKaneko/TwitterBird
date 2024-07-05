using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField]
    float JUMP_VELOCITY = 1000; // �W�����v�͂̒�`

    Rigidbody2D _rigidbody; 

    
    void Start()
    {
        // ���������R���|�[�l���g���擾
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Space�L�[���������̂ŃW�����v����
            _rigidbody.velocity = Vector2.zero; // �������x����x���Z�b�g����
            _rigidbody.AddForce(new Vector2(0, JUMP_VELOCITY)); // ������ɗ͂�������
        }
    }

    
    private void FixedUpdate()
    {

        Vector3 position = transform.position;
        // ��ʊO�ɏo�Ȃ��悤�ɂ���
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

    // ��ʏ���擾����
    float GetTop()
    {
        // ��ʂ̉E��̃��[���h���W���擾����
        Vector2 max = Camera.main.ViewportToWorldPoint(Vector2.one);
        return max.y;
    }

    // ��ʉ����擾����
    float GetBottom()
    {
        // ��ʂ̍����̃��[���h���W���擾����
        Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        return min.y;
    }
}
