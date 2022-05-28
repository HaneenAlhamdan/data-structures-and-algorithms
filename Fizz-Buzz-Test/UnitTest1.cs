using data_structures_and_algorithms.Tree_Fizz_Buzz;
using System;
using System.Collections.Generic;
using Xunit;

namespace Fizz_Buzz_Test
{
    public class TestFizzBuzz
    {
        [Fact]
        public void TestFizzBuzzt()
        {
            K_ary K_ary = new K_ary("1");
            K_ary.Children.Add(new K_ary("2"));
            K_ary.Children.Add(new K_ary("3"));
            K_ary.Children.Add(new K_ary("4"));
            K_ary.Children[0].Children.Add(new K_ary("5"));
            K_ary.Children[0].Children.Add(new K_ary("6"));
            K_ary.Children[0].Children.Add(new K_ary("7"));
            
            List<string> list1 = K_ary.FizzBuzz(K_ary);
            List<string> list2 = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" };
            Assert.Equal(list2, list1);
        }
    }
}