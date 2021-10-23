using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIJoysticks : MonoBehaviour
{
    public Vector3 stickInitPosition;       // ÐéÄâ»¬¸Ë³õÊ¼»¯Î»ÖÃ
	public RectTransform selfTransform;
	public Vector3 originPosition;
	private Vector2 pointOrigin;
	private Vector2 pointEnd;
    bool isTouchStart = false;
    public Transform player;
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        stickInitPosition = GetComponentInParent<RectTransform>().position;

      /*  selfTransform = GetComponentInParent<RectTransform>();
        // originPosition = selfTransform.anchoredPosition;

        Debug.Log(11111);
        Debug.Log(stickInitPosition);
        Debug.Log(22222);
        Debug.Log(originPosition);
        Debug.Log(Input.mousePosition);*/
    }

    // Update is called once per frame
    void Update()
    { 
		if (Input.GetMouseButtonDown(0))
        {
			Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 3.2f, Input.mousePosition.y - 1.5f, Input.mousePosition.z)));
		}

        if (Input.GetMouseButton(0))
        {
            isTouchStart = true;
            pointEnd = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x - 3.2f, Input.mousePosition.y - 1.5f, Camera.main.transform.position.z));
        } else
        {
            isTouchStart = false;
        }
		
    }

    private void FixedUpdate()
    {
        if (isTouchStart)
        {
            Vector2 offset = pointOrigin - pointEnd;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);

            /*           ÒÆ¶¯½ÇÉ«*/
            movePlayer(direction);
            moveCamera(direction);

            transform.position = new Vector2(pointOrigin.x + direction.x, pointOrigin.y + direction.y) * -1;
        } else
        {

        }
    }

    public void movePlayer(Vector2 direction)
    {
        player.Translate(direction * 1.0f * Time.deltaTime);

        SocketManager socketManager = new SocketManager();

        socketManager.SendData("xxxx");
    }

    public void moveCamera(Vector2 direction)
    {
        camera.Translate(direction * 1.0f * Time.deltaTime);

       
    }
}
