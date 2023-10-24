using System.Collections.Generic;

namespace Collection.Entities;

public class IntList
{
    public int[] _number = {};

    public void Add(int number)
    {
        Array.Resize(ref _number, _number.Length + 1);
        _number[_number.Length - 1] = number;
    }
    public void Get()
    {
        for (int i = 0; i < _number.Length; i++)
        {
            Console.Write(_number[i] + ",");
        }
    }
}
