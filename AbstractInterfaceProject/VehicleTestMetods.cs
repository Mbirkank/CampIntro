using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceProject
{
    public interface IVehicle
    {
        void Go();
        void Stop();
    }
    public interface IRideable
    {
        void Ride();
    }
    public interface IFlyable
    {
        void Soar();
    }
    public class Car : IVehicle
    {
        public void Go()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Bike : IRideable, IVehicle
    {
        public void Go()
        {
            throw new NotImplementedException();
        }

        public void Ride()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    
}
