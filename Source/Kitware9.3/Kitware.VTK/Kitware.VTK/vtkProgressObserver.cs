using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProgressObserver
	/// </summary>
	/// <remarks>
	///    Basic class to optionally replace vtkAlgorithm progress functionality.
	///
	/// When the basic functionality in vtkAlgorithm that reports progress is
	/// not enough, a subclass of vtkProgressObserver can be used to provide
	/// custom functionality.
	/// The main use case for this is when an algorithm's RequestData() is
	/// called from multiple threads in parallel - the basic functionality in
	/// vtkAlgorithm is not thread safe. vtkSMPProgressObserver can
	/// handle this situation by routing progress from each thread to a
	/// thread local vtkProgressObserver, which will invoke events separately
	/// for each thread.
	/// </remarks>
	// Token: 0x020009E0 RID: 2528
	public class vtkProgressObserver : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A4EA RID: 107754 RVA: 0x002484EF File Offset: 0x002466EF
		static vtkProgressObserver()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProgressObserver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProgressObserver"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A4EB RID: 107755 RVA: 0x00248517 File Offset: 0x00246717
		public vtkProgressObserver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A4EC RID: 107756
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressObserver_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4ED RID: 107757 RVA: 0x00248528 File Offset: 0x00246728
		public new static vtkProgressObserver New()
		{
			vtkProgressObserver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressObserver.vtkProgressObserver_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgressObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4EE RID: 107758 RVA: 0x0024857C File Offset: 0x0024677C
		public vtkProgressObserver() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProgressObserver.vtkProgressObserver_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A4EF RID: 107759 RVA: 0x002485C0 File Offset: 0x002467C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A4F0 RID: 107760
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgressObserver_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4F1 RID: 107761 RVA: 0x002485CC File Offset: 0x002467CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProgressObserver.vtkProgressObserver_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A4F2 RID: 107762
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProgressObserver_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4F3 RID: 107763 RVA: 0x002485EC File Offset: 0x002467EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProgressObserver.vtkProgressObserver_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A4F4 RID: 107764
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkProgressObserver_GetProgress_03(HandleRef pThis);

		/// <summary>
		/// Returns the progress reported by the algorithm.
		/// </summary>
		// Token: 0x0601A4F5 RID: 107765 RVA: 0x00248608 File Offset: 0x00246808
		public virtual double GetProgress()
		{
			return vtkProgressObserver.vtkProgressObserver_GetProgress_03(base.GetCppThis());
		}

		// Token: 0x0601A4F6 RID: 107766
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressObserver_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4F7 RID: 107767 RVA: 0x00248628 File Offset: 0x00246828
		public override int IsA(string type)
		{
			return vtkProgressObserver.vtkProgressObserver_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A4F8 RID: 107768
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProgressObserver_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4F9 RID: 107769 RVA: 0x00248648 File Offset: 0x00246848
		public new static int IsTypeOf(string type)
		{
			return vtkProgressObserver.vtkProgressObserver_IsTypeOf_05(type);
		}

		// Token: 0x0601A4FA RID: 107770
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressObserver_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4FB RID: 107771 RVA: 0x00248664 File Offset: 0x00246864
		public new vtkProgressObserver NewInstance()
		{
			vtkProgressObserver result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressObserver.vtkProgressObserver_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProgressObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A4FC RID: 107772
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProgressObserver_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4FD RID: 107773 RVA: 0x002486C0 File Offset: 0x002468C0
		public new static vtkProgressObserver SafeDownCast(vtkObjectBase o)
		{
			vtkProgressObserver vtkProgressObserver = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProgressObserver.vtkProgressObserver_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProgressObserver = (vtkProgressObserver)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProgressObserver.Register(null);
				}
			}
			return vtkProgressObserver;
		}

		// Token: 0x0601A4FE RID: 107774
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProgressObserver_UpdateProgress_09(HandleRef pThis, double amount);

		/// <summary>
		/// The default behavior is to update the Progress data member
		/// and invoke a ProgressEvent. This is designed to be overwritten.
		/// </summary>
		// Token: 0x0601A4FF RID: 107775 RVA: 0x0024873F File Offset: 0x0024693F
		public virtual void UpdateProgress(double amount)
		{
			vtkProgressObserver.vtkProgressObserver_UpdateProgress_09(base.GetCppThis(), amount);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C90 RID: 7312
		public new const string MRFullTypeName = "Kitware.VTK.vtkProgressObserver";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C91 RID: 7313
		public new static readonly string MRClassNameKey = "class vtkProgressObserver";
	}
}
