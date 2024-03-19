using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataToReebGraphFilter
	/// </summary>
	/// <remarks>
	///    generate a Reeb graph from a scalar
	/// field defined on a vtkPolyData.
	///
	/// The filter will first try to pull as a scalar field the vtkDataArray with
	/// Id 'fieldId' of the mesh's vtkPointData.
	/// If this field does not exist, the filter will use the vtkElevationFilter to
	/// generate a default scalar field.
	/// </remarks>
	// Token: 0x020008CC RID: 2252
	public class vtkPolyDataToReebGraphFilter : vtkDirectedGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017443 RID: 95299 RVA: 0x0020ABEB File Offset: 0x00208DEB
		static vtkPolyDataToReebGraphFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataToReebGraphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToReebGraphFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017444 RID: 95300 RVA: 0x0020AC13 File Offset: 0x00208E13
		public vtkPolyDataToReebGraphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017445 RID: 95301
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017446 RID: 95302 RVA: 0x0020AC24 File Offset: 0x00208E24
		public new static vtkPolyDataToReebGraphFilter New()
		{
			vtkPolyDataToReebGraphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017447 RID: 95303 RVA: 0x0020AC78 File Offset: 0x00208E78
		public vtkPolyDataToReebGraphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017448 RID: 95304 RVA: 0x0020ACBC File Offset: 0x00208EBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017449 RID: 95305
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToReebGraphFilter_GetFieldId_01(HandleRef pThis);

		/// <summary>
		/// Set the scalar field id (default = 0).
		/// </summary>
		// Token: 0x0601744A RID: 95306 RVA: 0x0020ACC8 File Offset: 0x00208EC8
		public virtual int GetFieldId()
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_GetFieldId_01(base.GetCppThis());
		}

		// Token: 0x0601744B RID: 95307
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataToReebGraphFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601744C RID: 95308 RVA: 0x0020ACE8 File Offset: 0x00208EE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601744D RID: 95309
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataToReebGraphFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601744E RID: 95310 RVA: 0x0020AD08 File Offset: 0x00208F08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601744F RID: 95311
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the scalar field id (default = 0).
		/// </summary>
		// Token: 0x06017450 RID: 95312 RVA: 0x0020AD24 File Offset: 0x00208F24
		public new vtkReebGraph GetOutput()
		{
			vtkReebGraph vtkReebGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraph = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraph.Register(null);
				}
			}
			return vtkReebGraph;
		}

		// Token: 0x06017451 RID: 95313
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToReebGraphFilter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017452 RID: 95314 RVA: 0x0020AD94 File Offset: 0x00208F94
		public override int IsA(string type)
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06017453 RID: 95315
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataToReebGraphFilter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017454 RID: 95316 RVA: 0x0020ADB4 File Offset: 0x00208FB4
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_IsTypeOf_06(type);
		}

		// Token: 0x06017455 RID: 95317
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017456 RID: 95318 RVA: 0x0020ADD0 File Offset: 0x00208FD0
		public new vtkPolyDataToReebGraphFilter NewInstance()
		{
			vtkPolyDataToReebGraphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017457 RID: 95319
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataToReebGraphFilter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017458 RID: 95320 RVA: 0x0020AE2C File Offset: 0x0020902C
		public new static vtkPolyDataToReebGraphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataToReebGraphFilter vtkPolyDataToReebGraphFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataToReebGraphFilter = (vtkPolyDataToReebGraphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataToReebGraphFilter.Register(null);
				}
			}
			return vtkPolyDataToReebGraphFilter;
		}

		// Token: 0x06017459 RID: 95321
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataToReebGraphFilter_SetFieldId_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the scalar field id (default = 0).
		/// </summary>
		// Token: 0x0601745A RID: 95322 RVA: 0x0020AEAB File Offset: 0x002090AB
		public virtual void SetFieldId(int _arg)
		{
			vtkPolyDataToReebGraphFilter.vtkPolyDataToReebGraphFilter_SetFieldId_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A0B RID: 6667
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToReebGraphFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A0C RID: 6668
		public new static readonly string MRClassNameKey = "class vtkPolyDataToReebGraphFilter";
	}
}
