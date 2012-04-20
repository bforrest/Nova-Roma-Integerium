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
using System.Linq;


namespace RomanNumeralKata
{
	public class NumeralParser
	{
		private readonly string suppliedValue;
		
		private int? parsedValue;
		
		public NumeralParser (string source)
		{
			suppliedValue = source.ToUpperInvariant();
		}
		
		public int Value
		{
			get
			{
				if( !parsedValue.HasValue)
					parse();
				
				return parsedValue.Value;
			}
		}
		
		private void parse()
		{
			int sum = 0;
			
			for(int i = 0; i < suppliedValue.Length; i++)
			{	
				RomanNumeral current = (RomanNumeral)Enum.Parse(typeof(RomanNumeral), suppliedValue[i].ToString() );
				
				RomanNumeral next = (i + 1 < suppliedValue.Length) 
					? (RomanNumeral)Enum.Parse(typeof(RomanNumeral), suppliedValue[i + 1].ToString() ) 
						: RomanNumeral.Default;
				
				if( current < next )
				{
					sum += next - current;
					++i;
				}
				else
				{
					sum += current;
				}
			}
			
			if( sum > 0 )
				parsedValue = sum;
		}
	}
}