using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PostSharp.Aspects;

namespace PostSharpExeptionHandling
{
	[Serializable]
	class ApplicationException : OnExceptionAspect
	{
		public override void OnException(MethodExecutionArgs args)
		{
			MessageBox.Show(args.Exception.Message);
			args.FlowBehavior = FlowBehavior.Continue;
		}
	}
}
