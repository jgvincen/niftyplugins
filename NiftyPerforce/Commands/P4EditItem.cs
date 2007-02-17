using System;
using EnvDTE;
using EnvDTE80;

namespace Aurora
{
	namespace NiftyPerforce
	{
		class P4EditItem : ItemCommandBase
		{
            public override void OnExecute(SelectedItem item, string fileName, OutputWindowPane pane)
            {
                P4Operations.EditFile(pane, fileName);
            }
		}
	}
}
