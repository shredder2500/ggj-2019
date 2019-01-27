using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public static bool IsDog { get; private set; }

    [SerializeField]
    private GameObject _dogPrefab, _catPrefab;
    [SerializeField]
    private string _nextScene;

    public void SpawnDog() => Spawn(_dogPrefab);

    public void SpawnCat() => Spawn(_catPrefab);

    private void Spawn(GameObject prefab) {
        IsDog = prefab == _dogPrefab;
        var player = Instantiate(prefab);
        DontDestroyOnLoad(player);
        SceneManager.LoadScene(_nextScene);
    }
}
