using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    static public MainCamera instance;
    public GameObject player;
    public float speed;
    private Vector3 playerPosition;
    public BoxCollider2D bound;

    private Vector3 minBound; // 박스 컬라이더 영역의 최소 최대 xyz값을 지님
    private Vector3 maxBound;

    private float halfWidth;  // 카메라의 반너비, 반높이 값을 지닐 변수
    private float halfHeight;

    private Camera theCamera;   // 카메라의 반높이값을 구할 속성을 이용하기 위한 변수

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    void Start()
    {
        theCamera = GetComponent<Camera>();
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
        halfHeight = theCamera.orthographicSize;
        halfWidth = halfHeight * Screen.width / Screen.height;
    }

    private void Update()
    {
        if (player.gameObject != null)
        {
            playerPosition.Set(player.transform.position.x, player.transform.position.y, this.transform.position.z);
            this.transform.position = Vector3.Lerp(this.transform.position, playerPosition, speed * Time.deltaTime);

            float clampedX = Mathf.Clamp(this.transform.position.x, minBound.x + halfWidth, maxBound.x - halfWidth);
            float clampedY = Mathf.Clamp(this.transform.position.y, minBound.y + halfHeight, maxBound.y - halfHeight);

            this.transform.position = new Vector3(clampedX, clampedY, this.transform.position.z);
        }
    }
    public void SetBound(BoxCollider2D newBound)
    {
        bound = newBound;
        minBound = bound.bounds.min;
        maxBound = bound.bounds.max;
    }
}


