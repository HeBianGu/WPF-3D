using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRectilinearGridOutlineFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline for a rectilinear grid.
	///
	/// vtkRectilinearGridOutlineFilter works in parallel.  There is no reason.
	/// to use this filter if you are not breaking the processing into pieces.
	/// With one piece you can simply use vtkOutlineFilter.  This filter
	/// ignores internal edges when the extent is not the whole extent.
	/// </remarks>
	// Token: 0x02000539 RID: 1337
	public class vtkRectilinearGridOutlineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EE85 RID: 61061 RVA: 0x0014C4F3 File Offset: 0x0014A6F3
		static vtkRectilinearGridOutlineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridOutlineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE86 RID: 61062 RVA: 0x0014C51B File Offset: 0x0014A71B
		public vtkRectilinearGridOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EE87 RID: 61063
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE88 RID: 61064 RVA: 0x0014C52C File Offset: 0x0014A72C
		public new static vtkRectilinearGridOutlineFilter New()
		{
			vtkRectilinearGridOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE89 RID: 61065 RVA: 0x0014C580 File Offset: 0x0014A780
		public vtkRectilinearGridOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EE8A RID: 61066 RVA: 0x0014C5C4 File Offset: 0x0014A7C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EE8B RID: 61067
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridOutlineFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE8C RID: 61068 RVA: 0x0014C5D0 File Offset: 0x0014A7D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EE8D RID: 61069
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRectilinearGridOutlineFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE8E RID: 61070 RVA: 0x0014C5F0 File Offset: 0x0014A7F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EE8F RID: 61071
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridOutlineFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE90 RID: 61072 RVA: 0x0014C60C File Offset: 0x0014A80C
		public override int IsA(string type)
		{
			return vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EE91 RID: 61073
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRectilinearGridOutlineFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE92 RID: 61074 RVA: 0x0014C62C File Offset: 0x0014A82C
		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600EE93 RID: 61075
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridOutlineFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE94 RID: 61076 RVA: 0x0014C648 File Offset: 0x0014A848
		public new vtkRectilinearGridOutlineFilter NewInstance()
		{
			vtkRectilinearGridOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EE95 RID: 61077
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRectilinearGridOutlineFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EE96 RID: 61078 RVA: 0x0014C6A4 File Offset: 0x0014A8A4
		public new static vtkRectilinearGridOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridOutlineFilter vtkRectilinearGridOutlineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRectilinearGridOutlineFilter.vtkRectilinearGridOutlineFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridOutlineFilter = (vtkRectilinearGridOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridOutlineFilter.Register(null);
				}
			}
			return vtkRectilinearGridOutlineFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400116A RID: 4458
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridOutlineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400116B RID: 4459
		public new static readonly string MRClassNameKey = "class vtkRectilinearGridOutlineFilter";
	}
}
