﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Box_of_String
{
    public class Box<T>
    {
        private List<T> list=new List<T>();

        public List<T> List 
        {
            get { return list; }
            set { list = value; }
        }
        public void Add(T item)
        {
            list.Add(item);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            foreach (var item in List)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }
            return stringBuilder.ToString();
        }
    }
}
