using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkTimeRange
	/// </summary>
	/// <remarks>
	///  vtkExecutionRange using time to dispatch in a vtkForEach sub-pipeline
	///
	/// vtkTimeRange is an execution range for the vtkForEach, that split execution by time steps.
	/// The resulting sub-pipeline will be executed once for each time step of the input dataset.
	///
	/// </remarks>
	/// <seealso>
	///  vtkForEach, vtkExecutionRange, vtkTimeRange
	/// </seealso>
	// Token: 0x020009E7 RID: 2535
	public class vtkTimeRange : vtkExecutionRange
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A60E RID: 108046 RVA: 0x00249F43 File Offset: 0x00248143
		static vtkTimeRange()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTimeRange.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTimeRange"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A60F RID: 108047 RVA: 0x00249F6B File Offset: 0x0024816B
		public vtkTimeRange(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A610 RID: 108048
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimeRange_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A611 RID: 108049 RVA: 0x00249F7C File Offset: 0x0024817C
		public new static vtkTimeRange New()
		{
			vtkTimeRange result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimeRange.vtkTimeRange_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimeRange)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A612 RID: 108050 RVA: 0x00249FD0 File Offset: 0x002481D0
		public vtkTimeRange() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTimeRange.vtkTimeRange_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A613 RID: 108051 RVA: 0x0024A014 File Offset: 0x00248214
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A614 RID: 108052
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimeRange_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A615 RID: 108053 RVA: 0x0024A020 File Offset: 0x00248220
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTimeRange.vtkTimeRange_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A616 RID: 108054
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTimeRange_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A617 RID: 108055 RVA: 0x0024A040 File Offset: 0x00248240
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTimeRange.vtkTimeRange_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A618 RID: 108056
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeRange_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A619 RID: 108057 RVA: 0x0024A05C File Offset: 0x0024825C
		public override int IsA(string type)
		{
			return vtkTimeRange.vtkTimeRange_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A61A RID: 108058
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTimeRange_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A61B RID: 108059 RVA: 0x0024A07C File Offset: 0x0024827C
		public new static int IsTypeOf(string type)
		{
			return vtkTimeRange.vtkTimeRange_IsTypeOf_04(type);
		}

		// Token: 0x0601A61C RID: 108060
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimeRange_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A61D RID: 108061 RVA: 0x0024A098 File Offset: 0x00248298
		public new vtkTimeRange NewInstance()
		{
			vtkTimeRange result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimeRange.vtkTimeRange_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTimeRange)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A61E RID: 108062
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTimeRange_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A61F RID: 108063 RVA: 0x0024A0F4 File Offset: 0x002482F4
		public new static vtkTimeRange SafeDownCast(vtkObjectBase o)
		{
			vtkTimeRange vtkTimeRange = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTimeRange.vtkTimeRange_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTimeRange = (vtkTimeRange)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTimeRange.Register(null);
				}
			}
			return vtkTimeRange;
		}

		// Token: 0x0601A620 RID: 108064
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTimeRange_Size_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A621 RID: 108065 RVA: 0x0024A174 File Offset: 0x00248374
		public override ulong Size()
		{
			return vtkTimeRange.vtkTimeRange_Size_08(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C9E RID: 7326
		public new const string MRFullTypeName = "Kitware.VTK.vtkTimeRange";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C9F RID: 7327
		public new static readonly string MRClassNameKey = "class vtkTimeRange";
	}
}
