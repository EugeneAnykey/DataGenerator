using System.Windows.Forms.Design;

namespace EugeneAnykey.Forms.Controls.Designers
{
	public class Designer : ScrollableControlDesigner
	{
		protected override void PreFilterProperties(System.Collections.IDictionary properties)
		{
			properties.Remove("Dock");
			base.PreFilterProperties(properties);
		}
	}
}
