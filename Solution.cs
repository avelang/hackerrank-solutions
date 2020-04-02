public class Solution
{
    // Complete the rotLeft function below.
    // to-do : Left rotation by 'd' indexes is the same 
    // as right rotation by len - d indexes 
    // Index of new array = [i + (len - d)] mod len
    public int[] LeftRotation(int[] a, int d)
    {
        int len = a.Length;
        int[] b = new int[len];
        int right_rot = len - d;
        for (int i = 0; i < len; i++)
        {
            int b_index = (i + right_rot) % len;
            b[b_index] = a[i];
        }
        return b;
    }
}
