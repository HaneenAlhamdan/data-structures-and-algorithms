using data_structures_and_algorithms.HashMap;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace HashTest
{
    public class UnitTest1
    {
        public class TestHashmapRepeatedWord
        {
            hashmap hashmapRepeatedWord = new hashmap();
            [Fact]
            public void Test1()
            {
                string text = "";
                Assert.Equal("No text provided", hashmapRepeatedWord.HashmapRepeatedWord(text));
            }
            [Fact]
            public void Test2()
            {
                string text = "Prepared by experienced English teachers";
                Assert.Equal("No Repetetion", hashmapRepeatedWord.HashmapRepeatedWord(text));
            }
            [Fact]
            public void Test3()
            {
                string text = "Prepared by experienced English teachers, the texts, articles and conversations are brief and appropriate to your level of proficiency";
                Assert.Equal("and", hashmapRepeatedWord.HashmapRepeatedWord(text));
            }
            [Fact]
            public void Test4()
            {
                string text = "Here you can find activities to practise your reading skills. Reading will help you to improve your understanding of the language and build your vocabulary.";
                Assert.Equal("you", hashmapRepeatedWord.HashmapRepeatedWord(text));
            }
            [Fact]
            public void Test5()
            {
                string text = "So I know everyone's doing the right things for their the ages";
                Assert.Equal("the", hashmapRepeatedWord.HashmapRepeatedWord(text));
            }
        }

    }
}
