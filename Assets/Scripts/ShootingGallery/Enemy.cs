using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _rigidbodies;
    
    public bool IDead { get; private set; }

    private void Start()
    {
        RagDollKinematic();
    }
    
    private void RagDollKinematic()
    {
        foreach (var rb in _rigidbodies)
        {
            rb.isKinematic = !IDead;
        }
    }
}