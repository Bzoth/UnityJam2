
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 3;
    [SerializeField] private float rotationSpeed;

    private Rigidbody2D rb;
    private PlayerAwareness playerAwareness;
    private Vector2 targetDirection;
    private float changeDirectionCooldown;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAwareness = GetComponent<PlayerAwareness>();
        targetDirection =transform.up;
    }

    private void FixedUpdate()
    {
        UpdateTargetDirection();
        RotateTowardsTarget();
        SetVelocity();
    }

    private void UpdateTargetDirection()
    {
        HandleRandomDirectionChange();
        HandlePlayerTargeting();
    }

    private void HandleRandomDirectionChange()
    {
        changeDirectionCooldown -= Time.deltaTime;

        if (changeDirectionCooldown <= 0)
        {
            float angleChange = Random.Range(-90f, 90f);
            Quaternion rotation = Quaternion.AngleAxis(angleChange, transform.forward);
            targetDirection = rotation * targetDirection;
            changeDirectionCooldown = Random.Range(1f, 5f);
        }
    }

    private void HandlePlayerTargeting()
    {
        if(playerAwareness.AwareOfPlayer)
        {
            targetDirection = playerAwareness.DirectionToPlayer;
        }
    }
    private void RotateTowardsTarget()
    {
        
        Quaternion targetRotation = Quaternion.LookRotation(transform.forward, targetDirection);
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed *  Time.deltaTime);

        rb.SetRotation(rotation);
    }
    private void SetVelocity()
    {
        rb.velocity =transform.up * speed;
    }
    

}
