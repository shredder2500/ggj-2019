using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    private GameObject _player;
    private NavMeshAgent _agent => GetComponent<NavMeshAgent>();
    private Animator _animatior => _player.GetComponent<Animator>();
    [SerializeField]
    private LayerMask WalkableLayer;

    private void Start() {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() 
    {
        if (Input.GetMouseButtonDown(0)) {
            ProcessMouseClick();
        }
    }

    private void LateUpdate() {
        _player.transform.position = transform.position;
        _animatior.SetBool("moving", _agent.velocity.sqrMagnitude > 0);
    }

    private void ProcessMouseClick() {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100, WalkableLayer)) {
            _agent.SetDestination(hit.point);
            Rotation(hit.point.x);
        }
    }

    private void Rotation(float hitX) {
        var rScale = hitX < _player.transform.position.x ? -1 : 1;
        var scale = _player.transform.localScale;

        _player.transform.localScale = new Vector3(rScale, scale.y, scale.z);
    }
}
