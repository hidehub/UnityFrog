using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TypeButton : MonoBehaviour
{
    [SerializeField] private Text _buttonName;
    [SerializeField] private InputField _target;

    private Button _button;
    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(Do);
    }

    private void Do()
    {
        _target.text = _buttonName.text;
    }
}
