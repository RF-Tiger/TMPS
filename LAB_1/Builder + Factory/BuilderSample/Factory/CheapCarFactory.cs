using System;
using BuilderSample.Builder;

namespace BuilderSample.Factory
{
    class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        public override Car Construct()
        {
            CarBuilder.BuildFrames();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();

            return CarBuilder.GetCar();
        }
    }
}
