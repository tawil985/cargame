using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float speed = 0;  //Speed�ܼƥΨӳ]�w���ʪ��t��
    Vector2 startPos; //startPos�ܼƥΨӰO���}�l�I���ƹ��ɪ�X�y�лPY�y��

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition; 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength / 500.0f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}
