using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics
{
    public class BoxCollection : ICollection<Box>
    {
        private List<Box> _innerCol;

        public BoxCollection()
        {
            _innerCol = new List<Box>();
        }

        public Box this[int index]
        {
            get { return (Box)_innerCol[index]; }
            set { _innerCol[index] = value; }
        }

        public int Count
        {
            get
            {
                return _innerCol.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                _innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("ERROR: A box with {0} X {1} X {2} dimensions already exists in the collection, you are unable to add new boxes whose dimensions already exists in the collection.", item.Height.ToString(), item.Length.ToString(), item.Width.ToString());
            }
        }

        public void Clear()
        {
            _innerCol.Clear();
        }

        public bool Contains(Box item)
        {
            bool found = false;

            foreach (Box box in _innerCol)
            {
                if (box.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public bool Contains(Box item, EqualityComparer<Box> compare)
        {
            bool found = false;

            foreach (Box box in _innerCol)
            {
                if (compare.Equals(box, item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");

            for (int i = 0; i < _innerCol.Count; i++)
            {
                array[i + arrayIndex] = _innerCol[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;

            for (int i = 0; i < _innerCol.Count; i++)
            {

                Box curBox = (Box)_innerCol[i];

                if (new BoxSameDimensions().Equals(curBox, item))
                {
                    _innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
