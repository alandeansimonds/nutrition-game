//using System.Collections;

public class PersistencePayload
{
    // int(11)
    public int playerId;
    // varchar(64)
    public string recordName;
    // varchar(7500)
    public string recordValue;

    public PersistencePayload(int playerId, string recordName, string recordValue)
    {
        this.playerId = playerId;
        this.recordName = recordName;
        this.recordValue = recordValue;
    }
}
