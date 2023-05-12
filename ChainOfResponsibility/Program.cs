Send gmail = new Gmail();
Send yahoo = new Yahoo();

gmail.SetSuccessor( yahoo );
gmail.SendEmail("Gmail");
public abstract class Send
{
    protected Send send;
    public void SetSuccessor(Send send)
    {
        this.send = send;
    }


    public abstract void SendEmail(string ServiceName);
}

public class Gmail : Send
{
    public override void SendEmail(string ServiceName)
    {
        if (ServiceName == "Gmail")
        {
            Console.WriteLine("Email sended with Gmail");
        }
        else
        {
            send.SendEmail(ServiceName);
        }
    }
}


public class Yahoo : Send
{
    public override void SendEmail(string ServiceName)
    {

        Console.WriteLine("Email sended with Yahoo");


    }
}