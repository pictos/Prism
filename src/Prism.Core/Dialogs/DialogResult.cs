﻿using System;

#nullable enable
namespace Prism.Dialogs;

/// <summary>
/// An <see cref="IDialogResult"/> that contains <see cref="IDialogParameters"/> from the dialog
/// and the <see cref="ButtonResult"/> of the dialog.
/// </summary>
public class DialogResult : IDialogResult
{
    /// <summary>
    /// An <see cref="System.Exception"/> that was thrown by the DialogService
    /// </summary>
    public Exception? Exception { get; set; }

    /// <summary>
    /// The parameters from the dialog.
    /// </summary>
    public IDialogParameters Parameters { get; set; } = new DialogParameters();

    /// <summary>
    /// The result of the dialog.
    /// </summary>
    public ButtonResult Result { get; set; } = ButtonResult.None;
}
