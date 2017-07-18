using System;

namespace Inheritance_Tomogatchi.Answer
{
    public class GameObject
    {
        public int GameObjectId { get; set; }

        public string ObjectName { get; set; }

        public GameObject(string name)
        {
            ObjectName = name;
            GameObjectId = new Random().Next();
        }

        public virtual void DoSomething()
        {

        }
    }
}