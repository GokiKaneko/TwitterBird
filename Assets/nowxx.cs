using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class nowxx : MonoBehaviour
{
    
    public GameObject nowX;
    
    
    float _timer = 0;
    
    float _totalTime = 0;
    
    int _cnt = 0;

    void Start()
    {
    }

    void Update()
    {
        
        _timer -= Time.deltaTime;
        
        _totalTime += Time.deltaTime;

        if (_timer < 0)
        {
            
            Vector3 position = transform.position;
           
            position.y = Random.Range(-4, 4);
          
            float speed = 100 + (_totalTime * 10);
            
            if (position.x < GetLeft())
            {
                Destroy(gameObject); 
            }
        }
    }
     float GetLeft() {
    Vector2 min = Camera.main.ViewportToWorldPoint(Vector2.zero);
    return min.x;
  }
}
