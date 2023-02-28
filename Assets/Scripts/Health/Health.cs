using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;
    [Header("iFrames")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private float numberOfFlashes;

    private SpriteRenderer sprite;
    private Animator anim;
    private bool death;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
        if (currentHealth > 0)
        {
            anim.SetTrigger("Hurt");
            StartCoroutine(Invunerability());
        }
        else
        {
            if (!death)
            {
                anim.SetTrigger("Death");
                //player
                if (GetComponent<HeroKnight>() != null)
                    GetComponent<HeroKnight>().enabled = false;
                //enemy
                if (GetComponentInParent<EntityPatrol>() != null)
                    GetComponentInParent<EntityPatrol>().enabled = false;
                if (GetComponent<Entity>() != null)
                    GetComponent<Entity>().enabled = false;
                death = true;
            }
        }
    }
    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
    public void Respawn()
    {
        death = false;
        AddHealth(startingHealth);
        anim.ResetTrigger("Death");
        anim.Play("Idle");
        GetComponent<HeroKnight>().enabled = true;
    }
    private IEnumerator Invunerability()
    {
        Physics2D.IgnoreLayerCollision(10, 11, true);
        for (int i = 0; i < numberOfFlashes; i++)
        {
            yield return new WaitForSeconds(iFramesDuration);
        }
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }
}