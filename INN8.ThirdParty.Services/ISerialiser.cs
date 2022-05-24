using System;
using System.Collections.Generic;
using System.Text;

namespace INN8.ThirdParty.Services
{
  public interface ISerialiser
  {
    public string Serialise(object value);
  }
}
