using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    private float vInput;

    public float hInput;

    public SpriteRenderer spriteRenderer;

    public Sprite livingRabbit;

    public Sprite deadRabbit;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 9f;

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = livingRabbit;
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");

        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * vInput);

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * hInput);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Snek"))
        {
            moveSpeed = 0;
            LoseLife();
        }
        StartCoroutine(RespawnCoroutine());
    }

    public void LoseLife()
    {
        GameManager.lives--;
        spriteRenderer.sprite = deadRabbit;
    }

    private IEnumerator RespawnCoroutine()
    {
        yield return new WaitForSeconds(3);
        RespawnPlayer();
    }

    public void RespawnPlayer()
    {
        Vector2 randomPosition = new Vector2(Random.Range(-14f, 14f), Random.Range(-5f, 5f));
        transform.position = randomPosition;
        spriteRenderer.sprite = livingRabbit;
        moveSpeed = 9f;
    }
}
