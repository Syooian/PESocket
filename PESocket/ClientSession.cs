using PENet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PENet
{
    public class ClientSession : PESession<NetMsg>
    {
        /// <summary>
        /// 
        /// </summary>
        protected override void OnConnected()
        {
            Console.WriteLine("已連線至Server");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Msg"></param>
        protected override void OnReciveMsg(NetMsg Msg)
        {
            base.OnReciveMsg(Msg);

            Console.WriteLine("接收訊息 Code : " + Msg.Code + ", Text : " + Msg.Text + ", Volume : " + Msg.Volume + ", Operation : " + Msg.Operation);
        }

        protected override void OnDisConnected()
        {
            Console.WriteLine("連線已中斷");
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum OpCode
    {
        None = 0,
        PlayVideo = 1,
        PlayVolume = 2,
        PPTOperation = 3,
        Mechanical = 4,
        Dmx = 5,
        Availed = 6
    }
}
