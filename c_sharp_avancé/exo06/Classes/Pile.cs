using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exo06.Classes;

internal class Pile<T>
{
    private List<T> _elements = new List<T>();

    public Pile()
    {
       
    }

    public void Empiler(T element)
    {
        _elements.Add(element);
    }

    public T? Depiler()
    {
        if (_elements.Count == 0)
        {
            Console.WriteLine("La pile est vide.");
            return default;

        }

        T dernierElement = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return dernierElement;
    }

    public T? Recuperer(int index)
    {
        if (index < 0 || index >= _elements.Count)
        {
            Console.WriteLine("erreur");
            return default;
        }

        T element = _elements[index];
        _elements.RemoveAt(index);
        return element;
    }
    public override string ToString()
    {
        return "Pile :" + string.Join(", ", _elements);
    }

}


