using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIJoysticks : MonoBehaviour
{
    public Vector3 stickInitPosition;       // –Èƒ‚ª¨∏À≥ı ºªØŒª÷√
	public RectTransform selfTransform;
	public Vector3 originPosition;

    // Start is called before the first frame update
    void Start()
    {
        stickInitPosition = GetComponentInParent<RectTransform>().position;
		
		selfTransform = GetComponentInParent<RectTransform>();
		// originPosition = selfTransform.anchoredPosition;
		
		Debug.Log(11111);
		Debug.Log(stickInitPosition);
		Debug.Log(22222);
		Debug.Log(originPosition);
		Debug.Log(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    { 
		//Debug.Log(transform.anchoredPosition);
    }

    // ”√ªß¥•≈ˆª¨∏À “∆∂Ø
    public void OnDragIng()
    {
		// if (originPosition) {
		// 	originPosition = Input.mousePosition;
		// }
		
        Vector3 offsetPosition =  Input.mousePosition - originPosition;
		
		Debug.Log(offsetPosition);
		
		// transform.position = transform.position + offsetPosition * Time.deltaTime;

		// Debug.Log(333333);
		// Debug.Log(Input.mousePosition);
		
		// Debug.Log(44444);
  //       Debug.Log(transform.position);
		
    }

    public void OnDragEnd()
    {
        transform.position = stickInitPosition;
    }
}
