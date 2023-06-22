using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_01 : MonoBehaviour
{
    public Character Ability;
    [SerializeField] private Rigidbody2D rb;
    //[SerializeField] private Collider2D Coll;
    public LayerMask Ground;
    public Transform rightpoint, leftpoint, StopPoint;
    [SerializeField] float Speed;
    private float leftx, rightx, stopx;
    public bool Faceleft,Run,Stand;
    public Animator Anim;
    public bool Control = false;
    public Vector3 Mouse;
    
    [SerializeField] private GameObject CharaList01;
    [SerializeField] private GameObject CharaList02;
    [SerializeField] private GameObject CharaList03;
    [SerializeField] private GameObject CharaList04;
    
    public Text ATK;
    public Text DEF;
    public float Life;
    public Text Infection;
    //private float[] MyArray = new float[] { 1.2f, 2.4f, 3.5f, 5.5f };
    public void Start()
    {
        
        //base.Start();
        Anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        transform.DetachChildren();
        rightx = rightpoint.position.x;
        leftx = leftpoint.position.x;
        stopx = StopPoint.position.x;
        Destroy(leftpoint.gameObject);
        Destroy(rightpoint.gameObject);
    }


    public void Update()
    {
       // base.Update();
        //ÈËÎïÍÏ×§
        Vector3 MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0;
        float Distance = (this.gameObject.transform.position - MousePosition).magnitude;
        if (Input.GetMouseButtonDown(0))
        {
            CharaList02.SetActive(false);
            CharaList03.SetActive(false);
            CharaList04.SetActive(false);
            CharaList01.SetActive(true);
            CharacterNum(Ability);
            Run = false;
            if (Distance < 1.5f)
            {
                Control = true;
                Mouse = MousePosition;
            }

        }
        else if (Input.GetMouseButtonUp(0))
        {
            Control = false;
        }
        else if (Control)
        {
            Vector3 DeltaVec = MousePosition - Mouse;
            this.gameObject.transform.position += DeltaVec;
            Mouse = MousePosition;
        }
        else if (!Run)
        {
            Movement();
        }
        /*else if(Run)
        {
            StartCoroutine(Stop());
        }*/
        
    }
    void Movement()
    {
        
        if (Faceleft)
        {
            
            rb.velocity = new Vector2(-Speed, rb.velocity.y);
            if (transform.position.x < leftx)
            {
                transform.localScale = new Vector3(-10, 10, 1);
                Faceleft = false;
                Run =true;
                Stand = true;
                
            }

        }
        else
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
            if (transform.position.x > rightx)
            {
                transform.localScale = new Vector3(10, 10, 1);
                Faceleft = true;
                Run = true;
                Stand = true;
                
            }            
        }

    }
    IEnumerator Stop()
    {
        Stand = false;
        Run = false;
        for (int i = 0; i < 2; i++)
        {
            yield return new WaitForSeconds(10f);
        }
    }
    public void CharacterNum(Character Chara)
    {
        ATK.text= Chara.ATK.ToString();
        DEF.text = Chara.DEF.ToString();
        Life = Chara.life;
        Infection.text = Chara.Infection.ToString();


    }
    
    
}
