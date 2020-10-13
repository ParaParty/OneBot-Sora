using System;
using Sora.EventArgs.OnebotEvent.NoticeEvent;
using Sora.Module;

namespace Sora.EventArgs.SoraEvent
{
    public sealed class FriendAddEventArgs : BaseSoraEventArgs
    {
        #region 属性
        /// <summary>
        /// 新好友
        /// </summary>
        public User NewFriend { get; private set; }
        #endregion

        #region 构造函数
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="connectionGuid">服务器链接标识</param>
        /// <param name="eventName">事件名</param>
        /// <param name="friendAdd">API好友添加事件参数</param>
        internal FriendAddEventArgs(Guid connectionGuid, string eventName, ApiFriendAddEventArgs friendAdd) :
            base(connectionGuid, eventName, friendAdd.SelfID, friendAdd.Time)
        {
            this.NewFriend = new User(connectionGuid, friendAdd.UserId);
        }
        #endregion
    }
}