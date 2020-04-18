using System;

namespace Ex_MordorsCrueltyPlan_Inheritance
{
    public abstract class FoodFactory
    {
        private string name;
        private int hp;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int HP
        {
            get => hp;
            set => hp = value;
        }
    }
}