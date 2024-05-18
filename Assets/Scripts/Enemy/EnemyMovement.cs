using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float seconds = 0.8f;
    [SerializeField] private float speed = 5f;

    private bool _allowToMove;

    private void Start()
    {
        StartCoroutine(MovementEvent());

        float randomAngle = Random.Range(0f, 360f);
        Vector3 direction = new Vector3(Mathf.Cos(randomAngle * Mathf.Deg2Rad), 0f, Mathf.Sin(randomAngle * Mathf.Deg2Rad));
        transform.forward = direction;
    }

    private void Update()
    {
        if (_allowToMove)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    private IEnumerator MovementEvent()
    {
        yield return new WaitForSeconds(seconds);
        _allowToMove = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        float randomAngle = Random.Range(0f, 360f);
        Vector3 direction = new Vector3(Mathf.Cos(randomAngle * Mathf.Deg2Rad), 0f, Mathf.Sin(randomAngle * Mathf.Deg2Rad));
        transform.forward = direction;
    }
}
