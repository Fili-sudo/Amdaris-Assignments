using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBasicsProgram
{
    public class ShapesCollection : IEnumerable
    {
        private IShape[] _shapes;
        public ShapesCollection(IShape[] sArray)
        {
            _shapes = new IShape[sArray.Length];

            for (int i = 0; i < sArray.Length; i++)
            {
                _shapes[i] = sArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public ShapesEnum GetEnumerator()
        {
            return new ShapesEnum(_shapes);
        }
    }
    

    public class ShapesEnum : IEnumerator
    {
        public IShape[] _shapes;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public ShapesEnum(IShape[] list)
        {
            _shapes = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _shapes.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public IShape Current
        {
            get
            {
                try
                {
                    return _shapes[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
