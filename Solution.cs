using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Solution
{

    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }
    public SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
    {
        int counter = 0;
        SinglyLinkedListNode current = head;
        SinglyLinkedListNode previous = null;
        while (current != null)
        {
            
            if (counter == position)
            {
                SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
                if (previous != null)
                {
                    previous.next = newNode;
                }
                else
                {
                    head = newNode;
                }
                newNode.next = current;
            }
            counter++;
            previous = current;
            current = current.next;
        }
        return head;
    }
    public int alternatingCharacters(string s)
    {
        int len = s.Length;
        int deletes = 0;
        for (int i = 0; i < len - 1; i++)
        {
            int j = i + 1;
            for (; j < len; j++)
            {
                if (s[i] == s[j])
                {
                    deletes++;
                }
                else
                {
                    i = j - 1;
                    break;
                }
            }
            if (j == len)
                break;
        }
        return deletes;
    }

}
