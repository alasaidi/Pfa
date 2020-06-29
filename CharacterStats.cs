using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterStats : MonoBehaviour
{
    #region Singleton
    public static CharacterStats instance;
        private void Awake()
    {
        instance = this;
    }
    #endregion
    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void TakeDamage(int damage )
    {
        currentHealth -= damage;
        if (currentHealth <=0)
        {
            death();
        }
    }
    public void ModifiyHealth(int Healthmodi)
    {
        currentHealth += Healthmodi;
        Debug.Log(currentHealth);
    }
    public void death()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
    }
 }
