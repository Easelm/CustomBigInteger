using System;
public class TestCustomBigInteger
{
    private long _testLong = 1;
    private ulong _testULong = 1;
    private int _testInt = 1;
    private uint _testUInt = 1;
    private byte _testByte = 1;

    private CustomBigInteger _longBigInteger = 0;
    private CustomBigInteger _ulongBigInteger = 0;
    private CustomBigInteger _intBigInteger = 0;
    private CustomBigInteger _uintBigInteger = 0;
    private CustomBigInteger _byteBigInteger = 0;

    public TestCustomBigInteger()
    {
        // long boolean test
        bool testLongOperatorRightSideRight = _longBigInteger > _testLong;
        bool testLongOperatorRightSideLeft = _longBigInteger < _testLong;
        bool testLongOperatorLeftSideRight = _testLong > _longBigInteger;
        bool testLongOperatorLeftSideLeft = _testLong < _longBigInteger;
        // long Math test
        _longBigInteger += _testLong + 4;
        _longBigInteger++;
        _longBigInteger--;
        _longBigInteger -= _testLong + 1;
        _longBigInteger = _longBigInteger * 2;
        // ulong boolean test
        bool testULongOperatorRightSideRight = _ulongBigInteger > _testULong;
        bool testULongOperatorRightSideLeft = _ulongBigInteger < _testULong;
        bool testULongOperatorLeftSideRight = _testULong > _ulongBigInteger;
        bool testULongOperatorLeftSideLeft = _testULong < _ulongBigInteger;
        // long Math test
        _ulongBigInteger += _testULong + 4;
        _ulongBigInteger++;
        _ulongBigInteger--;
        _ulongBigInteger -= _testULong + 1;
        _ulongBigInteger = _ulongBigInteger * 2;
        // int boolean test
        bool testIntOperatorRightSideRight = _intBigInteger > _testInt;
        bool testIntOperatorRightSideLeft = _intBigInteger < _testInt;
        bool testIntOperatorLeftSideRight = _testInt > _intBigInteger;
        bool testIntOperatorLeftSideLeft = _testInt < _intBigInteger;
        // int Math test
        _intBigInteger += _testInt + 4;
        _intBigInteger++;
        _intBigInteger--;
        _intBigInteger -= _testInt + 1;
        _intBigInteger = _intBigInteger * 2;
        // uint boolean test
        bool testUIntOperatorRightSideRight = _uintBigInteger > _testUInt;
        bool testUIntOperatorRightSideLeft = _uintBigInteger < _testUInt;
        bool testUIntOperatorLeftSideRight = _testUInt > _uintBigInteger;
        bool testUIntOperatorLeftSideLeft = _testUInt < _uintBigInteger;
        // uint Math test
        _uintBigInteger += _testUInt + 4;
        _uintBigInteger++;
        _uintBigInteger--;
        _uintBigInteger -= _testUInt + 1;
        _uintBigInteger = _uintBigInteger * 2;
        // byte boolean test
        bool testByteOperatorRightSideRight = _byteBigInteger > _testByte;
        bool testByteOOperatorRightSideLeft = _byteBigInteger < _testByte;
        bool testByteOOperatorLeftSideRight = _testByte > _byteBigInteger;
        bool testByteOOperatorLeftSideLeft = _testByte < _byteBigInteger;
        // byte Math test
        _byteBigInteger += _testByte + 4;
        _byteBigInteger++;
        _byteBigInteger--;
        _byteBigInteger -= _testByte + 1;
        _byteBigInteger = _byteBigInteger * 2;

#if UNITY_2021_1_OR_NEWER
        #region Boolean Tests
        UnityEngine.Debug.Log(string.Format("LONG TEST: {0}, {1}, {2}, {3}", testLongOperatorRightSideRight, testLongOperatorRightSideLeft,
            testLongOperatorLeftSideRight, testLongOperatorLeftSideLeft));
        UnityEngine.Debug.Log(string.Format("ULONG TEST: {0}, {1}, {2}, {3}", testULongOperatorRightSideRight, testULongOperatorRightSideLeft,
            testULongOperatorLeftSideRight, testULongOperatorLeftSideLeft));
        UnityEngine.Debug.Log(string.Format("INT TEST: {0}, {1}, {2}, {3}", testIntOperatorRightSideRight, testIntOperatorRightSideLeft,
            testIntOperatorLeftSideRight, testIntOperatorLeftSideLeft));
        UnityEngine.Debug.Log(string.Format("UINT TEST: {0}, {1}, {2}, {3}", testUIntOperatorRightSideRight, testUIntOperatorRightSideLeft,
            testUIntOperatorLeftSideRight, testUIntOperatorLeftSideLeft));
        UnityEngine.Debug.Log(string.Format("BYTE TEST: {0}, {1}, {2}, {3}", testByteOperatorRightSideRight, testByteOOperatorRightSideLeft,
            testByteOOperatorLeftSideRight, testByteOOperatorLeftSideLeft));
        #endregion

        #region Addition Tests
        UnityEngine.Debug.Log(string.Format("LONG MATH TEST: {0}", _longBigInteger.B));
        UnityEngine.Debug.Log(string.Format("ULONG MATH TEST: {0}", _ulongBigInteger.B));
        UnityEngine.Debug.Log(string.Format("INT MATH TEST: {0}", _intBigInteger.B));
        UnityEngine.Debug.Log(string.Format("UINT MATH TEST: {0}", _uintBigInteger.B));
        UnityEngine.Debug.Log(string.Format("BYTE MATH TEST: {0}", _byteBigInteger.B));
        #endregion
#else
        #region Boolean Tests
        Console.WriteLine(string.Format("LONG TEST: {0}, {1}, {2}, {3}", testLongOperatorRightSideRight, testLongOperatorRightSideLeft,
            testLongOperatorLeftSideRight, testLongOperatorLeftSideLeft));
        Console.WriteLine(string.Format("ULONG TEST: {0}, {1}, {2}, {3}", testULongOperatorRightSideRight, testULongOperatorRightSideLeft,
            testULongOperatorLeftSideRight, testULongOperatorLeftSideLeft));
        Console.WriteLine(string.Format("INT TEST: {0}, {1}, {2}, {3}", testIntOperatorRightSideRight, testIntOperatorRightSideLeft,
            testIntOperatorLeftSideRight, testIntOperatorLeftSideLeft));
        Console.WriteLine(string.Format("UINT TEST: {0}, {1}, {2}, {3}", testUIntOperatorRightSideRight, testUIntOperatorRightSideLeft,
            testUIntOperatorLeftSideRight, testUIntOperatorLeftSideLeft));
        Console.WriteLine(string.Format("BYTE TEST: {0}, {1}, {2}, {3}", testByteOperatorRightSideRight, testByteOOperatorRightSideLeft,
            testByteOOperatorLeftSideRight, testByteOOperatorLeftSideLeft));
        #endregion

        #region Addition Tests
        Console.WriteLine(string.Format("LONG ADDITION TEST: {0}", _longBigInteger.B));
        Console.WriteLine(string.Format("ULONG TEST: {0}", _ulongBigInteger.B));
        Console.WriteLine(string.Format("INT TEST: {0}", _intBigInteger.B));
        Console.WriteLine(string.Format("UINT TEST: {0}", _uintBigInteger.B));
        Console.WriteLine(string.Format("BYTE TEST: {0}", _byteBigInteger.B));
        #endregion
#endif
    }
}
