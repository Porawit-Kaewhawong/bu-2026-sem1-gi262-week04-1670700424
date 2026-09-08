using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> lists = new List<string>();
        }

        public void LCT02_SyntaxLinkedList()
        {
            // LinkedList's AddFirst and AddLast Function
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("Node 1"); // Add "Node 1" to the last
            linkedList.AddLast("Node 2"); // Add "Node 2" replaces "Node 1" as the last
            linkedList.AddFirst("Node 0"); // Add "Node 0" to the first

            PrintLinkedList(linkedList);

            // LinkedListNode's Finding Function
            LinkedListNode<string> firstNode = linkedList.First;
            Debug.Log($"First: {firstNode.Value}");

            LinkedListNode<string> lastNode = linkedList.Last;
            Debug.Log($"Last: {lastNode.Value}");

            LinkedListNode<string> selectNode = linkedList.Find("Node 1");
            Debug.Log($"Select: {selectNode.Value}");
            Debug.Log(selectNode.Previous.Value); // Finding a previous number before selectNode
            Debug.Log(selectNode.Next.Value); // Finding a next number after selectNode

            // Safety Net
            if (firstNode.Previous == null) Debug.Log("firstNode.Previous is null");
            if (lastNode.Next == null) Debug.Log("lastNode.Next is null");

            // LinkedList's AddAfter and AddBefore Function
            linkedList.AddAfter(selectNode, "Node 1.5");
            linkedList.AddBefore(selectNode, "Node 0.5");

            PrintLinkedList(linkedList);

            // LinkedList's Removal Function
            linkedList.RemoveFirst();

            PrintLinkedList(linkedList);

            linkedList.Remove("Node 2"); // Remove by finding a string
            linkedList.Remove(selectNode); // Remove by using a parameter

            PrintLinkedList(linkedList);

            // LinkedList's Clear Function
            linkedList.Clear();

            PrintLinkedList(linkedList);
        }

        void PrintLinkedList(LinkedList<string> linkedList)
        {
            Debug.Log("---------- LinkedList ----------");
            foreach (string s in linkedList)
            {
                Debug.Log(s);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            // Dictionary's Add Function
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary[3] = "Cherry"; // Same as the Add Function

            // Debug.Log(dictionary[4]);

            // Dictionary's Check Function
            int keyToCheck = 1;
            bool hasKey = dictionary.ContainsKey(keyToCheck);
            Debug.Log($"Has Key {keyToCheck} : {hasKey}");

            if (hasKey)
            {
                Debug.Log($"Has Key: {hasKey}");
            }

            // Dictionary's Keys and Values Function
            foreach (int k in dictionary.Keys)
            {
                Debug.Log(k);
            }

            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }

            dictionary.Clear();
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
            
        }

        #endregion
    }
}
