using System;
using System.Globalization;
/// <summary>
/// Parse(System.String)
/// </summary>
public class SingleParse1
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        retVal = PosTest4() && retVal;
        retVal = PosTest5() && retVal;
        retVal = PosTest6() && retVal;
        retVal = PosTest7() && retVal;
        TestLibrary.TestFramework.LogInformation("[Negtive]");
        retVal = NegTest1() && retVal;
        retVal = NegTest2() && retVal;
        retVal = NegTest3() && retVal;
        retVal = NegTest4() && retVal;
        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Check a string which is converted by a random single.");

        try
        {
            Single i1 = TestLibrary.Generator.GetSingle();
            string testValue = i1.ToString("G9");
            if (Single.Parse(testValue)!=i1)
            {
                TestLibrary.TestFramework.LogError("001.1", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

    public bool PosTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest2: check a string  which is  not a number .");

        try
        {
            Single i1 = Single.NaN;
            string testValue=i1.ToString();
            Single actualValue = Single.Parse(testValue);
            if (!Single.IsNaN(actualValue))
            {
                TestLibrary.TestFramework.LogError("002.1", "Parse  return failed. ");
                retVal = false;
            }
            i1 = Single.NegativeInfinity;
            testValue = i1.ToString();
            actualValue = Single.Parse(testValue);
            if (!Single.IsNegativeInfinity(actualValue))
            {
                TestLibrary.TestFramework.LogError("002.2", "Parse  return failed.");
                retVal = false;
            }
            i1 = Single.PositiveInfinity;
            testValue = i1.ToString();
            actualValue = Single.Parse(testValue);
            if (!Single.IsPositiveInfinity(actualValue))
            {
                TestLibrary.TestFramework.LogError("002.3", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.4", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest3: Check a string which is converted by -123,456,789.");

        try
        {
            Single i1 = -123456789;
            CultureInfo myCulture = CultureInfo.CurrentCulture;
            string mySeparator=myCulture.NumberFormat.CurrencyGroupSeparator;
            string testValue = "-123"+mySeparator+"456"+mySeparator+"789";
            if (Single.Parse(testValue) != i1)
            {
                TestLibrary.TestFramework.LogError("003.1", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("003.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest4()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest4: Check a string which is converted by 123.45e+6.");

        try
        {
            Single i1 = (Single)123.45e+6;
            string testValue = "123" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "45e+6";
            Single actualValue = Single.Parse(testValue);
            if (actualValue != i1)
            {
                TestLibrary.TestFramework.LogError("004.1", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest5()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest5: Check a string which is converted by -.123.");

        try
        {
            Single i1 = (Single) (.123);
            string testValue = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "123";
            Single actualValue = Single.Parse(testValue);
            if (actualValue != i1)
            {
                TestLibrary.TestFramework.LogError("005.1", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("005.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest6()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest6: Check a string which is converted by  blank blank blank 123.");

        try
        {
            Single i1 = (Single)(123);
            string testValue = "   123";
            Single actualValue = Single.Parse(testValue);
            if (actualValue != i1)
            {
                TestLibrary.TestFramework.LogError("006.1", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest7()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest7: Check a string which is converted by  +123.");

        try
        {
            Single i1 = (Single)(+123);
            string testValue = "+123";
            Single actualValue = Single.Parse(testValue);
            if (actualValue != i1)
            {
                TestLibrary.TestFramework.LogError("007.1", "Parse  return failed. ");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("007.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool NegTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest1: s is a null reference.");

        try
        {
          
            string testValue = null;
            Single actualValue = Single.Parse(testValue);
            TestLibrary.TestFramework.LogError("101.1", "Parse  return failed. ");
            retVal = false;
          
        }
        catch (ArgumentNullException)
        {

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("101.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool NegTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest2: s is not a number in a valid format.");

        try
        {

            string testValue = "ADSD";
            Single actualValue = Single.Parse(testValue);
            TestLibrary.TestFramework.LogError("102.1", "Parse  return failed. ");
            retVal = false;

        }
        catch (FormatException)
        {

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("102.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool NegTest3()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest3: s represents a number less than MinValue.");

        try
        {

            string testValue = "-3" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "40282346638528859e+39";
            Single actualValue = Single.Parse(testValue);
            TestLibrary.TestFramework.LogError("103.1", "Parse  return failed. ");
            retVal = false;

        }
        catch (OverflowException)
        {

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("103.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool NegTest4()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest4: s represents a number  greater than MaxValue.");

        try
        {

            string testValue = "3" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator + "40282346638528859e+39";;
            Single actualValue = Single.Parse(testValue);
            TestLibrary.TestFramework.LogError("104.1", "Parse  return failed. ");
            retVal = false;

        }
        catch (OverflowException)
        {

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("104.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #endregion

    public static int Main()
    {
        SingleParse1 test = new SingleParse1();

        TestLibrary.TestFramework.BeginTestCase("SingleParse1");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

}
