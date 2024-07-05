using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{
    /// <summary>�ǂƂ��Đ�������v���n�u</summary>
    [SerializeField] GameObject[] m_wallPrefabs = null;
    /// <summary>�ǂ𐶐�����Ԋu�i�b�j</summary>
    [SerializeField] float m_XGenerateInterval = 60f;
    /// <summary>�ǐ����Ԋu���v�邽�߂̃^�C�}�[�i�b�j</summary>
    float m_timer = 0;

    void Start()
    {
        // ���s������ŏ��̕ǂ��������������悤�Ƀ^�C�}�[�ɒl�����Ă���
        m_timer = m_XGenerateInterval;
    }

    void Update()
    {
        m_timer += Time.deltaTime;

        // �^�C�}�[�̒l�������Ԋu�𒴂�����
        if (m_timer > m_XGenerateInterval)
        {
            m_timer = 0f;   // �^�C�}�[�����Z�b�g����
            float RandamY = Random.Range(-4, 4);   
            GameObject go = Instantiate(m_wallPrefabs[0]);  // �v���n�u����I�u�W�F�N�g�𐶐����āA�ϐ� go �ɓ����
            go.transform.position = new Vector2(10f, RandamY);   // ���������I�u�W�F�N�g�̈ʒu���߂�
        }
    }
    
}
