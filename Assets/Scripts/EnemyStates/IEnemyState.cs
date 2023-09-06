using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    void Execute();

    void Enter(Enemy_1 enemy);

    void Exit();

    void OnTriggerEnter(Collider2D other);
}
