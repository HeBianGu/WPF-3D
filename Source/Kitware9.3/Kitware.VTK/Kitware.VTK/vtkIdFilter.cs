using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIdFilter
	/// </summary>
	/// <remarks>
	///    generate scalars or field data from point and cell ids
	///
	/// vtkIdFilter is a filter to that generates scalars or field data
	/// using cell and point ids. That is, the point attribute data scalars
	/// or field data are generated from the point ids, and the cell
	/// attribute data scalars or field data are generated from the
	/// cell ids.
	///
	/// Typically this filter is used with vtkLabeledDataMapper (and possibly
	/// vtkSelectVisiblePoints) to create labels for points and cells, or labels
	/// for the point or cell data scalar values.
	/// </remarks>
	// Token: 0x02000971 RID: 2417
	public class vtkIdFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601934A RID: 103242 RVA: 0x00231D03 File Offset: 0x0022FF03
		static vtkIdFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601934B RID: 103243 RVA: 0x00231D2B File Offset: 0x0022FF2B
		public vtkIdFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601934C RID: 103244
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x0601934D RID: 103245 RVA: 0x00231D3C File Offset: 0x0022FF3C
		public new static vtkIdFilter New()
		{
			vtkIdFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdFilter.vtkIdFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with PointIds and CellIds on; and ids being generated
		/// as scalars.
		/// </summary>
		// Token: 0x0601934E RID: 103246 RVA: 0x00231D90 File Offset: 0x0022FF90
		public vtkIdFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIdFilter.vtkIdFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601934F RID: 103247 RVA: 0x00231DD4 File Offset: 0x0022FFD4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019350 RID: 103248
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_CellIdsOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x06019351 RID: 103249 RVA: 0x00231DDF File Offset: 0x0022FFDF
		public virtual void CellIdsOff()
		{
			vtkIdFilter.vtkIdFilter_CellIdsOff_01(base.GetCppThis());
		}

		// Token: 0x06019352 RID: 103250
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_CellIdsOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x06019353 RID: 103251 RVA: 0x00231DEE File Offset: 0x0022FFEE
		public virtual void CellIdsOn()
		{
			vtkIdFilter.vtkIdFilter_CellIdsOn_02(base.GetCppThis());
		}

		// Token: 0x06019354 RID: 103252
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_FieldDataOff_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which controls whether to generate scalar data
		/// or field data. If this flag is off, scalar data is generated.
		/// Otherwise, field data is generated. Default is off.
		/// </summary>
		// Token: 0x06019355 RID: 103253 RVA: 0x00231DFD File Offset: 0x0022FFFD
		public virtual void FieldDataOff()
		{
			vtkIdFilter.vtkIdFilter_FieldDataOff_03(base.GetCppThis());
		}

		// Token: 0x06019356 RID: 103254
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_FieldDataOn_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which controls whether to generate scalar data
		/// or field data. If this flag is off, scalar data is generated.
		/// Otherwise, field data is generated. Default is off.
		/// </summary>
		// Token: 0x06019357 RID: 103255 RVA: 0x00231E0C File Offset: 0x0023000C
		public virtual void FieldDataOn()
		{
			vtkIdFilter.vtkIdFilter_FieldDataOn_04(base.GetCppThis());
		}

		// Token: 0x06019358 RID: 103256
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdFilter_GetCellIds_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x06019359 RID: 103257 RVA: 0x00231E1C File Offset: 0x0023001C
		public virtual int GetCellIds()
		{
			return vtkIdFilter.vtkIdFilter_GetCellIds_05(base.GetCppThis());
		}

		// Token: 0x0601935A RID: 103258
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdFilter_GetCellIdsArrayName_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the Ids array for points, if generated. By default,
		/// set to "vtkIdFilter_Ids" for backwards compatibility.
		/// </summary>
		// Token: 0x0601935B RID: 103259 RVA: 0x00231E3C File Offset: 0x0023003C
		public virtual string GetCellIdsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkIdFilter.vtkIdFilter_GetCellIdsArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601935C RID: 103260
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdFilter_GetFieldData_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the flag which controls whether to generate scalar data
		/// or field data. If this flag is off, scalar data is generated.
		/// Otherwise, field data is generated. Default is off.
		/// </summary>
		// Token: 0x0601935D RID: 103261 RVA: 0x00231E78 File Offset: 0x00230078
		public virtual int GetFieldData()
		{
			return vtkIdFilter.vtkIdFilter_GetFieldData_07(base.GetCppThis());
		}

		// Token: 0x0601935E RID: 103262
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdFilter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601935F RID: 103263 RVA: 0x00231E98 File Offset: 0x00230098
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIdFilter.vtkIdFilter_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06019360 RID: 103264
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdFilter_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019361 RID: 103265 RVA: 0x00231EB8 File Offset: 0x002300B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIdFilter.vtkIdFilter_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06019362 RID: 103266
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdFilter_GetPointIds_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x06019363 RID: 103267 RVA: 0x00231ED4 File Offset: 0x002300D4
		public virtual int GetPointIds()
		{
			return vtkIdFilter.vtkIdFilter_GetPointIds_10(base.GetCppThis());
		}

		// Token: 0x06019364 RID: 103268
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdFilter_GetPointIdsArrayName_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the Ids array for points, if generated. By default,
		/// set to "vtkIdFilter_Ids" for backwards compatibility.
		/// </summary>
		// Token: 0x06019365 RID: 103269 RVA: 0x00231EF4 File Offset: 0x002300F4
		public virtual string GetPointIdsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkIdFilter.vtkIdFilter_GetPointIdsArrayName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019366 RID: 103270
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdFilter_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019367 RID: 103271 RVA: 0x00231F30 File Offset: 0x00230130
		public override int IsA(string type)
		{
			return vtkIdFilter.vtkIdFilter_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06019368 RID: 103272
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdFilter_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019369 RID: 103273 RVA: 0x00231F50 File Offset: 0x00230150
		public new static int IsTypeOf(string type)
		{
			return vtkIdFilter.vtkIdFilter_IsTypeOf_13(type);
		}

		// Token: 0x0601936A RID: 103274
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601936B RID: 103275 RVA: 0x00231F6C File Offset: 0x0023016C
		public new vtkIdFilter NewInstance()
		{
			vtkIdFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdFilter.vtkIdFilter_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601936C RID: 103276
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_PointIdsOff_16(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x0601936D RID: 103277 RVA: 0x00231FC6 File Offset: 0x002301C6
		public virtual void PointIdsOff()
		{
			vtkIdFilter.vtkIdFilter_PointIdsOff_16(base.GetCppThis());
		}

		// Token: 0x0601936E RID: 103278
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_PointIdsOn_17(HandleRef pThis);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x0601936F RID: 103279 RVA: 0x00231FD5 File Offset: 0x002301D5
		public virtual void PointIdsOn()
		{
			vtkIdFilter.vtkIdFilter_PointIdsOn_17(base.GetCppThis());
		}

		// Token: 0x06019370 RID: 103280
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019371 RID: 103281 RVA: 0x00231FE4 File Offset: 0x002301E4
		public new static vtkIdFilter SafeDownCast(vtkObjectBase o)
		{
			vtkIdFilter vtkIdFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdFilter.vtkIdFilter_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdFilter = (vtkIdFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdFilter.Register(null);
				}
			}
			return vtkIdFilter;
		}

		// Token: 0x06019372 RID: 103282
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_SetCellIds_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x06019373 RID: 103283 RVA: 0x00232063 File Offset: 0x00230263
		public virtual void SetCellIds(int _arg)
		{
			vtkIdFilter.vtkIdFilter_SetCellIds_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06019374 RID: 103284
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_SetCellIdsArrayName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the Ids array for points, if generated. By default,
		/// set to "vtkIdFilter_Ids" for backwards compatibility.
		/// </summary>
		// Token: 0x06019375 RID: 103285 RVA: 0x00232073 File Offset: 0x00230273
		public virtual void SetCellIdsArrayName(string _arg)
		{
			vtkIdFilter.vtkIdFilter_SetCellIdsArrayName_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06019376 RID: 103286
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_SetFieldData_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the flag which controls whether to generate scalar data
		/// or field data. If this flag is off, scalar data is generated.
		/// Otherwise, field data is generated. Default is off.
		/// </summary>
		// Token: 0x06019377 RID: 103287 RVA: 0x00232083 File Offset: 0x00230283
		public virtual void SetFieldData(int _arg)
		{
			vtkIdFilter.vtkIdFilter_SetFieldData_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06019378 RID: 103288
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_SetPointIds_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the generation of point ids. Default is on.
		/// </summary>
		// Token: 0x06019379 RID: 103289 RVA: 0x00232093 File Offset: 0x00230293
		public virtual void SetPointIds(int _arg)
		{
			vtkIdFilter.vtkIdFilter_SetPointIds_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0601937A RID: 103290
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkIdFilter_SetPointIdsArrayName_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the Ids array for points, if generated. By default,
		/// set to "vtkIdFilter_Ids" for backwards compatibility.
		/// </summary>
		// Token: 0x0601937B RID: 103291 RVA: 0x002320A3 File Offset: 0x002302A3
		public virtual void SetPointIdsArrayName(string _arg)
		{
			vtkIdFilter.vtkIdFilter_SetPointIdsArrayName_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B9B RID: 7067
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B9C RID: 7068
		public new static readonly string MRClassNameKey = "class vtkIdFilter";
	}
}
