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

class Solution
{
    // Complete the rotLeft function below.
    public int[] rotLeft(int[] a, int d)
    {
        // declare new array
        int[] b = new int[a.Length];
        // for indexes o to len-1     
        for (int i = 0; i < b.Length; i++)
        {
            if (b.Length - i - 1 < d)
                b[i] = a[a.Length - d - i];
            else
                b[i] = a[i + d];
        }
        return b;
    }
}
