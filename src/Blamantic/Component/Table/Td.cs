﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BlamanticUI.Abstractions;

using Microsoft.AspNetCore.Components;

using YoiBlazor;

namespace BlamanticUI
{
    /// <summary>
    /// Render a td HTML tag represents a cell in one row.
    /// </summary>
    /// <seealso cref="BlamanticUI.Abstractions.BlamanticChildContentComponentBase" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasSelectable" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasState" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasActive" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasDisabled" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasHorizontalAlignment" />
    /// <seealso cref="BlamanticUI.Abstractions.IHasSpan" />
    [HtmlTag("td")]
    public class Td : BlamanticChildContentComponentBase, IHasSelectable, IHasState, IHasActive, IHasDisabled, IHasHorizontalAlignment, IHasSpan,IHasColor,IHasVerticalAlignment
    {
        /// <summary>
        /// Gets or sets the highlight color when row spanned.
        /// </summary>
        [Parameter] [CssClass("rowspanned")] public bool RowSpanned { get; set; }

        /// <summary>
        /// Gets or sets the marker style.
        /// </summary>
        [Parameter] [CssClass(" marked",Suffix =true)] public HorizontalPosition? Marked { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether hover style while cursor moving over items.
        /// </summary>
        /// <value>
        ///   <c>true</c> if selectable; otherwise, <c>false</c>.
        /// </value>
        [Parameter] public bool Selectable { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether collaps space of text in cell.
        /// </summary>
        [Parameter] [CssClass("collapsing")] public bool Collapsing { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [Parameter]public State? State { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this state is actived.
        /// </summary>
        /// <value>
        ///   <c>true</c> if actived; otherwise, <c>false</c>.
        /// </value>
        [Parameter]public bool Actived { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this is disabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if disabled; otherwise, <c>false</c>.
        /// </value>
        [Parameter]public bool Disabled { get; set; }
        /// <summary>
        /// Gets or sets the span of cell.
        /// </summary>
        [Parameter][CssClass(" wide",Suffix =true)]public ColSpan Span { get; set; }
        /// <summary>
        /// Gets or sets the horizontal alignment of text.
        /// </summary>
        [Parameter]public HorizontalAlignment? HorizontalAlignment { get; set; }
        /// <summary>
        /// Gets or sets the a callback method whether active state has changed.
        /// </summary>
        [Parameter]public EventCallback<bool> OnActived { get; set; }
        /// <summary>
        /// Gets or sets a callback method to invoke after <see cref="Disabled" /> changed.
        /// </summary>
        [Parameter]public EventCallback<bool> OnDisabled { get; set; }
        /// <summary>
        /// Gets or sets the color of cell.
        /// </summary>
        [Parameter]public Color? Color { get; set; }
        /// <summary>
        /// Gets or sets the vertical alignment of text.
        /// </summary>
        [Parameter]public VerticalAlignment? VerticalAlignment { get; set; }
    }
}
