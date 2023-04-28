using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinckPosox : MonoBehaviour
{
    public Color[] _colors;    // ������ ������, ������� ����� ������������ ��� �����������
    public float _speed;       // �������� �����������
    private int _currentColor; // ������ �������� ����� �� �������
    MeshRenderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _currentColor = 0; 
    }

    private void Update() {     
        
        _renderer.material.color = Color.Lerp(_renderer.material.color, _colors[_currentColor], Time.deltaTime * _speed);
        _currentColor++;

        if (_currentColor >= _colors.Length)
        {
            _currentColor = 0;
        }
    }
}
