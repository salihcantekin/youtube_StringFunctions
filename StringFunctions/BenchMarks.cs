using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions;

[MemoryDiagnoser]
public class BenchMarks
{
    private string filePath = "Files/File32K.txt";
    private string reversedFilePath = "Files/File32K_Reversed.txt";
    private string fileContent;
    private string reversedFileContent;

    [GlobalSetup]
    public void OneTimeSetup()
    {
        fileContent = File.ReadAllText(filePath);
        reversedFileContent = File.ReadAllText(reversedFilePath);
    }

    [Params("asd", "testset", "cjyhwdmhqlkztpduwdgchxvhu")]
    public string SearchText { get; set; }

    [Benchmark]
    public void StartsWith_Normal()
    {
        fileContent.TBStartsWith(SearchText);
    }

    [Benchmark]
    public void EndsWith_Normal()
    {
        fileContent.TBEndsWith(SearchText);
    }
    [Benchmark]
    public void Contains_Normal()
    {
        fileContent.TBContains(SearchText);
    }



    [Benchmark]
    public void EndsWith_Reversed()
    {
        reversedFileContent.TBEndsWithV2WithReversedText(SearchText.TBReverse());
    }


    #region File Tests

    //[Params(10, 100, 1000)]
    //public int ReadSize { get; set; }

    //[Benchmark]
    //public void ReadFromBegining()
    //{
    //    FileContentHelper.ReadByByte(filePath, ReadSize);
    //}

    //[Benchmark]
    //public void ReadFromEnd()
    //{
    //    FileContentHelper.ReadByByte(filePath, ReadSize, true);
    //}


    //private static string ReadByByte(string filePath, int size, bool fromEnd = false)
    //{
    //    byte[] buffer = new byte[size];

    //    using (var readFS = File.Open(filePath, FileMode.Open))
    //    {
    //        if (fromEnd)
    //            readFS.Seek(-size, SeekOrigin.End);
    //        else
    //            readFS.Seek(0, SeekOrigin.Begin);

    //        int bytesRead = readFS.Read(buffer, 0, buffer.Length);

    //        var data = Encoding.UTF8.GetString(buffer, 0, bytesRead);

    //        return data;
    //    }
    //}

    #endregion
}
