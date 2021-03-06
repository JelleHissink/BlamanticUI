﻿using System.Linq;
using System.Threading.Tasks;

using BlamanticUI.Abstractions;
using Microsoft.AspNetCore.Components.Forms;

namespace BlamanticUI
{
    /// <summary>
    /// The extensions.
    /// </summary>
    public static class Exntensions
    {
        /// <summary>
        /// onclick event。
        /// </summary>
        public const string EVENT_CLICK = "onclick";

        /// <summary>
        /// Get the <see cref="FieldIdentifier"/> instance of <see cref="State"/>.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="fieldIdentifier">The field identifier.</param>
        /// <param name="recoverOnValid">if set to <c>true</c> [recover on valid].</param>
        /// <returns></returns>
        public static State? GetState(this EditContext context, in FieldIdentifier fieldIdentifier,bool recoverOnValid=false)
        {
            if (context != null)
            {
                var isInvalid = context.GetValidationMessages(fieldIdentifier).Any();
                if (context.IsModified(fieldIdentifier))
                {
                    if (isInvalid)
                    {
                        return State.Error;
                    }
                    else if (!recoverOnValid)
                    {
                        return State.Success;
                    }
                }
                return default;
            }
            return default;
        }

        /// <summary>
        /// Perform the active action
        /// </summary>
        /// <param name="instance">The instance of <see cref="IHasActive"/>.</param>
        /// <param name="active">the active status.</param>
        public static async Task Active(this IHasActive instance, bool active = true)
        {
            instance.Actived = active;
            await instance.OnActived.InvokeAsync(active);
            instance.NotifyStateChanged();
        }

        /// <summary>
        /// Perform the disable action.
        /// </summary>
        /// <param name="instance">The instance of <see cref="IHasDisabled"/>.</param>
        /// <param name="disabled">the disabled status.</param>
        public static async Task Disable(this IHasDisabled instance, bool disabled = true)
        {
            instance.Disabled = disabled;
            await instance.OnDisabled.InvokeAsync(disabled);
            instance.NotifyStateChanged();
        }
    }
}
