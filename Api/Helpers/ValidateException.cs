using System;
using System.Collections.Generic;

namespace Shop.Api.Helpers
{
  public class ValidateException : Exception
  {
    public ValidateException() { }
    public ValidateException(string message)
    {
      Errors = new List<string>() { message };
    }
    public IEnumerable<string> Errors { get; set; }
  }
}