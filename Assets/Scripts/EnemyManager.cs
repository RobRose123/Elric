using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : CharacterStats
{
    EnemyLocomationManager enemyLocomationManager;
    bool isPreformingAction;

    [Header("A.I Settings")]
    public float detectionRadius = 20;
    public float maximumDetectionAngle = 50;
    public float minimumDetectionAngle = -50;

    private void Awake()
    {
        enemyLocomationManager = GetComponent<EnemyLocomationManager>(); 
    }

    private void Update()
    {
        HandlerCurrentAction();
    }

    private void HandlerCurrentAction()
    {
        if(enemyLocomationManager.currentTarget == null)
        {
            enemyLocomationManager.HandleDetection();
        }
    }
}


