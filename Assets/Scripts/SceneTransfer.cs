using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    [SerializeField]
    private string _scene;
    private bool _transfer = false;

    public void ReadyTransfer(bool state) => _transfer = state;

    public void Transfer() {
        if (!_transfer) return;

        SceneManager.LoadScene(_scene);
    }
}