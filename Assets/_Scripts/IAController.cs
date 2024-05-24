using UnityEngine;

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

        }
    }

}
