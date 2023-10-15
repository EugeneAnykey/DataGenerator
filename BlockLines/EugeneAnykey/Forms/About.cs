namespace EugeneAnykey.Forms
{
    /// <summary>
    /// Fast About window
    /// </summary>
    public static class About
    {
        #region fields
        /// <summary>
        /// A string representing the release date
        /// </summary>
        /// <example>"1999-12-31"</example>
        public static string Date { get; set; } = "[unknown]";
        /// <summary>
        /// Basic copyright info. A date and company name for example
        /// </summary>
        /// <example>1998-1999 Unknown Software Company</example>
        public static string Copyright { get; set; } = "";
        /// <summary>
        /// Additional line placed in About window title
        /// </summary>
        public static string Extra { get; set; } = "";
        #endregion


        /// <summary>
        /// Shows message box window with application info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Show(object? sender, EventArgs e)
        {
            var Title = Extra.Length > 0 ? $"About {Application.ProductName} {Extra}" : $"About {Application.ProductName}";
            var CopyrightInfo = Copyright.Length > 0 ? $"\n\n© {Copyright}.\nAll rights reserved." : "";

            MessageBox.Show(
                $"{Application.ProductName}\nVersion {Application.ProductVersion} ({Date}){CopyrightInfo}",
                Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
