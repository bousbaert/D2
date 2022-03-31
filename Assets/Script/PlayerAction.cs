using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public string currentMapName;// transferMap 스크립트에 있는 transferMap 변수의 값을 저장
    static public PlayerAction instance;
    public GM manager;
    public float Speed;
    float h;
    float v;
    bool isHorizonMove;
    Rigidbody2D rigid;
    Animator anim;
    Vector3 dirVec;
    GameObject scanObject;

    void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            rigid = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    void Update()
    {
        h =manager.isAciton ? 0 : Input.GetAxisRaw("Horizontal");
        v =manager.isAciton ? 0 : Input.GetAxisRaw("Vertical");

        bool hDown = manager.isAciton ? false:Input.GetButtonDown("Horizontal");
        bool vDown = manager.isAciton ? false : Input.GetButtonDown("Vertical");
        bool hUp = manager.isAciton ? false : Input.GetButtonUp("Horizontal");
        bool vUp = manager.isAciton ? false : Input.GetButtonUp("Vertical");

        if (hDown||vUp)
            isHorizonMove = true;
        else if (vDown||hUp)
            isHorizonMove = false;

        if (anim.GetInteger("hAxisRaw") != h)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("hAxisRaw", (int)h);
        }
        else if (anim.GetInteger("vAxisRaw") != v)
        {
            anim.SetBool("isChange", true);
            anim.SetInteger("vAxisRaw", (int)v);
        }
        else
        {
            anim.SetBool("isChange", false);
        }


        if (vDown && v == 1)
            dirVec = Vector3.up;
        else if (vDown && v == -1)
            dirVec = Vector3.down;
        else if (hDown && v == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;

        if (Input.GetButtonDown("Jump") && scanObject != null)
            manager.Action(scanObject);
    }
     void FixedUpdate()
    {
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity =moveVec*Speed;

        Debug.DrawRay(rigid.position, dirVec * 0.7f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 0.7f, LayerMask.GetMask("Object"));

        if (rayHit.collider != null)
        {
            scanObject = rayHit.collider.gameObject;
        }
        else
            scanObject = null;
    }
}
