using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFader : MonoBehaviour
{
    [SerializeField] private bool _alwaysInvisible = false;
    [Space]
    [SerializeField] private float _fadeDelay = 3f;
    [SerializeField] private float _fadeTime = 1.5f;
    private SpriteRenderer _sRend;

    private void Start()
    {
        _sRend = this.gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(FadeSprite());
    }

    private IEnumerator FadeSprite()
    {
        if (_alwaysInvisible == true)
        {
            _sRend.color = new Color(_sRend.color.r, _sRend.color.g, _sRend.color.b, 0);
            yield break;
        }
        
        yield return new WaitForSeconds(_fadeDelay);

        while (_sRend.color.a > 0)
        {
            _sRend.color = new Color(_sRend.color.r, _sRend.color.g, _sRend.color.b, _sRend.color.a - (_fadeTime * Time.deltaTime));
            yield return null;
        }
    }
}
