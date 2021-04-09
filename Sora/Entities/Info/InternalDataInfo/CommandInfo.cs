using System;
using System.Reflection;
using System.Text.RegularExpressions;
using Sora.Enumeration.EventParamsType;
using YukariToolBox.Extensions;

namespace Sora.Entities.Info.InternalDataInfo
{
    /// <summary>
    /// 指令信息
    /// </summary>
    internal readonly struct CommandInfo
    {
        #region 属性

        /// <summary>
        /// 指令描述
        /// </summary>
        internal string Desc { get; }

        /// <summary>
        /// 匹配指令的正则
        /// </summary>
        internal string[] Regex { get; }

        /// <summary>
        /// 指令组名
        /// </summary>
        internal string GroupName { get; }

        /// <summary>
        /// 指令回调方法
        /// </summary>
        internal MethodInfo MethodInfo { get; }

        /// <summary>
        /// 权限限制
        /// </summary>
        internal MemberRoleType? PermissonType { get; }

        /// <summary>
        /// 执行实例
        /// </summary>
        internal Type InstanceType { get; }

        /// <summary>
        /// 优先级
        /// </summary>
        internal int Priority { get; }

        /// <summary>
        /// 正则匹配选项
        /// </summary>
        internal RegexOptions RegexOptions { get; }

        #endregion

        #region 构造方法

        /// <summary>
        /// 指令信息构造
        /// </summary>
        internal CommandInfo(string desc, string[] regex, string groupName, MethodInfo method,
                             MemberRoleType? permissonType, int priority, RegexOptions regexOptions,
                             Type instanceType = null)
        {
            Desc          = desc;
            Regex         = regex;
            GroupName     = groupName;
            MethodInfo    = method;
            InstanceType  = instanceType;
            PermissonType = permissonType;
            Priority      = priority;
            RegexOptions  = regexOptions;
        }

        #endregion

        internal bool Equals(CommandInfo another)
        {
            return MethodInfo.Name == another.MethodInfo.Name
                && MethodInfo.GetGenericArguments().ArrayEquals(another.MethodInfo.GetGenericArguments())
                && Regex.ArrayEquals(another.Regex)
                && PermissonType == another.PermissonType
                && Priority      == another.Priority;
        }
    }
}