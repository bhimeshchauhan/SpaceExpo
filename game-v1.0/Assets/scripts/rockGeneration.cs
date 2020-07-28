using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockGeneration : MonoBehaviour
{
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;
    public GameObject rock4;
    public GameObject rock5;
    public GameObject rock6;
    public GameObject rock7;
    private static List<GameObject> rockesAssortments;
    private float random;

    float getRandom()
    {
        random =  Random.Range(-1000.0f, 1000.0f);
        if (random < 0) 
        {
            random -= 100;
        }
        else 
        {
            random += 100;
        }
        return random;
    }

    // Start is called before the first frame update
    void Start()
    {
        rockesAssortments =  new List<GameObject> {rock1, rock2, rock3, rock4, rock5, rock6, rock7};
        Cursor.visible = false;
        for (int i = 0; i < 100; i++) 
        {
            int index = Random.Range(0, rockesAssortments.Count);
            Instantiate(rockesAssortments[index], new Vector3(getRandom(), getRandom(), getRandom()), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
