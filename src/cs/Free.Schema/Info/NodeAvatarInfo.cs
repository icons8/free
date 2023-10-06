namespace Free.Schema;

public record NodeAvatarInfo : INodeInfo
{
    public NodeAvatarInfo()
    {
        
    }
    public NodeAvatarInfo(AvatarType avatarType, string avatarPhotoId)
    {
        AvatarType = avatarType;
        AvatarPhotoId = avatarPhotoId;
    }

    public AvatarType AvatarType { get; set; }
    public string? AvatarPhotoId { get; set; }
}