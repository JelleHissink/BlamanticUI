﻿
using BlamanticUI.Abstractions;

using Microsoft.AspNetCore.Components;

using YoiBlazor;

namespace BlamanticUI
{
    /// <summary>
    /// 表示带有超链接的图像。
    /// </summary>
    /// <seealso cref="BlamanticUI.Anchor" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasUIComponent" />
    [CssClass("image")]
    public class ImageAnchor : Anchor, IHasUIComponent,IHasSize
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAnchor"/> class.
        /// </summary>
        public ImageAnchor()
        {
        }

        /// <summary>
        /// 设置包含的 <see cref="Image"/> 的尺寸大小。
        /// </summary>
        [Parameter]public Size? Size { get; set; }
    }
}