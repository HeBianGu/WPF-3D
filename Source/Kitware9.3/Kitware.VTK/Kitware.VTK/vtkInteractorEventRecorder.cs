using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInteractorEventRecorder
	/// </summary>
	/// <remarks>
	///    record and play VTK events passing through a vtkRenderWindowInteractor
	///
	///
	/// vtkInteractorEventRecorder records all VTK events invoked from a
	/// vtkRenderWindowInteractor. The events are recorded to a
	/// file. vtkInteractorEventRecorder can also be used to play those events
	/// back and invoke them on an vtkRenderWindowInteractor. (Note: the events
	/// can also be played back from a file or string.)
	///
	/// Event client data can be recorded as args and will be provided on replay.
	/// The following event current support data to be recorded:
	///  - DropFilesEvents: record a string array
	///
	/// The format of the event file is simple. It is:
	///  EventName X Y ctrl shift keycode repeatCount keySym dataType [dataNum] [dataVal] [dataVal]
	/// The format also allows "#" comments.
	/// dataType is defined as follows:
	///  - 0 -&gt; None
	///  - 1 -&gt; StringArray
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorObserver vtkCallback
	/// </seealso>
	// Token: 0x020007EA RID: 2026
	public class vtkInteractorEventRecorder : vtkInteractorObserver
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014D7A RID: 85370 RVA: 0x001D7BE1 File Offset: 0x001D5DE1
		static vtkInteractorEventRecorder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorEventRecorder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorEventRecorder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014D7B RID: 85371 RVA: 0x001D7C09 File Offset: 0x001D5E09
		public vtkInteractorEventRecorder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014D7C RID: 85372
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorEventRecorder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D7D RID: 85373 RVA: 0x001D7C18 File Offset: 0x001D5E18
		public new static vtkInteractorEventRecorder New()
		{
			vtkInteractorEventRecorder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorEventRecorder.vtkInteractorEventRecorder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D7E RID: 85374 RVA: 0x001D7C6C File Offset: 0x001D5E6C
		public vtkInteractorEventRecorder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInteractorEventRecorder.vtkInteractorEventRecorder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014D7F RID: 85375 RVA: 0x001D7CB0 File Offset: 0x001D5EB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014D80 RID: 85376
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_Clear_01(HandleRef pThis);

		/// <summary>
		/// Invoke this method to clear recording/playing stream and be able to open
		/// another file using the same recorder.
		/// </summary>
		// Token: 0x06014D81 RID: 85377 RVA: 0x001D7CBB File Offset: 0x001D5EBB
		public void Clear()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Clear_01(base.GetCppThis());
		}

		// Token: 0x06014D82 RID: 85378
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorEventRecorder_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of a file events should be written to/from.
		/// Will be ignored once record/play has been called.
		/// </summary>
		// Token: 0x06014D83 RID: 85379 RVA: 0x001D7CCC File Offset: 0x001D5ECC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014D84 RID: 85380
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorEventRecorder_GetInputString_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the string to read from.
		/// </summary>
		// Token: 0x06014D85 RID: 85381 RVA: 0x001D7D08 File Offset: 0x001D5F08
		public virtual string GetInputString()
		{
			string s = Marshal.PtrToStringAnsi(vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetInputString_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014D86 RID: 85382
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorEventRecorder_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D87 RID: 85383 RVA: 0x001D7D44 File Offset: 0x001D5F44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014D88 RID: 85384
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInteractorEventRecorder_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D89 RID: 85385 RVA: 0x001D7D64 File Offset: 0x001D5F64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014D8A RID: 85386
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorEventRecorder_GetReadFromInputString_06(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString as compared to the default
		/// behavior, which is to read from a file.
		/// </summary>
		// Token: 0x06014D8B RID: 85387 RVA: 0x001D7D80 File Offset: 0x001D5F80
		public virtual int GetReadFromInputString()
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_GetReadFromInputString_06(base.GetCppThis());
		}

		// Token: 0x06014D8C RID: 85388
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorEventRecorder_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D8D RID: 85389 RVA: 0x001D7DA0 File Offset: 0x001D5FA0
		public override int IsA(string type)
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06014D8E RID: 85390
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInteractorEventRecorder_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D8F RID: 85391 RVA: 0x001D7DC0 File Offset: 0x001D5FC0
		public new static int IsTypeOf(string type)
		{
			return vtkInteractorEventRecorder.vtkInteractorEventRecorder_IsTypeOf_08(type);
		}

		// Token: 0x06014D90 RID: 85392
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorEventRecorder_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D91 RID: 85393 RVA: 0x001D7DDC File Offset: 0x001D5FDC
		public new vtkInteractorEventRecorder NewInstance()
		{
			vtkInteractorEventRecorder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorEventRecorder.vtkInteractorEventRecorder_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014D92 RID: 85394
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_Play_11(HandleRef pThis);

		/// <summary>
		/// Invoke this method to begin playing events from the current position.
		/// The events will be played back from the filename indicated.
		/// Once play has been called once, filename will be ignored.
		/// </summary>
		// Token: 0x06014D93 RID: 85395 RVA: 0x001D7E36 File Offset: 0x001D6036
		public void Play()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Play_11(base.GetCppThis());
		}

		// Token: 0x06014D94 RID: 85396
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_ReadFromInputStringOff_12(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString as compared to the default
		/// behavior, which is to read from a file.
		/// </summary>
		// Token: 0x06014D95 RID: 85397 RVA: 0x001D7E45 File Offset: 0x001D6045
		public virtual void ReadFromInputStringOff()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_ReadFromInputStringOff_12(base.GetCppThis());
		}

		// Token: 0x06014D96 RID: 85398
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_ReadFromInputStringOn_13(HandleRef pThis);

		/// <summary>
		/// Enable reading from an InputString as compared to the default
		/// behavior, which is to read from a file.
		/// </summary>
		// Token: 0x06014D97 RID: 85399 RVA: 0x001D7E54 File Offset: 0x001D6054
		public virtual void ReadFromInputStringOn()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_ReadFromInputStringOn_13(base.GetCppThis());
		}

		// Token: 0x06014D98 RID: 85400
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_Record_14(HandleRef pThis);

		/// <summary>
		/// Invoke this method to begin recording events. The events will be
		/// recorded to the filename indicated.
		/// Once record has been called once, filename will be ignored.
		/// </summary>
		// Token: 0x06014D99 RID: 85401 RVA: 0x001D7E63 File Offset: 0x001D6063
		public void Record()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Record_14(base.GetCppThis());
		}

		// Token: 0x06014D9A RID: 85402
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_Rewind_15(HandleRef pThis);

		/// <summary>
		/// Rewind the play stream to the beginning of the file.
		/// </summary>
		// Token: 0x06014D9B RID: 85403 RVA: 0x001D7E72 File Offset: 0x001D6072
		public void Rewind()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Rewind_15(base.GetCppThis());
		}

		// Token: 0x06014D9C RID: 85404
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInteractorEventRecorder_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D9D RID: 85405 RVA: 0x001D7E84 File Offset: 0x001D6084
		public new static vtkInteractorEventRecorder SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorEventRecorder vtkInteractorEventRecorder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInteractorEventRecorder.vtkInteractorEventRecorder_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorEventRecorder = (vtkInteractorEventRecorder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorEventRecorder.Register(null);
				}
			}
			return vtkInteractorEventRecorder;
		}

		// Token: 0x06014D9E RID: 85406
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_SetEnabled_17(HandleRef pThis, int arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014D9F RID: 85407 RVA: 0x001D7F03 File Offset: 0x001D6103
		public override void SetEnabled(int arg0)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetEnabled_17(base.GetCppThis(), arg0);
		}

		// Token: 0x06014DA0 RID: 85408
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_SetFileName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of a file events should be written to/from.
		/// Will be ignored once record/play has been called.
		/// </summary>
		// Token: 0x06014DA1 RID: 85409 RVA: 0x001D7F13 File Offset: 0x001D6113
		public virtual void SetFileName(string _arg)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetFileName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06014DA2 RID: 85410
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_SetInputString_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the string to read from.
		/// </summary>
		// Token: 0x06014DA3 RID: 85411 RVA: 0x001D7F23 File Offset: 0x001D6123
		public virtual void SetInputString(string _arg)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetInputString_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06014DA4 RID: 85412
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_SetInteractor_20(HandleRef pThis, HandleRef iren);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DA5 RID: 85413 RVA: 0x001D7F34 File Offset: 0x001D6134
		public override void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetInteractor_20(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		// Token: 0x06014DA6 RID: 85414
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_SetReadFromInputString_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable reading from an InputString as compared to the default
		/// behavior, which is to read from a file.
		/// </summary>
		// Token: 0x06014DA7 RID: 85415 RVA: 0x001D7F63 File Offset: 0x001D6163
		public virtual void SetReadFromInputString(int _arg)
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_SetReadFromInputString_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06014DA8 RID: 85416
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInteractorEventRecorder_Stop_22(HandleRef pThis);

		/// <summary>
		/// Invoke this method to stop recording/playing events.
		/// </summary>
		// Token: 0x06014DA9 RID: 85417 RVA: 0x001D7F73 File Offset: 0x001D6173
		public void Stop()
		{
			vtkInteractorEventRecorder.vtkInteractorEventRecorder_Stop_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001809 RID: 6153
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorEventRecorder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400180A RID: 6154
		public new static readonly string MRClassNameKey = "class vtkInteractorEventRecorder";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x020007EB RID: 2027
		public enum vtkEventDataType
		{
			/// <summary>enum member</summary>
			// Token: 0x0400180C RID: 6156
			None,
			/// <summary>enum member</summary>
			// Token: 0x0400180D RID: 6157
			StringArray
		}
	}
}
