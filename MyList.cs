using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DSLKDonPhamVanQuoc22DH114707
{
    internal class MyList
    {
        private IntNode first, last;

        internal IntNode First { get => first; set => first = value; }
        internal IntNode Last { get => last; set => last = value; }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFist(IntNode newNode)
        {
            if (IsEmpty())

            {
                first = last = newNode;
            }
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void InPut()
        {
            do
            {
                Console.Write("Nhap gia tri (nhan 0 de dung):");
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                IntNode newNode = new IntNode(x);
                AddFist(newNode);
            } while (true);
        }

        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }

        }
        public IntNode Searchx(int x)
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data == x)
                {

                    return p;
                }
                p = p.Next;

            }
            return null;
        }
        public IntNode GetMax()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data < p.Next.Data)
                {

                    p.Data = p.Next.Data;
                }
                return p;

            }
            return null;
        }
    }

}


        
    

