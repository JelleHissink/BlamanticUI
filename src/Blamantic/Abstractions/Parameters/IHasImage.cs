﻿
using YoiBlazor;

namespace BlamanticUI.Abstractions
{
    /// <summary>
    /// 表示能显示图像的组件。
    /// </summary>
    public interface IHasImage
    {
        /// <summary>
        /// 设置子组件包含 <see cref="BlamanticUI.Image"/> 组件显示图像。
        /// </summary>
        [CssClass("image")] bool Image { get; set; }
    }
}
