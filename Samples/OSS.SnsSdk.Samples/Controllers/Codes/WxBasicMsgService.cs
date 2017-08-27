﻿using OSS.Common.Plugs.LogPlug;
using OSS.SnsSdk.Msg.Wx;
using OSS.SnsSdk.Msg.Wx.Mos;
using OSS.SocialSDK.WX.Msg;
using OSS.SocialSDK.WX.Msg.Mos;

namespace OSS.SocialSDK.Samples.Controllers.Codes
{
    public class WxBasicMsgService: WxMsgHandler
    {
        public WxBasicMsgService(WxMsgServerConfig mConfig) : base(mConfig)
        {
            TextHandler += WxBasicMsgService_TextHandler;
        }

        private BaseReplyMsg WxBasicMsgService_TextHandler(TextRecMsg arg)
        {
            if (arg.Content=="oss")
            {
                return new TextReplyMsg() { Content = "欢迎关注.Net开源世界！" };
            }
            return null;
        }

        protected override void ProcessEnd(MsgContext msgContext)
        {
            LogUtil.Info(msgContext.RecMsg.RecMsgXml?.OuterXml);
        }
    }
}