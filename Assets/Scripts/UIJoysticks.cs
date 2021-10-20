using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIJoysticks : MonoBehaviour
{
    public Vector3 stickInitPosition;       // 虚拟滑杆初始化位置

    // Start is called before the first frame update
    void Start()
    {
        stickInitPosition = GetComponentInParent<RectTransform>().position;
    }

    // Update is called once per frame
    void Update()
    { 
   
    }

    // 用户触碰滑杆 移动
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
