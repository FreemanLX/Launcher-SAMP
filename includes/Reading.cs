using System;

namespace Neo_San_Andras_Multiplayer
{
    class Reading : IDisposable
    {
        static bool location, dark, close, beta;

        public Reading(){}

        public Reading(string s, bool n)
        {
            switch (s)
            {
                case "Location":
                    location = n;
                    break;

                case "Dark":
                    dark = n;
                    break;

                case "Close":
                    close = n;
                    break;

                case "Beta":
                    beta = n;
                    break;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool recieve(string s)
        {
            switch (s)
            {
                case "Location":
                    return location;
                    
                case "Dark":
                    return dark;
                   
                case "Close":
                    return close;
                    
                case "Beta":
                    return beta;
                    
            }
            return false;
        }
      
    }
}
