using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataSetRegionSurfaceFilter
	/// </summary>
	/// <remarks>
	///    Extract surface of materials.
	///
	/// This filter extracts surfaces of materials such that a surface
	/// could have a material on each side of it. It also stores a
	/// mapping of the original cells and their sides back to the original grid
	/// so that we can output boundary information for those cells given
	/// only surfaces.
	/// </remarks>
	// Token: 0x02000909 RID: 2313
	public class vtkDataSetRegionSurfaceFilter : vtkDataSetSurfaceFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017FCA RID: 98250 RVA: 0x00218FE9 File Offset: 0x002171E9
		static vtkDataSetRegionSurfaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetRegionSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetRegionSurfaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017FCB RID: 98251 RVA: 0x00219011 File Offset: 0x00217211
		public vtkDataSetRegionSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017FCC RID: 98252
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FCD RID: 98253 RVA: 0x00219020 File Offset: 0x00217220
		public new static vtkDataSetRegionSurfaceFilter New()
		{
			vtkDataSetRegionSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetRegionSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FCE RID: 98254 RVA: 0x00219074 File Offset: 0x00217274
		public vtkDataSetRegionSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017FCF RID: 98255 RVA: 0x002190B8 File Offset: 0x002172B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017FD0 RID: 98256
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetInterfaceIDsName_01(HandleRef pThis);

		/// <summary>
		/// The name of the field array that has material interface type identifiers in it
		/// Default is "interface_ids"
		/// </summary>
		// Token: 0x06017FD1 RID: 98257 RVA: 0x002190C4 File Offset: 0x002172C4
		public virtual string GetInterfaceIDsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetInterfaceIDsName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017FD2 RID: 98258
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetMaterialIDsName_02(HandleRef pThis);

		/// <summary>
		/// The name of the field array that has material type identifiers in it
		/// Default is "material_ids"
		/// </summary>
		// Token: 0x06017FD3 RID: 98259 RVA: 0x00219100 File Offset: 0x00217300
		public virtual string GetMaterialIDsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetMaterialIDsName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017FD4 RID: 98260
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetMaterialPIDsName_03(HandleRef pThis);

		/// <summary>
		/// The name of the output field array that records parent materials of each interface
		/// Default is "material_ancestors"
		/// </summary>
		// Token: 0x06017FD5 RID: 98261 RVA: 0x0021913C File Offset: 0x0021733C
		public virtual string GetMaterialPIDsName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetMaterialPIDsName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017FD6 RID: 98262
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetMaterialPropertiesName_04(HandleRef pThis);

		/// <summary>
		/// The name of the field array that has characteristics of each material
		/// Default is "material_properties"
		/// </summary>
		// Token: 0x06017FD7 RID: 98263 RVA: 0x00219178 File Offset: 0x00217378
		public virtual string GetMaterialPropertiesName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetMaterialPropertiesName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017FD8 RID: 98264
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FD9 RID: 98265 RVA: 0x002191B4 File Offset: 0x002173B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06017FDA RID: 98266
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FDB RID: 98267 RVA: 0x002191D4 File Offset: 0x002173D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06017FDC RID: 98268
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_GetRegionArrayName_07(HandleRef pThis);

		/// <summary>
		/// The name of the cell based array that we use to extract interfaces from
		/// Default is "Regions"
		/// </summary>
		// Token: 0x06017FDD RID: 98269 RVA: 0x002191F0 File Offset: 0x002173F0
		public virtual string GetRegionArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetRegionArrayName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06017FDE RID: 98270
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDataSetRegionSurfaceFilter_GetSingleSided_08(HandleRef pThis);

		/// <summary>
		/// Whether to return single sided material interfaces or double sided
		/// Default is single
		/// </summary>
		// Token: 0x06017FDF RID: 98271 RVA: 0x0021922C File Offset: 0x0021742C
		public virtual bool GetSingleSided()
		{
			return vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_GetSingleSided_08(base.GetCppThis()) != 0;
		}

		// Token: 0x06017FE0 RID: 98272
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetRegionSurfaceFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FE1 RID: 98273 RVA: 0x00219254 File Offset: 0x00217454
		public override int IsA(string type)
		{
			return vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06017FE2 RID: 98274
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetRegionSurfaceFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FE3 RID: 98275 RVA: 0x00219274 File Offset: 0x00217474
		public new static int IsTypeOf(string type)
		{
			return vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_IsTypeOf_10(type);
		}

		// Token: 0x06017FE4 RID: 98276
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FE5 RID: 98277 RVA: 0x00219290 File Offset: 0x00217490
		public new vtkDataSetRegionSurfaceFilter NewInstance()
		{
			vtkDataSetRegionSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetRegionSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017FE6 RID: 98278
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataSetRegionSurfaceFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017FE7 RID: 98279 RVA: 0x002192EC File Offset: 0x002174EC
		public new static vtkDataSetRegionSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetRegionSurfaceFilter vtkDataSetRegionSurfaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetRegionSurfaceFilter = (vtkDataSetRegionSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetRegionSurfaceFilter.Register(null);
				}
			}
			return vtkDataSetRegionSurfaceFilter;
		}

		// Token: 0x06017FE8 RID: 98280
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetRegionSurfaceFilter_SetInterfaceIDsName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the field array that has material interface type identifiers in it
		/// Default is "interface_ids"
		/// </summary>
		// Token: 0x06017FE9 RID: 98281 RVA: 0x0021936B File Offset: 0x0021756B
		public virtual void SetInterfaceIDsName(string _arg)
		{
			vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SetInterfaceIDsName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FEA RID: 98282
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetRegionSurfaceFilter_SetMaterialIDsName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the field array that has material type identifiers in it
		/// Default is "material_ids"
		/// </summary>
		// Token: 0x06017FEB RID: 98283 RVA: 0x0021937B File Offset: 0x0021757B
		public virtual void SetMaterialIDsName(string _arg)
		{
			vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SetMaterialIDsName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FEC RID: 98284
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetRegionSurfaceFilter_SetMaterialPIDsName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the output field array that records parent materials of each interface
		/// Default is "material_ancestors"
		/// </summary>
		// Token: 0x06017FED RID: 98285 RVA: 0x0021938B File Offset: 0x0021758B
		public virtual void SetMaterialPIDsName(string _arg)
		{
			vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SetMaterialPIDsName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FEE RID: 98286
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetRegionSurfaceFilter_SetMaterialPropertiesName_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the field array that has characteristics of each material
		/// Default is "material_properties"
		/// </summary>
		// Token: 0x06017FEF RID: 98287 RVA: 0x0021939B File Offset: 0x0021759B
		public virtual void SetMaterialPropertiesName(string _arg)
		{
			vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SetMaterialPropertiesName_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FF0 RID: 98288
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetRegionSurfaceFilter_SetRegionArrayName_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the cell based array that we use to extract interfaces from
		/// Default is "Regions"
		/// </summary>
		// Token: 0x06017FF1 RID: 98289 RVA: 0x002193AB File Offset: 0x002175AB
		public virtual void SetRegionArrayName(string _arg)
		{
			vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SetRegionArrayName_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06017FF2 RID: 98290
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataSetRegionSurfaceFilter_SetSingleSided_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to return single sided material interfaces or double sided
		/// Default is single
		/// </summary>
		// Token: 0x06017FF3 RID: 98291 RVA: 0x002193BB File Offset: 0x002175BB
		public virtual void SetSingleSided(bool _arg)
		{
			vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_SetSingleSided_19(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06017FF4 RID: 98292
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataSetRegionSurfaceFilter_UnstructuredGridExecute_20(HandleRef pThis, HandleRef input, HandleRef output);

		/// <summary>
		/// The name of the cell based array that we use to extract interfaces from
		/// Default is "Regions"
		/// </summary>
		// Token: 0x06017FF5 RID: 98293 RVA: 0x002193D4 File Offset: 0x002175D4
		public override int UnstructuredGridExecute(vtkDataSet input, vtkPolyData output)
		{
			return vtkDataSetRegionSurfaceFilter.vtkDataSetRegionSurfaceFilter_UnstructuredGridExecute_20(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ABC RID: 6844
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetRegionSurfaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001ABD RID: 6845
		public new static readonly string MRClassNameKey = "class vtkDataSetRegionSurfaceFilter";
	}
}
