using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject _dogPrefab, _catPrefab;
    [SerializeField]
    private string _nextScene;

    public void SpawnDog() => Spawn(_dogPrefab);

    public void SpawnCat() => Spawn(_catPrefab);

    private void Spawn(GameObject prefab) {
        var player = Instantiate(prefab);
        DontDestroyOnLoad(player);
        SceneManager.LoadScene(_nextScene);
    }
}
