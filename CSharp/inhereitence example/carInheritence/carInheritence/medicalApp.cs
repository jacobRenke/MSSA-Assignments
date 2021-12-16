using System;

namespace carInheritence
{
    public class GM
    {
        private string frameOfVehicle;
        private int numberOfWheels;
        private string engineType;
        private bool isTruck = true;
        protected string interiorMaterial;
        protected string steeringWheelEmblem;
    }
        public class GMC : GM
        {
            
        }

        public class Chevrolet : GM
        {
            
        }
        public class Sierra : GMC
        {
            
        }
        
        public class Silverado : Chevrolet
        {
            
        }
    
}
