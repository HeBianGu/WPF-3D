using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendLocationAttributes
	/// </summary>
	/// <remarks>
	///    add point locations to point data and/or cell centers cell data, respectively
	///
	/// vtkAppendLocationAttributes is a filter that takes as input any dataset and
	/// optionally adds points as point data and optionally adds cell center locations as
	/// cell data in the output. The center of a cell is its parametric center, not necessarily
	/// the geometric or bounding box center. Point and cell attributes in the input can optionally
	/// be copied to the output.
	///
	/// @note
	/// Empty cells will have their center set to (0, 0, 0).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellCenters
	/// </seealso>
	// Token: 0x02000870 RID: 2160
	public class vtkAppendLocationAttributes : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060166D8 RID: 91864 RVA: 0x001F88DB File Offset: 0x001F6ADB
		static vtkAppendLocationAttributes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendLocationAttributes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendLocationAttributes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060166D9 RID: 91865 RVA: 0x001F8903 File Offset: 0x001F6B03
		public vtkAppendLocationAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060166DA RID: 91866
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendLocationAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166DB RID: 91867 RVA: 0x001F8914 File Offset: 0x001F6B14
		public new static vtkAppendLocationAttributes New()
		{
			vtkAppendLocationAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendLocationAttributes.vtkAppendLocationAttributes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendLocationAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166DC RID: 91868 RVA: 0x001F8968 File Offset: 0x001F6B68
		public vtkAppendLocationAttributes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendLocationAttributes.vtkAppendLocationAttributes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060166DD RID: 91869 RVA: 0x001F89AC File Offset: 0x001F6BAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060166DE RID: 91870
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendLocationAttributes_AppendCellCentersOff_01(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input cell center locations should be saved as a cell data array.
		/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
		/// "CellCenters".
		/// </summary>
		// Token: 0x060166DF RID: 91871 RVA: 0x001F89B7 File Offset: 0x001F6BB7
		public virtual void AppendCellCentersOff()
		{
			vtkAppendLocationAttributes.vtkAppendLocationAttributes_AppendCellCentersOff_01(base.GetCppThis());
		}

		// Token: 0x060166E0 RID: 91872
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendLocationAttributes_AppendCellCentersOn_02(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input cell center locations should be saved as a cell data array.
		/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
		/// "CellCenters".
		/// </summary>
		// Token: 0x060166E1 RID: 91873 RVA: 0x001F89C6 File Offset: 0x001F6BC6
		public virtual void AppendCellCentersOn()
		{
			vtkAppendLocationAttributes.vtkAppendLocationAttributes_AppendCellCentersOn_02(base.GetCppThis());
		}

		// Token: 0x060166E2 RID: 91874
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendLocationAttributes_AppendPointLocationsOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input point locations should be saved as a point data array.
		/// Default is `true` i.e. the points will be propagated as a point data array named
		/// "PointLocations".
		/// </summary>
		// Token: 0x060166E3 RID: 91875 RVA: 0x001F89D5 File Offset: 0x001F6BD5
		public virtual void AppendPointLocationsOff()
		{
			vtkAppendLocationAttributes.vtkAppendLocationAttributes_AppendPointLocationsOff_03(base.GetCppThis());
		}

		// Token: 0x060166E4 RID: 91876
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendLocationAttributes_AppendPointLocationsOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input point locations should be saved as a point data array.
		/// Default is `true` i.e. the points will be propagated as a point data array named
		/// "PointLocations".
		/// </summary>
		// Token: 0x060166E5 RID: 91877 RVA: 0x001F89E4 File Offset: 0x001F6BE4
		public virtual void AppendPointLocationsOn()
		{
			vtkAppendLocationAttributes.vtkAppendLocationAttributes_AppendPointLocationsOn_04(base.GetCppThis());
		}

		// Token: 0x060166E6 RID: 91878
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAppendLocationAttributes_GetAppendCellCenters_05(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input cell center locations should be saved as a cell data array.
		/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
		/// "CellCenters".
		/// </summary>
		// Token: 0x060166E7 RID: 91879 RVA: 0x001F89F4 File Offset: 0x001F6BF4
		public virtual bool GetAppendCellCenters()
		{
			return vtkAppendLocationAttributes.vtkAppendLocationAttributes_GetAppendCellCenters_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060166E8 RID: 91880
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAppendLocationAttributes_GetAppendPointLocations_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable whether input point locations should be saved as a point data array.
		/// Default is `true` i.e. the points will be propagated as a point data array named
		/// "PointLocations".
		/// </summary>
		// Token: 0x060166E9 RID: 91881 RVA: 0x001F8A1C File Offset: 0x001F6C1C
		public virtual bool GetAppendPointLocations()
		{
			return vtkAppendLocationAttributes.vtkAppendLocationAttributes_GetAppendPointLocations_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060166EA RID: 91882
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendLocationAttributes_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166EB RID: 91883 RVA: 0x001F8A44 File Offset: 0x001F6C44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendLocationAttributes.vtkAppendLocationAttributes_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060166EC RID: 91884
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendLocationAttributes_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166ED RID: 91885 RVA: 0x001F8A64 File Offset: 0x001F6C64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendLocationAttributes.vtkAppendLocationAttributes_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060166EE RID: 91886
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendLocationAttributes_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166EF RID: 91887 RVA: 0x001F8A80 File Offset: 0x001F6C80
		public override int IsA(string type)
		{
			return vtkAppendLocationAttributes.vtkAppendLocationAttributes_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060166F0 RID: 91888
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendLocationAttributes_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166F1 RID: 91889 RVA: 0x001F8AA0 File Offset: 0x001F6CA0
		public new static int IsTypeOf(string type)
		{
			return vtkAppendLocationAttributes.vtkAppendLocationAttributes_IsTypeOf_10(type);
		}

		// Token: 0x060166F2 RID: 91890
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendLocationAttributes_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166F3 RID: 91891 RVA: 0x001F8ABC File Offset: 0x001F6CBC
		public new vtkAppendLocationAttributes NewInstance()
		{
			vtkAppendLocationAttributes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendLocationAttributes.vtkAppendLocationAttributes_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendLocationAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060166F4 RID: 91892
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendLocationAttributes_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060166F5 RID: 91893 RVA: 0x001F8B18 File Offset: 0x001F6D18
		public new static vtkAppendLocationAttributes SafeDownCast(vtkObjectBase o)
		{
			vtkAppendLocationAttributes vtkAppendLocationAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendLocationAttributes.vtkAppendLocationAttributes_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendLocationAttributes = (vtkAppendLocationAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendLocationAttributes.Register(null);
				}
			}
			return vtkAppendLocationAttributes;
		}

		// Token: 0x060166F6 RID: 91894
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendLocationAttributes_SetAppendCellCenters_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable whether input cell center locations should be saved as a cell data array.
		/// Default is `true` i.e. the cell centers will be propagated as a cell data array named
		/// "CellCenters".
		/// </summary>
		// Token: 0x060166F7 RID: 91895 RVA: 0x001F8B97 File Offset: 0x001F6D97
		public virtual void SetAppendCellCenters(bool _arg)
		{
			vtkAppendLocationAttributes.vtkAppendLocationAttributes_SetAppendCellCenters_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060166F8 RID: 91896
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendLocationAttributes_SetAppendPointLocations_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Enable/disable whether input point locations should be saved as a point data array.
		/// Default is `true` i.e. the points will be propagated as a point data array named
		/// "PointLocations".
		/// </summary>
		// Token: 0x060166F9 RID: 91897 RVA: 0x001F8BAF File Offset: 0x001F6DAF
		public virtual void SetAppendPointLocations(bool _arg)
		{
			vtkAppendLocationAttributes.vtkAppendLocationAttributes_SetAppendPointLocations_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001936 RID: 6454
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendLocationAttributes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001937 RID: 6455
		public new static readonly string MRClassNameKey = "class vtkAppendLocationAttributes";
	}
}
