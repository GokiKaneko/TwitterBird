using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Xconroll : MonoBehaviour
{
    [SerializeField] float m_moveSpeed = 1f;
    [SerializeField]private float rotateX = 0;

    [SerializeField]private float rotateY = 0;

    [SerializeField]private float rotateZ = 0;
    private void Start()
    {
       
    }

    void Update()
    {
        // ������x���ɍs������
        if (this.transform.position.x < -10f)
        {
            // �������g��j������
            Destroy(this.gameObject);
        }

        // ��葬�x�ō��ɓ�����
        this.transform.Translate(Vector2.left * m_moveSpeed * Time.deltaTime);
        gameObject.transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("rizaruto");
        }

    }
}