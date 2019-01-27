using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
    private GameObject _player =>  GameObject.FindGameObjectWithTag("Player");
    private NavMeshAgent _agent => GetComponent<NavMeshAgent>();
    private Animator _animatior => _player.GetComponent<Animator>();
    [SerializeField]
    private LayerMask WalkableLayer;
    [SerializeField]
    private UnityEvent _onClick;

    private bool InputEnabled = true;
    public bool CanClick => InputEnabled;

    public void ToggleInput(bool state) => InputEnabled = state;


    private void Update() 
    {
        if (!_player || !InputEnabled) return;
        if (Input.GetMouseButtonDown(0)) {
            ProcessMouseClick();
        }
    }

    private void LateUpdate() {
        if (!_player) return;
        _player.transform.position = transform.position;
        _animatior.SetBool("moving", _agent.velocity.sqrMagnitude > 0);
    }

    private void ProcessMouseClick() {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100, WalkableLayer)) {
            _onClick.Invoke();
            _agent.SetDestination(hit.point);
            Rotation(hit.point.x);
        }
    }

    private void Rotation(float hitX) {
        var rScale = hitX < _player.transform.position.x ? -1 : 1;
        var scale = _player.transform.localScale;

        _player.transform.localScale = new Vector3(rScale, scale.y, scale.z);
    }

    public void SetTarget(Transform pos) {
        if (!_player) return;
        _agent.SetDestination(pos.position);
        Rotation(pos.position.x);
    }

    public void Trigger(string animTrigger) => _animatior?.SetTrigger(animTrigger);
}
