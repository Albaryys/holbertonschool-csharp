using System;

/// <summary>
/// A generic queue class.
/// </summary>
/// <typeparam name="T">Type is user-defined at instantiation.</typeparam>
class Queue<T>
/// <summary>
/// Gets the type of the instance.
/// </summary>
/// <returns>Returns the instance type.</returns>
{
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
