using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tank : MonoBehaviour
{
    public int level  { get; private set; }
    public int hp     { get; private set; }
    public int armour { get; private set; }
    public int atk    { get; private set; }
    public int speed  { get; private set; }

    public void GetStat(int _level = 0, int _hp=0,int _armour = 0,int _atk = 0, int _speed = 0)
    {
        int[] statArray = new int[] { level, hp, armour, atk, speed };
        int[] statSetArray = new int[] { _level , _hp , _armour , _atk , _speed  };

        for (int i = 0; i < statSetArray.Length; i++)
        {
            if (statSetArray[i] != 0)
            {
                statArray[i] = statSetArray[i];
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ´ÙÀ×ÀÌÆåÆ® Å×½ºÆ®¿ë
    private void SetHPZero()
    {
        
    }

    private void Die()
    {

        Destroy(gameObject);
    }
}
