// 
//  Copyright 2012  barry forrest
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using NUnit.Framework;

namespace RomanNumeralKata
{
	[TestFixture()]
	public class NumeralParserTests
	{
		[Test()]
		public void I_Translates_To_One ()
		{
			var numeralParser = new NumeralParser("i");
			
			Assert.That(numeralParser.Value == 1);
		}
		
		[Test()]
		public void II_Translates_To_Two()
		{
			var parser = new NumeralParser("ii");
			
			Assert.That(parser.Value == 2);
		}
		
		[Test()]
		public void V_Translates_To_Five()
		{
			var parser = new NumeralParser("v");
			Assert.That(parser.Value == 5);
		}
	}
}