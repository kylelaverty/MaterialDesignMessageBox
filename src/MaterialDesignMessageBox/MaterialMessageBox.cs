using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace MaterialDesignMessageBox
{
    public static class MaterialMessageBox
    {
        private const MessageBoxButton _defaultButton = MessageBoxButton.OK;
        internal const PrimaryColor _defaultColor = PrimaryColor.Blue;

        public static MessageBoxResult ShowDialog(string messageBoxText)
        {
            return ShowDialogCore(null, messageBoxText, null, _defaultButton, null, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, null, _defaultButton, null, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, null, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, null, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, null, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, null, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, PackIconKind icon)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, icon, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, icon, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, icon, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, icon, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText)
        {
            return ShowDialogCore(owner, messageBoxText, null, _defaultButton, null, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, null, _defaultButton, null, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, null, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, null, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, null, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, null, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, PackIconKind icon)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, icon, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, icon, stylePrimaryColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, icon, _defaultColor);
        }
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, icon, stylePrimaryColor);
        }
        private static MessageBoxResult ShowDialogCore(Window owner, string messageBoxText, string caption, MessageBoxButton button, PackIconKind? icon, PrimaryColor stylePrimaryColor)
        {
            // Setup new messagebox
            var messageBox = new MaterialDesignMessageBoxWindow(owner, messageBoxText, caption, button, icon, stylePrimaryColor);
            messageBox.ShowDialog();
            return messageBox.Result;
        }
    }
}
