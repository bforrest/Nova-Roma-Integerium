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
			Assert.That("i".FromRomanNumeral() == 1);
		}
		
		[Test()]
		public void II_Translates_To_Two()
		{	
			Assert.That("ii".FromRomanNumeral() == 2);
		}
		
		[Test]
		public void IV_Translates_To_Four()
		{
			Assert.That("iv".FromRomanNumeral() == 4);
		}
		
		[Test()]
		public void V_Translates_To_Five()
		{
			Assert.That("v".FromRomanNumeral() == 5);
		}
			
		[Test]
		public void VIII_Translates_To_8()
		{
			Assert.That("viii".FromRomanNumeral() == 8);
		}
		
		[Test]
		public void XIV_Translates_To_Fourteen()
		{
			Assert.That("XIV".FromRomanNumeral() == 14);
		}
		
		[Test]
		public void M_Translates_To_1000()
		{
			Assert.That("m".FromRomanNumeral() == 1000);
		}
		
		[Test]
		public void CDXLVIII_Translates_To_448()
		{
			Assert.That("CDXLVIII".FromRomanNumeral() == 448);
		}
		
		[Test]
		public void MCMXCVIII_Translates_To_1998()
		{
			Assert.That("MCMXCVIII".FromRomanNumeral() == 1998);
		}
		
		
	}
}