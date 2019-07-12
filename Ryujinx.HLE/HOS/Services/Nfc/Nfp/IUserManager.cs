﻿namespace Ryujinx.HLE.HOS.Services.Nfc.Nfp
{
    [Service("nfp:user")]
    class IUserManager : IpcService
    {
        public IUserManager(ServiceCtx context) { }

        [Command(0)]
        // CreateUserInterface() -> object<nn::nfp::detail::IUser>
        public long GetUserInterface(ServiceCtx context)
        {
            MakeObject(context, new IUser());

            return 0;
        }
    }
}