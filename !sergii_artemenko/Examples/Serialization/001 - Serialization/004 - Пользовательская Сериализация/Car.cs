using System;
using System.Runtime.Serialization;

namespace UserSerialWork
{
	[Serializable]
	public class Car : ISerializable
	{
		public string name;
		public int speed;
        public int some;

		public Car(string name, int speed)
		{
			this.name = name;
			this.speed = speed;
		}

		
		private Car(SerializationInfo propertyBag, StreamingContext context)
		{
			
			Console.WriteLine("[ctor] ContextState: {0}", context.State.ToString());

			
			name = propertyBag.GetString("name");
			speed = propertyBag.GetInt32("speed");
		}


		
		void ISerializable.GetObjectData(SerializationInfo propertyBag, StreamingContext context)
		{
			
			Console.WriteLine("[GetObjectData] ContextState: {0}", context.State.ToString());

			
			propertyBag.AddValue("name", name);
			propertyBag.AddValue("speed", speed);
		}
	}
}
