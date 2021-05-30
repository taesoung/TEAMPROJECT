using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterInfo", menuName = "Monster/MonsterInfo")]
public class MonsterInfo : ScriptableObject
{

    [SerializeField] int ID;

    [SerializeField] int HP;

    [SerializeField] int DiaDrop;

    public int MyHP { get { return HP; } set { HP = value; } }
    public int MyDiaDrop { get { return DiaDrop; } set { DiaDrop = value; } }
    public int MyID { get { return ID; } set { ID = value; } }
}
