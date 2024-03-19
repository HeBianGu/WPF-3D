using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDummyCommunicator
	/// </summary>
	/// <remarks>
	///    Dummy controller for single process applications.
	///
	///
	///
	/// This is a dummy communicator, which can be used by applications that always
	/// require a controller but are also compiled on systems without threads or MPI.
	/// Because there is always only one process, no real communication takes place.
	///
	/// </remarks>
	// Token: 0x020006F1 RID: 1777
	public class vtkDummyCommunicator : vtkCommunicator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012BA8 RID: 76712 RVA: 0x001A59CB File Offset: 0x001A3BCB
		static vtkDummyCommunicator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDummyCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDummyCommunicator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012BA9 RID: 76713 RVA: 0x001A59F3 File Offset: 0x001A3BF3
		public vtkDummyCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012BAA RID: 76714
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BAB RID: 76715 RVA: 0x001A5A04 File Offset: 0x001A3C04
		public new static vtkDummyCommunicator New()
		{
			vtkDummyCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyCommunicator.vtkDummyCommunicator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BAC RID: 76716 RVA: 0x001A5A58 File Offset: 0x001A3C58
		public vtkDummyCommunicator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDummyCommunicator.vtkDummyCommunicator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012BAD RID: 76717 RVA: 0x001A5A9C File Offset: 0x001A3C9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012BAE RID: 76718
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDummyCommunicator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BAF RID: 76719 RVA: 0x001A5AA8 File Offset: 0x001A3CA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012BB0 RID: 76720
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDummyCommunicator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BB1 RID: 76721 RVA: 0x001A5AC8 File Offset: 0x001A3CC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012BB2 RID: 76722
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyCommunicator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BB3 RID: 76723 RVA: 0x001A5AE4 File Offset: 0x001A3CE4
		public override int IsA(string type)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012BB4 RID: 76724
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyCommunicator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BB5 RID: 76725 RVA: 0x001A5B04 File Offset: 0x001A3D04
		public new static int IsTypeOf(string type)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_IsTypeOf_04(type);
		}

		// Token: 0x06012BB6 RID: 76726
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyCommunicator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BB7 RID: 76727 RVA: 0x001A5B20 File Offset: 0x001A3D20
		public new vtkDummyCommunicator NewInstance()
		{
			vtkDummyCommunicator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyCommunicator.vtkDummyCommunicator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012BB8 RID: 76728
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyCommunicator_ReceiveVoidArray_07(HandleRef pThis, IntPtr arg0, long arg1, int arg2, int arg3, int arg4);

		/// <summary>
		/// Since there is no one to communicate with, these methods just report an
		/// error.
		/// </summary>
		// Token: 0x06012BB9 RID: 76729 RVA: 0x001A5B7C File Offset: 0x001A3D7C
		public override int ReceiveVoidArray(IntPtr arg0, long arg1, int arg2, int arg3, int arg4)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_ReceiveVoidArray_07(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4);
		}

		// Token: 0x06012BBA RID: 76730
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDummyCommunicator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012BBB RID: 76731 RVA: 0x001A5BA4 File Offset: 0x001A3DA4
		public new static vtkDummyCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkDummyCommunicator vtkDummyCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDummyCommunicator.vtkDummyCommunicator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDummyCommunicator = (vtkDummyCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDummyCommunicator.Register(null);
				}
			}
			return vtkDummyCommunicator;
		}

		// Token: 0x06012BBC RID: 76732
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDummyCommunicator_SendVoidArray_09(HandleRef pThis, IntPtr arg0, long arg1, int arg2, int arg3, int arg4);

		/// <summary>
		/// Since there is no one to communicate with, these methods just report an
		/// error.
		/// </summary>
		// Token: 0x06012BBD RID: 76733 RVA: 0x001A5C24 File Offset: 0x001A3E24
		public override int SendVoidArray(IntPtr arg0, long arg1, int arg2, int arg3, int arg4)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_SendVoidArray_09(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015A3 RID: 5539
		public new const string MRFullTypeName = "Kitware.VTK.vtkDummyCommunicator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015A4 RID: 5540
		public new static readonly string MRClassNameKey = "class vtkDummyCommunicator";
	}
}
