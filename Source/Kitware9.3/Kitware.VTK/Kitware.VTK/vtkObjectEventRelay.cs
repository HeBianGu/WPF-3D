using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Implement a relay handler for VTK events. This is a class
	/// that receives events directly from the VTK object sender and
	/// transforms them into calls to .NET delegates.
	/// </summary>
	// Token: 0x02000B73 RID: 2931
	public class vtkObjectEventRelay : WrappedObject
	{
		/// <summary>
		/// Type registration mechanics.
		/// </summary>
		// Token: 0x0601E9D8 RID: 125400 RVA: 0x002B6880 File Offset: 0x002B4A80
		static vtkObjectEventRelay()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObjectEventRelay.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObjectEventRelay"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E9D9 RID: 125401 RVA: 0x002B68A8 File Offset: 0x002B4AA8
		public vtkObjectEventRelay(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E9DA RID: 125402
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObjectEventRelay_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkObjectEventRelay object that will call "handler" when its
		/// Execute method gets called. Typically, it is not necessary to create
		/// instances of vtkObjectEventRelay from client applications. Usually, clients
		/// will just connect to ActiViz.NET events, which use vtkObjectEventRelay
		/// internally. However, vtkObjectEventRelay is suitable for use as the
		/// vtkCommand parameter to AddObserver calls.
		/// </summary>
		// Token: 0x0601E9DB RID: 125403 RVA: 0x002B68B8 File Offset: 0x002B4AB8
		public vtkObjectEventRelay(vtkObject sender, uint eventId) : base(IntPtr.Zero, true, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkObjectEventRelay.vtkObjectEventRelay_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
			this.Sender = sender;
			this.EventId = eventId;
		}

		// Token: 0x0601E9DC RID: 125404
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObjectEventRelay_Delete(HandleRef pThis);

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E9DD RID: 125405 RVA: 0x002B690C File Offset: 0x002B4B0C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkObjectEventRelay.vtkObjectEventRelay_Delete(base.GetCppThis());
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0601E9DE RID: 125406
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkObjectEventRelay_AddObserver(HandleRef pThis, HandleRef sender, uint eventid, vtkObjectEventRelay.RelayHandler handler, float priority);

		// Token: 0x0601E9DF RID: 125407 RVA: 0x002B695C File Offset: 0x002B4B5C
		private uint AddObserver()
		{
			if (null == this.RelayHandlerDelegate)
			{
				this.RelayHandlerDelegate = new vtkObjectEventRelay.RelayHandler(this.Execute);
			}
			return vtkObjectEventRelay.vtkObjectEventRelay_AddObserver(base.GetCppThis(), (this.Sender == null) ? default(HandleRef) : this.Sender.GetCppThis(), this.EventId, this.RelayHandlerDelegate, 0f);
		}

		// Token: 0x0601E9E0 RID: 125408
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkObjectEventRelay_RemoveObserver(HandleRef pThis, uint observerId);

		// Token: 0x0601E9E1 RID: 125409 RVA: 0x002B69CF File Offset: 0x002B4BCF
		private void RemoveObserver(uint observerId)
		{
			vtkObjectEventRelay.vtkObjectEventRelay_RemoveObserver(base.GetCppThis(), observerId);
		}

		// Token: 0x0601E9E2 RID: 125410 RVA: 0x002B69E0 File Offset: 0x002B4BE0
		private void CallAddObserver()
		{
			if (this.ObserverId == 0U && this.Sender != null && IntPtr.Zero != this.Sender.GetCppThis().Handle)
			{
				this.ObserverId = this.AddObserver();
			}
		}

		// Token: 0x0601E9E3 RID: 125411 RVA: 0x002B6A34 File Offset: 0x002B4C34
		private void CallRemoveObserver()
		{
			if (this.ObserverId != 0U && this.Sender != null && IntPtr.Zero != this.Sender.GetCppThis().Handle)
			{
				this.RemoveObserver(this.ObserverId);
				this.ObserverId = 0U;
			}
		}

		/// <summary>
		/// Do not call directly. This method is called from VTK library code when
		/// InvokeEvent is called on a vtkObject.
		/// </summary>
		// Token: 0x0601E9E4 RID: 125412 RVA: 0x002B6A90 File Offset: 0x002B4C90
		public void Execute(IntPtr caller, uint eventId, IntPtr callData)
		{
			if (null != this.EventImpl)
			{
				bool flag;
				vtkObject caller2 = (vtkObject)Methods.CreateWrappedObject(0U, uint.MaxValue, 4294967208U, caller, true, out flag);
				this.EventImpl(this.Sender, new vtkObjectEventArgs(caller2, eventId, callData));
			}
		}

		/// <summary>
		/// AddHandler adds a managed/.NET event handler to this event relay object.
		/// If this is the first time a handler is being added, we call AddObserver
		/// so that the underlying VTK object will invoke the event from now on.
		/// </summary>
		// Token: 0x0601E9E5 RID: 125413 RVA: 0x002B6ADC File Offset: 0x002B4CDC
		public void AddHandler(vtkObject.vtkObjectEventHandler handler)
		{
			if (null == this.EventImpl)
			{
				this.CallAddObserver();
			}
			this.EventImpl = (vtkObject.vtkObjectEventHandler)Delegate.Combine(this.EventImpl, handler);
		}

		/// <summary>
		/// RemoveHandler removes a managed/.NET event handler previously added to
		/// this event relay object.
		/// If this is the last handler being removed, we call RemoveObserver
		/// so that the underlying VTK object will no longer send the event to us.
		/// </summary>
		// Token: 0x0601E9E6 RID: 125414 RVA: 0x002B6B1C File Offset: 0x002B4D1C
		public void RemoveHandler(vtkObject.vtkObjectEventHandler handler)
		{
			this.EventImpl = (vtkObject.vtkObjectEventHandler)Delegate.Remove(this.EventImpl, handler);
			if (null == this.EventImpl)
			{
				this.CallRemoveObserver();
			}
		}

		/// <summary>
		/// HasHandlers returns true if this event presently has any managed/.NET
		/// handlers.
		/// </summary>
		// Token: 0x0601E9E7 RID: 125415 RVA: 0x002B6B5C File Offset: 0x002B4D5C
		public bool HasHandlers()
		{
			return null != this.EventImpl;
		}

		/// <summary>
		/// RemoveAllHandlers forcibly removes all existing handlers from its list.
		/// Sender should call this method from its Dispose if it has one.
		/// </summary>
		// Token: 0x0601E9E8 RID: 125416 RVA: 0x002B6B7A File Offset: 0x002B4D7A
		public void RemoveAllHandlers()
		{
			this.CallRemoveObserver();
			this.EventImpl = null;
			this.Sender = null;
		}

		/// <summary>
		/// Type registration mechanics.
		/// </summary>
		// Token: 0x040020C8 RID: 8392
		public new const string MRFullTypeName = "Kitware.VTK.vtkObjectEventRelay";

		/// <summary>
		/// Type registration mechanics.
		/// </summary>
		// Token: 0x040020C9 RID: 8393
		public new static readonly string MRClassNameKey = "class vtkObjectEventRelay";

		// Token: 0x040020CA RID: 8394
		private vtkObject Sender;

		// Token: 0x040020CB RID: 8395
		private uint EventId;

		// Token: 0x040020CC RID: 8396
		private vtkObject.vtkObjectEventHandler EventImpl;

		// Token: 0x040020CD RID: 8397
		private uint ObserverId;

		// Token: 0x040020CE RID: 8398
		private vtkObjectEventRelay.RelayHandler RelayHandlerDelegate;

		/// <summary>
		/// Signature for method that vtkObject can call for VTK events.
		/// </summary>
		// Token: 0x02000B74 RID: 2932
		// (Invoke) Token: 0x0601E9EA RID: 125418
		public delegate void RelayHandler(IntPtr caller, uint eventId, IntPtr callData);
	}
}
