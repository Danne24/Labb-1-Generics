using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics
{
    public class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection _boxesCollection;
        private int _curIndex;
        private Box _curBox;

        public BoxEnumerator(BoxCollection collection)
        {
            _boxesCollection = collection;
            _curIndex = -1;
            _curBox = default(Box);
        }

        public Box Current
        {
            get { return _curBox; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        void IDisposable.Dispose() { }

        public bool MoveNext()
        {
            if (++_curIndex >= _boxesCollection.Count)
            {
                return false;
            }
            else
            {
                _curBox = _boxesCollection[_curIndex];
            }
            return true;
        }

        public void Reset() { _curIndex = -1; }
    }
}
