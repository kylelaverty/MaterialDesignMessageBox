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

        /// <summary>
        /// Displays a message box that has a message and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText)
        {
            return ShowDialogCore(null, messageBoxText, null, _defaultButton, null, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, null, _defaultButton, null, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message and title bar caption; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, null, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, null, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption and a specified button combination; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, null, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified button combination and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, null, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption and a specified icon; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, PackIconKind icon)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, icon, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified icon and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, _defaultButton, icon, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified button combination and a specified icon; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, icon, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified button combination, a specified icon and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(null, messageBoxText, caption, button, icon, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText)
        {
            return ShowDialogCore(owner, messageBoxText, null, _defaultButton, null, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, null, _defaultButton, null, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message and title bar caption; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, null, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, null, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption and a specified button combination; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, null, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified button combination and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, null, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption and a specified icon; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, PackIconKind icon)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, icon, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified icon and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, PackIconKind icon, PrimaryColor stylePrimaryColor)
        {
            return ShowDialogCore(owner, messageBoxText, caption, _defaultButton, icon, stylePrimaryColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified button combination and a specified icon; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
        public static MessageBoxResult ShowDialog(Window owner, string messageBoxText, string caption, MessageBoxButton button, PackIconKind icon)
        {
            return ShowDialogCore(owner, messageBoxText, caption, button, icon, _defaultColor);
        }

        /// <summary>
        /// Displays a message box that has a message, a title bar caption, a specified button combination, a specified icon and a button color scheme; and that returns a result.
        /// </summary>
        /// <param name="owner">A System.Windows.Window that represents the owner of the MessageBox</param>
        /// <param name="messageText">A System.String that specifies the text to display.</param>
        /// <param name="caption">A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">A System.Windows.MessageBoxButton value that specifies which button or buttons to display.</param>
        /// <param name="icon">A MaterialDesignThemes.Wpf.PackIconKind that specifies the icon to show to the left of the text.</param>
        /// <param name="stylePrimaryColor">A MaterialDesignColors.PrimaryColor that specifies the color sheme to use for the buttons.</param>
        /// <returns>A System.Windows.MessageBoxResult value that specifies which message box button is clicked by the user.</returns>
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
