using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeState : IEnemyState
{
    private Enemy_1 enemy;

    private float attackTimer;

    private float attackCooldown = 3;

    private bool canAttack = true;

    public void Enter(Enemy_1 enemy)
    {
        this.enemy = enemy;
    }

    public void Execute()
    {
        Attack();
        //if (enemy.InThrowRange && !enemy.InMeleeRange)/*16.5 25:13*/
        //{
        //    enemy.ChangeState(new RangedState());
        //}
        //if (enemy.InMeleeRange)
        //{
        //    enemy.ChangeState(new MeleeState());/*16.5 21:02*/
        //}
        if (enemy.Target==null)
        {
            enemy.ChangeState(new IdleState());
        }
        if (enemy.Target != null)
        {
            enemy.Move();
        }
        else
        {
            enemy.ChangeState(new IdleState());
        }
    }

    public void Exit()
    {
        
    }

    public void OnTriggerEnter(Collider2D other)
    {
        
    }

    private void Attack()
    {
        attackTimer += Time.deltaTime;

        if (attackTimer >= attackCooldown)
        {
            canAttack = true;
            attackTimer = 0;
        }

        if (canAttack)
        {
            canAttack = false;
            enemy.MyAnimator.SetTrigger("attack");
        }
    }
}
