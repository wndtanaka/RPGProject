using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class Enemy : MonoBehaviour
{
    float currentHealthPoints = 100f;
    [SerializeField]
    float maxHealthPoints = 100f;
    float attackRadius = 10;

    AICharacterControl aiCharacterControl = null;
    GameObject player;

    private void Start()
    {
        aiCharacterControl = GetComponent<AICharacterControl>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= attackRadius)
        {
            aiCharacterControl.SetTarget(player.transform);
        }
        else
        {
            aiCharacterControl.SetTarget(transform);
        }
    }

    public float healthAsPercentage
    {
        get { return currentHealthPoints / (float)maxHealthPoints; }
    }
}
