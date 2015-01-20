﻿
namespace Anycmd.Ac.ViewModels.RdbViewModels
{
    using Engine;
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 数据库视图输入模型
    /// </summary>
    public sealed class DbViewUpdateInput : IInputModel
    {
        public DbViewUpdateInput()
        {
            OntologyCode = "DbView";
            Verb = "Update";
        }

        public string OntologyCode { get; private set; }

        public string Verb { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Guid DatabaseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        // TODO:走CommandBus
    }
}