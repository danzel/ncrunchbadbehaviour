using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xunit;

namespace TestTest
{
	public class Class1
	{
		public static IEnumerable<object[]> RandomSeeds()
		{
			return Enumerable.Range(0, 100).Select(n => new object[] { n });
		}

		[Theory]
		[MemberData(nameof(RandomSeeds))]
		public void Test(int randomSeed)
		{
			var rand = new Random(randomSeed);

			//Test code normally goes here
			//throw new Exception();
			Thread.Sleep(TimeSpan.FromSeconds(5));
			Console.WriteLine("asd23456");
		}
	}
}
