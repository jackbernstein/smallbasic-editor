// <copyright file="JSInterop.Generated.cs" company="2018 Omar Tawfik">
// Copyright (c) 2018 Omar Tawfik. All rights reserved. Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
namespace SuperBasic.Editor.Interop
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.JSInterop;
    using SuperBasic.Compiler.Services;

    internal static class JSInterop
    {
        public static class Layout
        {
            public static async Task InitializeWebView(string locale, string title)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Layout.initializeWebView", locale, title).ConfigureAwait(false);
            }

            public static async Task OpenExternalLink(string url)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Layout.openExternalLink", url).ConfigureAwait(false);
            }

            public static async Task AttachSideBarEvents(ElementRef upButton, ElementRef scrollContentsArea, ElementRef downButton)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Layout.attachSideBarEvents", upButton, scrollContentsArea, downButton).ConfigureAwait(false);
            }
        }

        public static class Monaco
        {
            public static async Task Initialize(ElementRef editorElement, string initialValue, bool isReadOnly)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.initialize", editorElement, initialValue, isReadOnly).ConfigureAwait(false);
            }

            public static async Task Dispose()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.dispose").ConfigureAwait(false);
            }

            public static async Task SelectRange(MonacoRange range)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.selectRange", range).ConfigureAwait(false);
            }

            public static async Task SaveToFile()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.saveToFile").ConfigureAwait(false);
            }

            public static async Task OpenFile(string confirmationMessage)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.openFile", confirmationMessage).ConfigureAwait(false);
            }

            public static async Task ClearEditor(string confirmationMessage)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.clearEditor", confirmationMessage).ConfigureAwait(false);
            }

            public static async Task Cut()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.cut").ConfigureAwait(false);
            }

            public static async Task Copy()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.copy").ConfigureAwait(false);
            }

            public static async Task Paste()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.paste").ConfigureAwait(false);
            }

            public static async Task Undo()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.undo").ConfigureAwait(false);
            }

            public static async Task Redo()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.Monaco.redo").ConfigureAwait(false);
            }
        }

        public static class TextDisplay
        {
            public static async Task Initialize(ElementRef textDisplayElement)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.initialize", textDisplayElement).ConfigureAwait(false);
            }

            public static async Task Dispose()
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.dispose").ConfigureAwait(false);
            }

            public static async Task ScrollTo(ElementRef element)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.scrollTo", element).ConfigureAwait(false);
            }

            public static async Task SetBackgroundColor(string hexColor)
            {
                await JSRuntime.Current.InvokeAsync<bool>("JSInterop.TextDisplay.setBackgroundColor", hexColor).ConfigureAwait(false);
            }
        }
    }
}