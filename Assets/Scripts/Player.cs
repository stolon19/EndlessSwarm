using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float movementSpeed = 3f;
    private Vector2 axis;
    private BoxCollider2D boxCollider;
    public HealthBar HPBar;

    public int MaxHP = 100;
    private int CurrentHP;

    private void Start()
    {
        CurrentHP = MaxHP;
        HPBar.SetMaxHP(MaxHP);
        HPBar.SetHPText(CurrentHP, MaxHP);

        boxCollider = GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDmg(10);
        }
    }

    private void FixedUpdate()
    {
        //get position
        axis.x = Input.GetAxisRaw("Horizontal");
        axis.y = Input.GetAxisRaw("Vertical");

        //move the character
        rigid.MovePosition(rigid.position + axis * movementSpeed * Time.fixedDeltaTime);

        //change the direction the sprite is facing based on whats pressed
        if (axis.x > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }
        else if (axis.x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
    }

    void TakeDmg(int dmg)
    {
        if (CurrentHP > dmg)
        {
            CurrentHP -= dmg;
        } 
        else
        {
            CurrentHP = 0;
        }
        
        HPBar.SetHP(CurrentHP);
        HPBar.SetHPText(CurrentHP, MaxHP);
    }
}
