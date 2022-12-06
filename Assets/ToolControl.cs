using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolControl : MonoBehaviour
{
    MCcode character;
    public Rigidbody2D rb2d;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 1.2f;

    private void Awake() {
        character = GetComponent<MCcode>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseTool();
        }
    }

    private void UseTool() {
        Vector2 position = rb2d.position + character.movement * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            ToolHit hit = c.GetComponent<ToolHit>();
            if (hit != null)
            {
                hit.Hit();
                break;
            }
        }
    }
}
