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
    public static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
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

}
