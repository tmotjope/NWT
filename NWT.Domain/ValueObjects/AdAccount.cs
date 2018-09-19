using NWT.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Domain.ValueObjects
{
    public class AdAccount : ValueObject
    {
        private AdAccount()
        {

        }

        public AdAccount(string value)
        {
            try
            {
                var index = value.IndexOf("\\", StringComparison.Ordinal);
                Domain = value.Substring(0, index);
                Name = value.Substring(index + 1);
            }
            catch
            {
                throw new AdAccountInvalidException(value);
            }
        }

        public string Domain { get; private set; }
        public string Name { get; private set; }

        public static implicit operator String(AdAccount adAccount)
        {
            return adAccount.ToString();
        }
        public static explicit operator AdAccount(String value)
        {
            return new AdAccount(value);
        }


        public override string ToString()
        {
            return $"{Domain}\\{Name}";
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Domain;
            yield return Name;
        }
    }
}
