using System;
using System.Threading.Tasks;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _rigidbodies;
    
    public bool IsDead { get; private set; }

    private async void Start()
    {
        IsDead = true;
        RagDollKinematic();
        var rand = new System.Random();
        
        await Task.Delay(TimeSpan.FromSeconds(rand.Next(1, 5)));
        IsDead = false;
        RagDollKinematic();
    }
    
    private void RagDollKinematic()
    {
        foreach (var rb in _rigidbodies)
        {
            rb.isKinematic = IsDead;
        }
    }
}