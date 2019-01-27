using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private string _startScene;
    [SerializeField]
    private UnityEvent _onEscape;
    private bool _restarting = false;
    public void Quit() => Application.Quit();

    public void Restarting() => _restarting = true;

    public void Restart() {
        if (!_restarting) return;
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        SceneManager.LoadScene(_startScene);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            _onEscape.Invoke();
        }
    }
}
