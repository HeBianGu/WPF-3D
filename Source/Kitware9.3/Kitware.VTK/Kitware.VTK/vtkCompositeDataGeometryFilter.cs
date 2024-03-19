using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeDataGeometryFilter
	/// </summary>
	/// <remarks>
	///    extract geometry from multi-group data
	///
	/// vtkCompositeDataGeometryFilter applies vtkGeometryFilter to all
	/// leaves in vtkCompositeDataSet. Place this filter at the end of a
	/// pipeline before a polydata consumer such as a polydata mapper to extract
	/// geometry from all blocks and append them to one polydata object.
	/// </remarks>
	// Token: 0x02000907 RID: 2311
	public class vtkCompositeDataGeometryFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017F6A RID: 98154 RVA: 0x002187E8 File Offset: 0x002169E8
		static vtkCompositeDataGeometryFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataGeometryFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017F6B RID: 98155 RVA: 0x00218810 File Offset: 0x00216A10
		public vtkCompositeDataGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017F6C RID: 98156
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F6D RID: 98157 RVA: 0x00218820 File Offset: 0x00216A20
		public new static vtkCompositeDataGeometryFilter New()
		{
			vtkCompositeDataGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F6E RID: 98158 RVA: 0x00218874 File Offset: 0x00216A74
		public vtkCompositeDataGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017F6F RID: 98159 RVA: 0x002188B8 File Offset: 0x00216AB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017F70 RID: 98160
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataGeometryFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F71 RID: 98161 RVA: 0x002188C4 File Offset: 0x00216AC4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017F72 RID: 98162
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeDataGeometryFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F73 RID: 98163 RVA: 0x002188E4 File Offset: 0x00216AE4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017F74 RID: 98164
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataGeometryFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F75 RID: 98165 RVA: 0x00218900 File Offset: 0x00216B00
		public override int IsA(string type)
		{
			return vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017F76 RID: 98166
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeDataGeometryFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F77 RID: 98167 RVA: 0x00218920 File Offset: 0x00216B20
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_IsTypeOf_04(type);
		}

		// Token: 0x06017F78 RID: 98168
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataGeometryFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F79 RID: 98169 RVA: 0x0021893C File Offset: 0x00216B3C
		public new vtkCompositeDataGeometryFilter NewInstance()
		{
			vtkCompositeDataGeometryFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017F7A RID: 98170
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeDataGeometryFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017F7B RID: 98171 RVA: 0x00218998 File Offset: 0x00216B98
		public new static vtkCompositeDataGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataGeometryFilter vtkCompositeDataGeometryFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeDataGeometryFilter.vtkCompositeDataGeometryFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataGeometryFilter = (vtkCompositeDataGeometryFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataGeometryFilter.Register(null);
				}
			}
			return vtkCompositeDataGeometryFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AB8 RID: 6840
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataGeometryFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AB9 RID: 6841
		public new static readonly string MRClassNameKey = "class vtkCompositeDataGeometryFilter";
	}
}
