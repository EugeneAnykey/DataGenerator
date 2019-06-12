using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EugeneAnykey.Forms.Controls.Designers
{
	public class MyControlDesigner : ParentControlDesigner
	{
		public override void Initialize(System.ComponentModel.IComponent component)
		{
			base.Initialize(component);
			
			if (this.Control is CollapsableControl)
				this.EnableDesignMode(((CollapsableControl)this.Control).WorkingArea, "WorkingArea");
		}
		
		public override bool CanParent(ControlDesigner controlDesigner)
		{
			return (controlDesigner != null && controlDesigner.Control is Control);
		}
	}
}
