using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBasedSound : MonoBehaviour
{
    [SerializeField]
    private AudioClip _catSound;
    [SerializeField]
    private AudioClip _dogSound;

    private void Start() {
        GetComponent<AudioSource>().clip = CharacterSelect.IsDog ? _dogSound : _catSound;
    }
}
