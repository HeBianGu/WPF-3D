using System;

namespace Kitware.VTK
{
	/// <summary>
	/// The sender of each ActiViz.NET event passes itself as its "sender"
	/// parameter and an instance of vtkObjectEventArgs as its "e" parameter.
	/// </summary>
	// Token: 0x02000B72 RID: 2930
	public class vtkObjectEventArgs : EventArgs
	{
		/// <summary>
		/// Each ActiViz.NET event automatically constructs a vtkObjectEventArgs to
		/// pass to its handlers. Client ActiViz.NET applications do not need to
		/// call this vtkObjectEventArgs constructor.
		/// </summary>
		// Token: 0x0601E9D4 RID: 125396 RVA: 0x002B6817 File Offset: 0x002B4A17
		public vtkObjectEventArgs(vtkObject caller, uint eventId, IntPtr callData)
		{
			this.m_Caller = caller;
			this.m_EventId = eventId;
			this.m_CallData = callData;
		}

		/// <summary>
		/// Caller is the object that invoked the event. Usually it is the same
		/// object as the event handler's "sender" parameter.
		/// </summary>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0601E9D5 RID: 125397 RVA: 0x002B6838 File Offset: 0x002B4A38
		public vtkObject Caller
		{
			get
			{
				return this.m_Caller;
			}
		}

		/// <summary>
		/// EventId is usually a value in the vtkCommand.EventIds enum. It is
		/// primarily useful for handlers of the "Any" event. The "Any" event
		/// fires whenever any other event is invoked from a given vtkObject. In
		/// that case, the EventId passed with the event indicates the actual
		/// event that was invoked.
		///
		/// It is also useful in the case of user defined events, where the event
		/// id value is outside the pre-defined range of vtkCommand.EventIds.
		/// </summary>
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0601E9D6 RID: 125398 RVA: 0x002B6850 File Offset: 0x002B4A50
		public uint EventId
		{
			get
			{
				return this.m_EventId;
			}
		}

		/// <summary>
		/// CallData varies based on what event is firing. It is frequently
		/// IntPtr.Zero (NULL from C++)... If non-zero, see the documentation
		/// of the specific event for the type of the data.
		/// </summary>
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0601E9D7 RID: 125399 RVA: 0x002B6868 File Offset: 0x002B4A68
		public IntPtr CallData
		{
			get
			{
				return this.m_CallData;
			}
		}

		// Token: 0x040020C5 RID: 8389
		private vtkObject m_Caller;

		// Token: 0x040020C6 RID: 8390
		private uint m_EventId;

		// Token: 0x040020C7 RID: 8391
		private IntPtr m_CallData;
	}
}
