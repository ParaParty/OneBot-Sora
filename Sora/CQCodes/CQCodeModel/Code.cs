using Newtonsoft.Json;
using Sora.Converter;
using Sora.Enumeration;

namespace Sora.CQCodes.CQCodeModel
{
    /// <summary>
    /// <para>Xml与Json集合</para>
    /// <para>可能为<see cref="CQFunction"/>.<see langword="Json"/>或<see cref="CQFunction"/>.<see langword="Xml"/></para>
    /// </summary>
    public struct Code
    {
        #region 属性
        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Content { get; internal set; }

        /// <summary>
        /// 是否走富文本通道
        /// </summary>
        [JsonConverter(typeof(StringConverter))]
        [JsonProperty(PropertyName = "resid",NullValueHandling = NullValueHandling.Ignore)]
        public int? Resid { get; internal set; }
        #endregion
    }
}