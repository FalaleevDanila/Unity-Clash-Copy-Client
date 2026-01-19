using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "_NavMeshMove", menuName = "UnitState/NavMeshMove")]
public class NawMeshMove : UnitState
{
    [SerializeField] private bool _isEnemy;
    [SerializeField] private float _moveOffset = 1f;
    private NavMeshAgent _agent;
    private Vector3 _targetPosition;

    public override void Init()
    {
        Vector3 unitPosition = _unit.transform.position;
        _targetPosition = MapInfo.Instance.GetNearestTowerPosition(in unitPosition, _isEnemy == false);

        _agent = _unit.GetComponent<NavMeshAgent>();
        _agent.SetDestination(_targetPosition);
    }


    public override void Run()
    {
        float distanceToTarget = Vector3.Distance(_unit.transform.position, _targetPosition);
        if (distanceToTarget <= _moveOffset)
        {
            _unit.SetState(UnitStateType.Attack);
        }
    }

    public override void Finish()
    {
        _agent.isStopped = true;
    }

}
