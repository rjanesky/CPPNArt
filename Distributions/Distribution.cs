using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Distributions
{
    public abstract class Distribution <T>
    {
        public abstract T Next();

        protected static RNGCryptoServiceProvider _global = new RNGCryptoServiceProvider();

        [ThreadStatic]
        protected static Random _local;

        protected double nextDouble()
        {
            if (_local == null)
            {
                byte[] buffer = new byte[4];

                _global.GetBytes(buffer);

                _local = new Random(BitConverter.ToInt32(buffer, 0));
            }

            return _local.NextDouble();
        }
    }
}
