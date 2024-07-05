using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GameMgr : MonoBehaviour
{
    public GameObject score_object = null; 
    public int score_num = 0;
    
    void Start()
    {
    }

    
    void FixedUpdate()
    {
        
        Text score_text = score_object.GetComponent<Text>();
        
        score_text.text = "ÉtÉHÉçÉèÅ[:" + score_num;

        score_num += 1; 
    }
    
}