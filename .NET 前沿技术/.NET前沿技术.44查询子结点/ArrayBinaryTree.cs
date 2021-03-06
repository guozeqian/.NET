﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exec2
{
    public class ArrayBinaryTree<T>
    {
        private T[] datas;// 结点数组
        private int count;// 结点个数
        private int arraySize = 0;// 实际数组长度

        public ArrayBinaryTree()
            : this(4)
        {
        }

        public ArrayBinaryTree(int deep)
        {
            arraySize = (int)Math.Pow(2, deep) - 1;
            datas = new T[arraySize];
            count = 0;
        }
        public ArrayBinaryTree(int deep, T data)
        {
            arraySize = (int)Math.Pow(2, deep) - 1;
            datas = new T[arraySize];
            datas[0] = data;
            count = 1;
        }

        // 为指定结点增加子结点
        public bool Insert(int index, T obj, bool leftChild)
        {
            if (index * 2 + 1 > arraySize || index < 1 || datas[index - 1] == null)
                throw new Exception("标记无效");
            if (leftChild)
                datas[index * 2 - 1] = obj;
            else
                datas[index * 2] = obj;
            count++;
            return true;

        }
        //获取父结点
        public T GetParent(int index)
        {
            if (index > arraySize || index < 1 || datas[index] == null)
                throw new Exception("标记无效");
            if (index == 1 || datas[index / 2 - 1] == null)
                throw new Exception("无双亲节点");
            return datas[index / 2 - 1];

        }

        public T this[int index]
        {
            set {
                if (index - 1 > arraySize || index < 1 || datas[index - 1] == null)
                    throw new Exception("标记无效");
                datas[index - 1] = value;
            }
            get {
                if (index - 1 > arraySize || index < 1 || datas[index - 1] == null)
                    throw new Exception("标记无效");
                return datas[index - 1];
            }
        }
   
        // 返回左子结点
        public T GetLeftNode(int index)
        {
            if (index * 2 > arraySize || index < 1 || datas[index - 1] == null)
                throw new Exception("标记无效");
            return datas[index * 2 - 1];
        }

        // 返回右子结点
        public T GetRightNode(int index)
        {
            if (index * 2 > arraySize || index < 1 || datas[index - 1] == null)
                throw new Exception("标记无效");
            return datas[index * 2];
        }
        //层次遍历
        public void FindByLevel()
        {
            StringBuilder str = new StringBuilder("[");
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] != null)
                    str.Append("[" + datas[i] + "],");
            }
            if (datas.Length > 0)
                Console.WriteLine(str.Remove(str.Length - 1, 1) + "]");
            else
                Console.WriteLine(str.Append("]").ToString());
        }
    }

}
