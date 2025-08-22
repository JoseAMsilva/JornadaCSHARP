using System;

/// <summary>
/// Uma classe de exceção personalizada para erros de lógica de negócios.
/// </summary>
public class CustomException : Exception
{
    public CustomException() { }
    public CustomException(string message) : base(message) { }
    public CustomException(string message, Exception inner) : base(message, inner) { }
}