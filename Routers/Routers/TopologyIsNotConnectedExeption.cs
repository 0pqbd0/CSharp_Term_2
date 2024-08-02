namespace NetworkBuilder;

public class TopologyIsNotConnectedException : Exception
{
    public TopologyIsNotConnectedException() : base() 
    {

    }
    public TopologyIsNotConnectedException(string message) : base(message) 
    {

    }
}
