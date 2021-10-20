using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIJoysticks : MonoBehaviour
{
    public Vector3 stickInitPosition;       // ���⻬�˳�ʼ��λ��

    // Start is called before the first frame update
    void Start()
    {
        stickInitPosition = GetComponentInParent<RectTransform>().position;
    }

    // Update is called once per frame
    void Update()
    { 
   
    }

    // �û��������� �ƶ�
    public void OnDragIng()
    {
        transform.position = Input.mousePosition;

        Debug.Log(Input.mousePosition);
    }

    public void OnDragEnd()
    {
        //transform.position = stickInitPosition;
    }
}
