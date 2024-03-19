using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPChacoReader
	/// </summary>
	/// <remarks>
	///    Read Chaco files
	///
	/// vtkPChacoReader is a unstructured grid source object that reads
	/// Chaco files.  The file is read by process 0 and converted into
	/// a vtkUnstructuredGrid.  The vtkDistributedDataFilter is invoked
	/// to divide the grid among the processes.
	/// </remarks>
	// Token: 0x02000159 RID: 345
	public class vtkPChacoReader : vtkChacoReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004200 RID: 16896 RVA: 0x00060A7B File Offset: 0x0005EC7B
		static vtkPChacoReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPChacoReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPChacoReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004201 RID: 16897 RVA: 0x00060AA3 File Offset: 0x0005ECA3
		public vtkPChacoReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004202 RID: 16898
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPChacoReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004203 RID: 16899 RVA: 0x00060AB4 File Offset: 0x0005ECB4
		public new static vtkPChacoReader New()
		{
			vtkPChacoReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPChacoReader.vtkPChacoReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPChacoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004204 RID: 16900 RVA: 0x00060B08 File Offset: 0x0005ED08
		public vtkPChacoReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPChacoReader.vtkPChacoReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004205 RID: 16901 RVA: 0x00060B4C File Offset: 0x0005ED4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004206 RID: 16902
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPChacoReader_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the communicator object (we'll use global World controller
		/// if you don't set a different one).
		/// </summary>
		// Token: 0x06004207 RID: 16903 RVA: 0x00060B58 File Offset: 0x0005ED58
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPChacoReader.vtkPChacoReader_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06004208 RID: 16904
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPChacoReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004209 RID: 16905 RVA: 0x00060BC8 File Offset: 0x0005EDC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPChacoReader.vtkPChacoReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600420A RID: 16906
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPChacoReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600420B RID: 16907 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPChacoReader.vtkPChacoReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600420C RID: 16908
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPChacoReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600420D RID: 16909 RVA: 0x00060C04 File Offset: 0x0005EE04
		public override int IsA(string type)
		{
			return vtkPChacoReader.vtkPChacoReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600420E RID: 16910
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPChacoReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600420F RID: 16911 RVA: 0x00060C24 File Offset: 0x0005EE24
		public new static int IsTypeOf(string type)
		{
			return vtkPChacoReader.vtkPChacoReader_IsTypeOf_05(type);
		}

		// Token: 0x06004210 RID: 16912
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPChacoReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004211 RID: 16913 RVA: 0x00060C40 File Offset: 0x0005EE40
		public new vtkPChacoReader NewInstance()
		{
			vtkPChacoReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPChacoReader.vtkPChacoReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPChacoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004212 RID: 16914
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPChacoReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004213 RID: 16915 RVA: 0x00060C9C File Offset: 0x0005EE9C
		public new static vtkPChacoReader SafeDownCast(vtkObjectBase o)
		{
			vtkPChacoReader vtkPChacoReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPChacoReader.vtkPChacoReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPChacoReader = (vtkPChacoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPChacoReader.Register(null);
				}
			}
			return vtkPChacoReader;
		}

		// Token: 0x06004214 RID: 16916
		[DllImport("Kitware.VTK.IOParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPChacoReader_SetController_09(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Set/Get the communicator object (we'll use global World controller
		/// if you don't set a different one).
		/// </summary>
		// Token: 0x06004215 RID: 16917 RVA: 0x00060D1C File Offset: 0x0005EF1C
		public void SetController(vtkMultiProcessController c)
		{
			vtkPChacoReader.vtkPChacoReader_SetController_09(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F7 RID: 1783
		public new const string MRFullTypeName = "Kitware.VTK.vtkPChacoReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F8 RID: 1784
		public new static readonly string MRClassNameKey = "class vtkPChacoReader";
	}
}
