using System;

namespace RemoteSupport
{
    public interface IRemoteAccessClient
    {
        bool IsInstalled { get; }
        bool InstalationIsNeeded { get; }
        bool Download(string localPath);
        bool Acticvate();
    }
}
