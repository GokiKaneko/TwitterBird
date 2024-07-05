using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X : MonoBehaviour
{
    /// <summary>壁として生成するプレハブ</summary>
    [SerializeField] GameObject[] m_wallPrefabs = null;
    /// <summary>壁を生成する間隔（秒）</summary>
    [SerializeField] float m_XGenerateInterval = 60f;
    /// <summary>壁生成間隔を計るためのタイマー（秒）</summary>
    float m_timer = 0;

    void Start()
    {
        // 実行したら最初の壁がすぐ生成されるようにタイマーに値を入れておく
        m_timer = m_XGenerateInterval;
    }

    void Update()
    {
        m_timer += Time.deltaTime;

        // タイマーの値が生成間隔を超えたら
        if (m_timer > m_XGenerateInterval)
        {
            m_timer = 0f;   // タイマーをリセットする
            float RandamY = Random.Range(-4, 4);   
            GameObject go = Instantiate(m_wallPrefabs[0]);  // プレハブからオブジェクトを生成して、変数 go に入れる
            go.transform.position = new Vector2(10f, RandamY);   // 生成したオブジェクトの位置を定める
        }
    }
    
}
