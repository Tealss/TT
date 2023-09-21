using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Item : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);

    }
}

[System.Serializable]
public class Items
{
    public string itemName; // ������ �̸�
    public int itemID; // ������ ID �Ǵ� ���� �ĺ���
    public int itemQuantity; // ������ ����

    public Items(string name, int id)
    {
        itemName = name;
        itemID = id;
        itemQuantity = 1; // �⺻������ ������ ������ 1�� ����
    }
}
