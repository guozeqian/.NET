﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceList_Add
{
    public class SequenceListTest
    {
        public static void Main()
        {
            SequenceList<int> slist = new SequenceList<int>(10);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个数据：");
                string str = Console.ReadLine();
                int temp = int.Parse(str);
                slist.Add(temp);
            }
            Console.WriteLine("顺序表成员为：" + slist);


        }
    }
}
