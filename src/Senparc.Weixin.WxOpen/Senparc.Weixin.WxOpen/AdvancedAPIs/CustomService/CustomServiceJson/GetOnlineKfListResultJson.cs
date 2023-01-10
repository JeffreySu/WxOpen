﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2023 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2023 Senparc

    文件名：GetOnlineKfListResultJson.cs
    文件功能描述：在线客户列表获取结果


    创建标识：mc7246 - 20220710

----------------------------------------------------------------*/

using Senparc.Weixin.Entities;
using System.Collections.Generic;

namespace Senparc.Weixin.WxOpen.AdvancedAPIs.CustomService
{
    /// <summary>
    /// 在线客户列表获取结果
    /// </summary>
    public class GetOnlineKfListResultJson : WxJsonResult
    {
        public List<OnlineKfInfo> kf_online_list { get; set; }
    }

    public class OnlineKfInfo
    {
        public string kf_account { get; set; }

        public int status { get; set; }

        public string kf_id { get; set; }

        public string kf_openid { get; set; }
    }
}
