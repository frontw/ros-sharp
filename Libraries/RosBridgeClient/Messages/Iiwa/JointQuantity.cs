using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Iiwa
{
	public class JointQuantity : Message
    {
		[JsonIgnore]
		public const string RosMessageName = "iiwa_msgs/JointQuantity";

		public float a1; //woo
		public float a2; //woo
		public float a3; //woo
		public float a4; //woo
		public float a5; //woo
		public float a6; //woo
		public float a7; //woo

		public JointQuantity()
        {
			a1 = 0;
			a2 = 0;
			a3 = 0;
			a4 = 0;
			a5 = 0;
			a6 = 0;
			a7 = 0;
        }      
     }
}
