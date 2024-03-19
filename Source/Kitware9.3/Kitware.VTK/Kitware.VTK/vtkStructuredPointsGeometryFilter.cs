using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredPointsGeometryFilter
	/// </summary>
	/// <remarks>
	///    obsolete class
	///
	/// vtkStructuredPointsGeometryFilter has been renamed to
	/// vtkImageDataGeometryFilter
	/// </remarks>
	// Token: 0x02000917 RID: 2327
	public class vtkStructuredPointsGeometryFilter : vtkImageDataGeometryFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060181B0 RID: 98736 RVA: 0x0021BD1F File Offset: 0x00219F1F
		static vtkStructuredPointsGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060181B1 RID: 98737 RVA: 0x0021BD47 File Offset: 0x00219F47
		public vtkStructuredPointsGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060181B2 RID: 98738
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with initial extent of all the data
		/// </summary>
		// Token: 0x060181B3 RID: 98739 RVA: 0x0021BD58 File Offset: 0x00219F58
		public new static vtkStructuredPointsGeometryFilter New()
		{
			vtkStructuredPointsGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with initial extent of all the data
		/// </summary>
		// Token: 0x060181B4 RID: 98740 RVA: 0x0021BDAC File Offset: 0x00219FAC
		public vtkStructuredPointsGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060181B5 RID: 98741 RVA: 0x0021BDF0 File Offset: 0x00219FF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060181B6 RID: 98742
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsGeometryFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181B7 RID: 98743 RVA: 0x0021BDFC File Offset: 0x00219FFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060181B8 RID: 98744
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsGeometryFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181B9 RID: 98745 RVA: 0x0021BE1C File Offset: 0x0021A01C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060181BA RID: 98746
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsGeometryFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181BB RID: 98747 RVA: 0x0021BE38 File Offset: 0x0021A038
		public override int IsA(string type)
		{
			return vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060181BC RID: 98748
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsGeometryFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181BD RID: 98749 RVA: 0x0021BE58 File Offset: 0x0021A058
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_IsTypeOf_04(type);
		}

		// Token: 0x060181BE RID: 98750
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsGeometryFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181BF RID: 98751 RVA: 0x0021BE74 File Offset: 0x0021A074
		public new vtkStructuredPointsGeometryFilter NewInstance()
		{
			vtkStructuredPointsGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060181C0 RID: 98752
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsGeometryFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181C1 RID: 98753 RVA: 0x0021BED0 File Offset: 0x0021A0D0
		public new static vtkStructuredPointsGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsGeometryFilter vtkStructuredPointsGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsGeometryFilter.vtkStructuredPointsGeometryFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsGeometryFilter = (vtkStructuredPointsGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsGeometryFilter.Register(null);
				}
			}
			return vtkStructuredPointsGeometryFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD8 RID: 6872
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD9 RID: 6873
		public new static readonly string MRClassNameKey = "class vtkStructuredPointsGeometryFilter";
	}
}
