using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //unity component
    protected Rigidbody2D rigidBody;
    protected Animator animator;
    //character property
    protected float attack;
	protected float critAttack;
	protected float critAttackRate;
    protected float attackCD;
    protected float attakRange;
    protected float damage;
    protected float defense;
    protected float maxHealth;
    protected float currentHealth;
    protected float maxSpeed;
    protected float speed;

    protected bool isFacingRight;
    //character action
    protected abstract void move();
    protected abstract void jump();
    protected abstract void addAttack();
    protected abstract void addDamage();
	
	void Awake()
	{
        rigidBody = GetComponent<Rigidbody2D>();
    }
    protected virtual void dead()
	{
        Destroy(this);
    }

	protected void overturn()
	{
		isFacingRight = !isFacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
