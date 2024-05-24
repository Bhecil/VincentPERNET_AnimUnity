using UnityEngine;

public class IAPerception : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Transform _pawn;
    [SerializeField] private float _range;

    private Vector3 _direction;

    private void CheckDistance()
    {
        _direction = _player.position - _pawn.position;
        
        RaycastHit hit;

        if (Physics.Raycast(_pawn.position, _direction, out hit, _range))
        {
            if (hit.collider.gameObject.GetComponent<PlayerController>())
            {
                _pawn.GetComponentInChildren<IAController>().IsPlayerNear = true;
            }
            else
            {
                _pawn.GetComponentInChildren<IAController>().IsPlayerNear = false;
            }
        }
        else
        {
            _pawn.GetComponentInChildren<IAController>().IsPlayerNear = false;
        }

    }
}
