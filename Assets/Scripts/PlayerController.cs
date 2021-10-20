using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int playerId = 0;
    public Animator animator;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;
    public GameObject playerPrefab;

    

    // Update is called once per frame
    void Update()
    {



        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        // rb.velocity = new Vector2(movement.x, movement.y);

        transform.position = transform.position + movement * Time.deltaTime;

        AniAndFire();
    }

    /**
     * 
     * PlayÉä»÷
     * *
     * */
    private void AniAndFire()
    {
        if (Input.GetKey("f"))
        {
            Vector2 fireDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            fireDirection.Normalize();

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = fireDirection * 3.0f;
            bullet.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(fireDirection.y, fireDirection.x) * Mathf.Rad2Deg);
            Destroy(bullet, 1.0f);
        }
    }
}
