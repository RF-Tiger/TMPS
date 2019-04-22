using System;
using BuilderSample.Builder;

namespace BuilderSample.Factory
{
    class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        public override Car Construct()
        {
            CarBuilder.BuildFrames();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();
            CarBuilder.BuildMultimedia();
            CarBuilder.BuildLuxury();

            return CarBuilder.GetCar();
        }
    }
}
