using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public enum IAState
{
    Idle,               // idle state
    Patrol,             // patrol state
    Stop,               // random stop state
    PlayerNear,         // player near state
    PlayerSeen          // player seen state
}

public class IAController : MonoBehaviour
{
    public bool IsPlayerNear;
    public bool IsPlayerSeen;

    [SerializeField] private Animator _animator;

    private IAState _state;

    private NavMeshAgent _agent;
    private Vector3 _nextDestination;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        CheckTransition();
        Behavior();
    }

    private void CheckTransition()
    {
        if (IsPlayerSeen)
        {
            _state = IAState.PlayerSeen;
            _animator.SetBool("IsPlayerSeen", true);

        }
        else if (IsPlayerNear)
        {
            _state = IAState.PlayerNear;
            _animator.SetBool("IsPlayerNear", true);
        }
        else
        {
            switch (_state)
            {
                case IAState.Idle:
                    // ???
                    break;
                case IAState.Patrol:
                    
                    break;
                case IAState.Stop:

                    break;
                case IAState.PlayerSeen:
                    
                    break;
                case IAState.PlayerNear:
                    break;
                    
            }
        }
    }

    private void Behavior()
    {
        if (_state == IAState.Patrol)
        {
            if (_agent.destination != null && _agent.remainingDistance > 1f)
            {
                SetNextDestination();
            }
        }
    }

    private void SetNextDestination()
    {
        _nextDestination = new Vector3();
        _agent.SetDestination(_nextDestination);
    }

}
