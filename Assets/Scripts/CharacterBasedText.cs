using TMPro;
using UnityEngine;

public class CharacterBasedText : MonoBehaviour
{

    [SerializeField]
    private string _catText, _dogText;
    private TextMeshProUGUI _text => GetComponent<TextMeshProUGUI>();

    private void Start() {
        _text.text = CharacterSelect.IsDog ? _dogText : _catText;
    }
}