using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorManager : AnimatorManager
{
    EnemyLocomationManager enemyLocomationManager;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        enemyLocomationManager = GetComponentInParent<EnemyLocomationManager>();
    }

    private void OnAnimatorMove()
    {
        float delta = Time.deltaTime;
        enemyLocomationManager.enemyRigidbody.drag = 0;
        Vector3 deltaPosition = anim.deltaPosition;
        deltaPosition.y = 0;
        Vector3 velocity = deltaPosition / delta;
        enemyLocomationManager.enemyRigidbody.velocity = velocity;
    }
}
