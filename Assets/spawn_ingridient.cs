using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class spawn_ingridient : MonoBehaviour
{
    public bool isspawned = false;
    public int quiality;
    public GameObject CurrentGameObject;
    public GameObject[] ingridient;
    int chance;
    public float timer,cooldown;
    void Start()
    {   

    }
    private void Awake()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            respawn();
        }
    }
    void respawn()
    {
        
        chance = Random.Range(1, 101);
        switch (quiality)
        {
            case 0:
                if (chance <= 90)
                {
                    finalspawn(1);

                }
                else if (chance >= 91 && chance! > 98)
                {
                    finalspawn(2);
                }
                else if (chance >= 99)
                {
                    finalspawn(3);
                }
                break;
            case 1:
                if (chance <= 30)
                {
                    finalspawn(1);
                }
                else if (chance >= 31 && chance! > 91)
                {
                    finalspawn(2);
                }
                else if (chance >= 92)
                {
                    finalspawn(3);
                }
                break;
            case 2:
                finalspawn(3);
                break;
        }
    }
    int RollIngridient(int rare)
    {
        var a = ingridient.Where(p => p.gameObject.GetComponent<type>().typeobject == rare);
        return Random.Range(0, a.Count());
    }
    void finalspawn(int rare)
    {
        Instantiate(ingridient[RollIngridient(rare)], CurrentGameObject.transform);
    }
  
}
