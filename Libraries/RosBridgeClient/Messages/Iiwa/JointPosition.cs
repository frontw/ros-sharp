using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Iiwa
{
	public class JointPosition : Message
    {
        [JsonIgnore]
		public const string RosMessageName = "iiwa_msgs/JointPosition";

		public Standard.Header header;
		JointQuantity position;

		public JointPosition()
        {
			header = new Standard.Header();
			position = new JointQuantity();
        }
    }
}
