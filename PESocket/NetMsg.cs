using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PENet;

namespace PENet
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class NetMsg : PEMsg
    {
        /// <summary>
        /// 
        /// </summary>
        public OpCode Code;
        /// <summary>
        /// 
        /// </summary>
        public string Text;
        /// <summary>
        /// 
        /// </summary>
        public int Volume;
        /// <summary>
        /// 
        /// </summary>
        public int Operation;
    }
}
