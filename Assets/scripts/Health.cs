using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth=10f;

    private float curHealth;
    private float _sliderValue;
    private void Awake()
    {
        curHealth = maxHealth;
    }
    public void  Hit (float damage)
    {
        curHealth -= damage;
        if (curHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        gameObject.SetActive(false); 
    }
    private void Update()
    {
        _sliderValue = curHealth / maxHealth;

    }
    private void OnGUI()
    {
        _sliderValue = GUI.HorizontalSlider(new Rect(25, 25, 300, 60), _sliderValue, 0, 1);
    }
}