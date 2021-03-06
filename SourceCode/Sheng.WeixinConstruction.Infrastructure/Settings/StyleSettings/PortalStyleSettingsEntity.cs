﻿using Linkup.DataRelationalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    /// <summary>
    /// 设置需要独立保存，这样才能兼容独立运行模式和第三方平台运营模式
    /// </summary>
    [Table("StyleSettings")]
    public class PortalStyleSettingsEntity
    {
        [Key]
        public Guid Domain
        {
            get;
            set;
        }

        [Key]
        public string AppId
        {
            get;
            set;
        }

        public string PortalImageUrl
        {
            get;
            set;
        }

        private EnumPortalMode _portalMode = EnumPortalMode.Template;
        public EnumPortalMode PortalMode
        {
            get { return _portalMode; }
            set { _portalMode = value; }
        }

        public Guid? PortalPresetTemplateId
        {
            get;
            set;
        }

        public string PortalCustomTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// 根据PortalPresetTemplateId取出的预置模版
        /// </summary>
        [NotMapped]
        public PortalPresetTemplateEntity PortalPresetTemplate
        {
            get;
            set;
        }
    }
}
