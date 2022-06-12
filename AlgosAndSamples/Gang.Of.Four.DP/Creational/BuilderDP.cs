using System;
using System.Collections.Generic;
using System.Text;

namespace AlgosAndSamples.Gang.Of.Four.DP.Creational
{
	/// <summary>
	/// The Builder Design Pattern separates the construction of a complex object from its representation 
	/// so that the same construction process can create different representations.
	/// </summary>
	class BuilderDP
	{
		public BuilderDP()
		{
			Start();
		}
		void Start()
		{
			Director director = new Director();
			Builder b1 = new ConcreteBuilder1();
			Builder b2 = new ConcreteBuilder2();

			director.Construct(b1);
			director.Construct(b2);
		}
	}
	/// <summary>
	/// The 'Director' class, constructs an object using the Builder interface.
	/// e.g. Showroom for any Vehicle.
	/// </summary>
	class Director
	{
		public void Construct(Builder builder)
		{
			builder.BuildPartA();
			builder.BuildPartB();
		}
	}

	/// <summary>
	/// The 'Builder' abstract class
	/// Determines the abstract concept/interface of the object(Product) being created.
	/// e.g Vehicle Builder.
	/// </summary>
	abstract class Builder
	{
		public abstract void BuildPartA();
		public abstract void BuildPartB();
		public abstract Product GetProduct();
	}

	/// <summary>
	/// The 'ConcreteBuilder1' class.
	/// constructs and assembles parts of the product by implementing the Builder interface.
	/// defines and keeps track of the representation it creates.
	/// provides an interface for retrieving the product.
	/// e.g. MotorCycleBuilder, CarBuilder, ScooterBuilder
	/// </summary>
	class ConcreteBuilder1 : Builder
	{
		private Product _product = new Product();
		public override void BuildPartA()
		{
			_product.Add("ABS System");
		}

		public override void BuildPartB()
		{
			_product.Add("Boss Music System");
		}

		public override Product GetProduct()
		{
			return _product;
		}
	}
	/// <summary>
	/// The 'ConcreteBuilder2' class
	/// </summary>
	class ConcreteBuilder2 : Builder
	{
		private Product _product = new Product();
		public override void BuildPartA()
		{
			_product.Add("Engine System");
		}

		public override void BuildPartB()
		{
			_product.Add("Anti Theft System");
		}

		public override Product GetProduct()
		{
			return _product;
		}
	}
	/// <summary>
	/// The 'Product' class.
	/// represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled.
	/// includes classes that define the constituent parts, including interfaces for assembling the parts into the final result 
	/// e.g. Vehicle
	/// </summary>
	class Product
	{
		public List<string> _products = new List<string>();
		public void Add(string productPart)
		{
			_products.Add(productPart);
		}
		public void Show()
		{
			Console.ForegroundColor = (ConsoleColor.Cyan);
			Console.BackgroundColor = (ConsoleColor.White);
			Console.WriteLine("Displaying Products---");
			foreach (var item in _products)
				Console.WriteLine(item);
		}
	}
}
