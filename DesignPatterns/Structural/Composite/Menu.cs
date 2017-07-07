using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menus;
        private readonly string _name;
        private readonly string _description; 
        
        public Menu(string name, string description)
        {
            _menus = new List<MenuComponent>();
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menus.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menus.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menus.ElementAt(i);
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;            
        }

        public override void Print()
        {
            Console.Write(GetName());
            Console.WriteLine($", {GetDescription()}");

            foreach (var menu in _menus)
            {
                menu.Print();
            }
        }
    }
}
