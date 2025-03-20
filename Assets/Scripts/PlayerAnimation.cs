using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    /**
     * 
     */
    private readonly int _flashingPeriod = 10;
    private readonly int _numberOfFlashes = 5;

    private int _timer;
    private bool _invincible = false;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        if (!_invincible)
            return;

        
        if (Flash())
        {
            _timer++;
        }

    }

    /**
     * <summary>
     *      Starts the blinking animation process if currently vulnerable and becomes invulnerable during the animation.
     * </summary>
     * <returns>
     *      true if currently vulnerable <br/>
     *      false if currently invulnerable
     * </returns>
     */
    public bool LoseHealth()
    {
        if (!_invincible) 
        {
            _invincible = true;
            return true;
        } else
        {
            return false;
        }
        
    }
    /**
     * 
     */
    private void Reset()
    {
        _invincible = false;
        _timer = 0;
    }

    private bool Flash()
    {
        int trueNumberOfFlashes = 2 * _numberOfFlashes + 1;
        for (int i = 0; i < trueNumberOfFlashes; i++)
        {
            if (_timer == i * _flashingPeriod)
            {
                SwitchState();
            }
            if(_timer == (trueNumberOfFlashes - 1) * _flashingPeriod)
            {
                Reset();
                return false;
            }
        }
        return true;
    }

    private void SwitchState()
    {
        _spriteRenderer.enabled = !_spriteRenderer.enabled;
    }
}
