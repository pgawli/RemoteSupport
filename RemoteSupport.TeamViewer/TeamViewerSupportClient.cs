using System;

namespace RemoteSupport.TeamViewer
{
    public class TeamViewerSupportClient : IRemoteAccessClient
    {
        public bool IsInstalled => throw new NotImplementedException();

        public bool InstalationIsNeeded => throw new NotImplementedException();

        public bool Acticvate()
        {
            throw new NotImplementedException();
        }

        public bool Download(string localPath)
        {
            throw new NotImplementedException();
        }
    }
}
