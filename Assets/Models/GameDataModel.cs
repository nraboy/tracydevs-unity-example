using Realms;
using MongoDB.Bson;

public class GameDataModel : RealmObject
{

    [PrimaryKey]
    [MapTo("_id")]
    public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

    [Required]
    [MapTo("user_id")]
    public string UserId { get; set; }

    [MapTo("x")]
    public float X { get; set; }

    [MapTo("y")]
    public float Y { get; set; }

    [MapTo("score")]
    public int Score { get; set; }

}
