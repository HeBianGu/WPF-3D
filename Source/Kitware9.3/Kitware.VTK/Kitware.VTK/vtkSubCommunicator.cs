using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSubCommunicator
	/// </summary>
	/// <remarks>
	///    Provides communication on a process group.
	///
	///
	///
	/// This class provides an implementation for communicating on process groups.
	/// In general, you should never use this class directly.  Instead, use the
	/// vtkMultiProcessController::CreateSubController method.
	///
	///
	/// @bug
	/// Because all communication is delegated to the original communicator,
	/// any error will report process ids with respect to the original
	/// communicator, not this communicator that was actually used.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCommunicator, vtkMultiProcessController
	///
	/// @par Thanks:
	/// This class was originally written by Kenneth Moreland (kmorelndia.gov)
	/// from Sandia National Laboratories.
	///
	/// </seealso>
	// Token: 0x020006FF RID: 1791
	public class vtkSubCommunicator : vtkCommunicator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012DC0 RID: 77248 RVA: 0x001A8AD4 File Offset: 0x001A6CD4
		static vtkSubCommunicator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubCommunicator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012DC1 RID: 77249 RVA: 0x001A8AFC File Offset: 0x001A6CFC
		public vtkSubCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012DC2 RID: 77250
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DC3 RID: 77251 RVA: 0x001A8B0C File Offset: 0x001A6D0C
		public new static vtkSubCommunicator New()
		{
			vtkSubCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DC4 RID: 77252 RVA: 0x001A8B60 File Offset: 0x001A6D60
		public vtkSubCommunicator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSubCommunicator.vtkSubCommunicator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012DC5 RID: 77253 RVA: 0x001A8BA4 File Offset: 0x001A6DA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012DC6 RID: 77254
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubCommunicator_GetGroup_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the group on which communication will happen.
		/// </summary>
		// Token: 0x06012DC7 RID: 77255 RVA: 0x001A8BB0 File Offset: 0x001A6DB0
		public virtual vtkProcessGroup GetGroup()
		{
			vtkProcessGroup vtkProcessGroup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_GetGroup_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcessGroup = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcessGroup.Register(null);
				}
			}
			return vtkProcessGroup;
		}

		// Token: 0x06012DC8 RID: 77256
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubCommunicator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DC9 RID: 77257 RVA: 0x001A8C20 File Offset: 0x001A6E20
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSubCommunicator.vtkSubCommunicator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012DCA RID: 77258
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubCommunicator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DCB RID: 77259 RVA: 0x001A8C40 File Offset: 0x001A6E40
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSubCommunicator.vtkSubCommunicator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012DCC RID: 77260
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubCommunicator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DCD RID: 77261 RVA: 0x001A8C5C File Offset: 0x001A6E5C
		public override int IsA(string type)
		{
			return vtkSubCommunicator.vtkSubCommunicator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012DCE RID: 77262
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubCommunicator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DCF RID: 77263 RVA: 0x001A8C7C File Offset: 0x001A6E7C
		public new static int IsTypeOf(string type)
		{
			return vtkSubCommunicator.vtkSubCommunicator_IsTypeOf_05(type);
		}

		// Token: 0x06012DD0 RID: 77264
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubCommunicator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DD1 RID: 77265 RVA: 0x001A8C98 File Offset: 0x001A6E98
		public new vtkSubCommunicator NewInstance()
		{
			vtkSubCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012DD2 RID: 77266
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubCommunicator_ReceiveVoidArray_08(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		/// <summary>
		/// Implementation for abstract supercalss.
		/// </summary>
		// Token: 0x06012DD3 RID: 77267 RVA: 0x001A8CF4 File Offset: 0x001A6EF4
		public override int ReceiveVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSubCommunicator.vtkSubCommunicator_ReceiveVoidArray_08(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		// Token: 0x06012DD4 RID: 77268
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubCommunicator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DD5 RID: 77269 RVA: 0x001A8D1C File Offset: 0x001A6F1C
		public new static vtkSubCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkSubCommunicator vtkSubCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubCommunicator.vtkSubCommunicator_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubCommunicator = (vtkSubCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubCommunicator.Register(null);
				}
			}
			return vtkSubCommunicator;
		}

		// Token: 0x06012DD6 RID: 77270
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubCommunicator_SendVoidArray_10(HandleRef pThis, IntPtr data, long length, int type, int remoteHandle, int tag);

		/// <summary>
		/// Implementation for abstract supercalss.
		/// </summary>
		// Token: 0x06012DD7 RID: 77271 RVA: 0x001A8D9C File Offset: 0x001A6F9C
		public override int SendVoidArray(IntPtr data, long length, int type, int remoteHandle, int tag)
		{
			return vtkSubCommunicator.vtkSubCommunicator_SendVoidArray_10(base.GetCppThis(), data, length, type, remoteHandle, tag);
		}

		// Token: 0x06012DD8 RID: 77272
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubCommunicator_SetGroup_11(HandleRef pThis, HandleRef group);

		/// <summary>
		/// Set/get the group on which communication will happen.
		/// </summary>
		// Token: 0x06012DD9 RID: 77273 RVA: 0x001A8DC4 File Offset: 0x001A6FC4
		public virtual void SetGroup(vtkProcessGroup group)
		{
			vtkSubCommunicator.vtkSubCommunicator_SetGroup_11(base.GetCppThis(), (group == null) ? default(HandleRef) : group.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015C8 RID: 5576
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubCommunicator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015C9 RID: 5577
		public new static readonly string MRClassNameKey = "class vtkSubCommunicator";
	}
}
