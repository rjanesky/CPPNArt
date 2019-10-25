using System;
using System.Collections.Generic;
using System.Text;

using Distributions;

namespace NEATCore
{
    public class Network
    {
        protected List<Connection> connections = new List<Connection>();

        public Network(Distribution<double> w, int inputs, int outputs)
        {
            for(var i = 0; i < inputs; i++)
            {
                connections.Add(new Connection()
                {
                    Input = i,
                    Output = inputs + 1,
                    Enabled = true,
                    Weight = w.Next()
                });
            }

            for (var i = 0; i < outputs; i++)
            {
                connections.Add(new Connection()
                {
                    Input = inputs + 1,
                    Output = inputs + 2 + i,
                    Enabled = true,
                    Weight = w.Next()
                });
            }
        }
    }
}
