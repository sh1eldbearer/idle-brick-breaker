using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BrickStats : MonoBehaviour
{
    [SerializeField] private int _health;

    [SerializeField] private TMP_Text _healthText;

    [SerializeField] private LayerMask _ballLayer;

    private void Awake()
    {
        _healthText = this.GetComponentInChildren<TMP_Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _healthText.text = _health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D otherCol)
    {
        if (otherCol.gameObject.layer != _ballLayer)
        {
            _health -= 1;
            _healthText.text = _health.ToString();
        }
    }
}
