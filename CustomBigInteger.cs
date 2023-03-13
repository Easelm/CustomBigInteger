using System;
using System.Numerics;

/// <summary>
/// CustomBigInteger
/// Allows Serialization for System.Numerics.BigInteger
/// Allows you to save data into a string and BigInteger will parse that string's data, allowing you to save and load serializable BigInteger data
/// Mainly for UnityEngine but can be used for other projects
/// </summary>
[Serializable]
public class CustomBigInteger
{
    public string val;
    private BigInteger _b;
    /// <summary>
    /// Returns BigInteger. If _b is 0 or val is not empty or null then it will parse data and set the value
    /// Sets value of _b and val
    /// </summary>
    public BigInteger B
    {
        get
        {
            if (_b == 0 && !string.IsNullOrEmpty(val))
                _b = Parse();
            return _b;
        }

        set
        {
            _b = value;
            val = _b.ToString();
        }
    }

    /// <summary>
    /// String Constructor
    /// </summary>
    /// <param name="customValue"></param>
    public CustomBigInteger(string customValue)
    {
        val = customValue;
        _b = Parse();
    }

    /// <summary>
    /// BigInteger Constructor
    /// </summary>
    /// <param name="customValue"></param>
    public CustomBigInteger(BigInteger customValue)
    {
        val = customValue.ToString();
        _b = Parse();
    }

    /// <summary>
    /// Returns BigInteger value of a string
    /// </summary>
    /// <returns>val</returns>
    private BigInteger Parse()
    {
        return BigInteger.Parse(val);
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    #region Operators
    public static CustomBigInteger operator +(CustomBigInteger value)
    {
        value.B += 1;
        return value;
    }

    public static CustomBigInteger operator +(CustomBigInteger left, BigInteger right)
    {
        left.B += right;
        return left;
    }

    public static CustomBigInteger operator -(CustomBigInteger value)
    {
        value.B -= 1;
        return value;
    }

    public static CustomBigInteger operator -(CustomBigInteger left, BigInteger right)
    {
        left.B -= right;
        return left;
    }

    public static CustomBigInteger operator ++(CustomBigInteger value)
    {
        value.B++;
        value.val = value.B.ToString();
        return value;
    }

    public static CustomBigInteger operator --(CustomBigInteger value)
    {
        value.B--;
        value.val = value.B.ToString();
        return value;
    }

    public static CustomBigInteger operator *(CustomBigInteger left, BigInteger right)
    {
        left.B *= right;
        return left;
    }

    public static implicit operator CustomBigInteger(int value) => new CustomBigInteger(value);
    public static implicit operator CustomBigInteger(uint value) => new CustomBigInteger(value);
    public static implicit operator CustomBigInteger(long value) => new CustomBigInteger(value);
    public static implicit operator CustomBigInteger(ulong value) => new CustomBigInteger(value);
    public static implicit operator CustomBigInteger(byte value) => new CustomBigInteger(value);
    public static implicit operator CustomBigInteger(BigInteger value) => new CustomBigInteger(value);
    public static implicit operator BigInteger(CustomBigInteger value) => value.B;
    public static implicit operator int(CustomBigInteger value) => (int)value.B;
    public static implicit operator uint(CustomBigInteger value) => (uint)value.B;
    public static implicit operator ulong(CustomBigInteger value) => (ulong)value.B;
    public static implicit operator long(CustomBigInteger value) => (long)value.B;
    public static implicit operator byte(CustomBigInteger value) => (byte)value.B;
    public static implicit operator float(CustomBigInteger value) => (float)value.B;

    public static bool operator <(CustomBigInteger left, CustomBigInteger right) { return left.B < right.B; }
    public static bool operator >(CustomBigInteger left, CustomBigInteger right) { return left.B > right.B; }
    public static bool operator <=(CustomBigInteger left, CustomBigInteger right) { return left.B <= right.B; }
    public static bool operator >=(CustomBigInteger left, CustomBigInteger right) { return left.B >= right.B; }
    public static bool operator ==(CustomBigInteger left, CustomBigInteger right) { return left.B == right.B; }
    public static bool operator !=(CustomBigInteger left, CustomBigInteger right) { return left.B != right.B; }
    #endregion
}