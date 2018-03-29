
using System;
using System.Collections;
using System.Collections.Generic;

public class Lake : IEnumerable<int>

{
    private int[] stones;

    public Lake(int[] array)
    {
        this.FillMassive(array);
    }

    private void FillMassive(int[] array)
    {
        this.stones = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            this.stones[i] = array[i];
        }
    }


    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.stones.Length; i += 2)
        {
            yield return stones[i];
        }

        int length = 0;
        length = stones.Length - 1;

        if (length % 2 == 0)
        {
            length = stones.Length - 2;
        }

        for (int i = length; i >= 0; i -= 2)
        {
            yield return stones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
