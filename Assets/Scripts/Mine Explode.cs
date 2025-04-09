/*Hudson Ream
 * 4/4/2025
 * does everything needed to make the mine work
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplode : MonoBehaviour
{
    private Animator Animator;
    private SpriteRenderer thisSR;
    private Collider2D thisCollider;
    public float knockbackrad;
    public float damagerad;
    public uint damageamount;
    public float knockback;
    public AudioSource audioSource;
    public AudioClip explosionsound;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        thisSR = GetComponent<SpriteRenderer>();
        thisCollider= GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Animator.SetBool("Is Touched", true);
        damageAndKnockback();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Animator.SetBool("Is Touched", true);
        damageAndKnockback();
    }

    public void Delete()
    {
        thisSR.sprite = null;
        Destroy(gameObject);
    }
    void damageAndKnockback()
    {
        Collider2D[] Colliders;
        Colliders = Physics2D.OverlapCircleAll(thisCollider.bounds.center, knockbackrad);
        foreach (Collider2D col in Colliders)
        {
            if (col.GetComponent<Rigidbody2D>() != null && col.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
            {
                col.GetComponent<Rigidbody2D>().velocity += new Vector2(col.transform.position.x - transform.position.x, col.transform.position.y - transform.position.y).normalized * knockback;
            }
        }
        Colliders = Physics2D.OverlapCircleAll(thisCollider.bounds.center, damagerad);
        foreach (Collider2D col in Colliders)
        {
            if (col.GetComponent<Health>() != null && col.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
            {
                col.GetComponent<Health>().Damage(damageamount, transform.tag);
            }
        }
        audioSource.PlayOneShot(explosionsound);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(thisCollider.bounds.center, damagerad);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(thisCollider.bounds.center, knockbackrad);
    }
}   
