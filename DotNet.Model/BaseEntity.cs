//-----------------------------------------------------------------
// All Rights Reserved , Copyright (C) 2012 , Hairihan TECH, Ltd. 
//-----------------------------------------------------------------

using System;
using System.Data;

namespace DotNet.Model
{
    [Serializable]
    public class BaseEntity
    {
        /// <summary>
        /// 从数据行读取
        /// </summary>
        /// <param name="dataRow">数据行</param>
        public virtual void GetFromExpand(DataRow dataRow)
        {
        }

        /// <summary>
        /// 从数据流读取
        /// </summary>
        /// <param name="dataReader">数据流</param>
        public virtual void GetFromExpand(IDataReader dataReader)
        {
        }
    }
}