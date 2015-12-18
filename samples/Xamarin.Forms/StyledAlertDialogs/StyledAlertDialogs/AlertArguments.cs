using System;
using System.Threading.Tasks;

namespace StyledAlertDialogs
{
	public class AlertArguments
	{
		public AlertArguments()
		{
			Result = new TaskCompletionSource<bool> ();
		}

		public string Title { get; set; }
		public string Message { get; set; }
		public string Accept { get; set; }
		public string Cancel { get; set; }
		public TaskCompletionSource<bool> Result { get; set; }
		public void SetResult (bool result)
		{
			Result.TrySetResult (result);
		}
	}
}