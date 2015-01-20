﻿
namespace Anycmd.Ac.ViewModels.PrivilegeViewModels
{
    using Engine;
    using Engine.Ac.InOuts;
    using Engine.Ac.Messages;
    using System;

    /// <summary>
    /// 创建权限二元组时的输入或输出参数类型。
    /// </summary>
    public class PrivilegeCreateIo : EntityCreateInput, IPrivilegeCreateIo
    {
        public PrivilegeCreateIo()
        {
            HecpOntology = "Privilege";
            HecpVerb = "Create";
        }

        public string SubjectType { get; set; }

        public Guid SubjectInstanceId { get; set; }

        public string ObjectType { get; set; }

        public Guid ObjectInstanceId { get; set; }

        public string AcContent { get; set; }

        public string AcContentType { get; set; }

        public override IAnycmdCommand ToCommand(IUserSession userSession)
        {
            return new AddPrivilegeCommand(userSession, this);
        }
    }
}