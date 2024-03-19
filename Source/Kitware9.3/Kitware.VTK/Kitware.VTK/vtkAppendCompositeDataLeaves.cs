using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAppendCompositeDataLeaves
	/// </summary>
	/// <remarks>
	///    appends one or more composite datasets with the same structure together into a single
	/// output composite dataset
	///
	/// vtkAppendCompositeDataLeaves is a filter that takes input composite datasets with the same
	/// structure: (1) the same number of entries and -- if any children are composites -- the
	/// same constraint holds from them; and (2) the same type of dataset at each position.
	/// It then creates an output dataset with the same structure whose leaves contain all the
	/// cells from the datasets at the corresponding leaves of the input datasets.
	///
	/// Currently, this filter only supports "appending" of a few types for the leaf
	/// nodes and the logic used for each supported data type is as follows:
	///
	/// \li vtkUnstructuredGrid - appends all unstructured grids from the leaf
	///     location on all inputs into a single unstructured grid for the
	///     corresponding location in the output composite dataset. PointData and
	///     CellData arrays are extracted and appended only if they are available in
	///     all datasets.(For example, if one dataset has scalars but another does
	///     not, scalars will not be appended.)
	///
	/// \li vtkPolyData - appends all polydatas from the leaf location on all inputs
	///     into a single polydata for the corresponding location in the output
	///     composite dataset. PointData and CellData arrays are extracted and
	///     appended only if they are available in all datasets.(For example, if one
	///     dataset has scalars but another does not, scalars will not be appended.)
	///
	/// \li vtkImageData/vtkUniformGrid - simply passes the first non-null
	///     grid for a particular location to corresponding location in the output.
	///
	/// \li vtkTable - simply passes the first non-null vtkTable for a particular
	///     location to the corresponding location in the output.
	///
	/// Other types of leaf datasets will be ignored and their positions in the
	/// output dataset will be nullptr pointers.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAppendPolyData vtkAppendFilter
	/// </seealso>
	// Token: 0x02000937 RID: 2359
	public class vtkAppendCompositeDataLeaves : vtkCompositeDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060186CA RID: 100042 RVA: 0x00222A4F File Offset: 0x00220C4F
		static vtkAppendCompositeDataLeaves()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAppendCompositeDataLeaves.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAppendCompositeDataLeaves"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060186CB RID: 100043 RVA: 0x00222A77 File Offset: 0x00220C77
		public vtkAppendCompositeDataLeaves(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060186CC RID: 100044
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186CD RID: 100045 RVA: 0x00222A88 File Offset: 0x00220C88
		public new static vtkAppendCompositeDataLeaves New()
		{
			vtkAppendCompositeDataLeaves result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186CE RID: 100046 RVA: 0x00222ADC File Offset: 0x00220CDC
		public vtkAppendCompositeDataLeaves() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060186CF RID: 100047 RVA: 0x00222B20 File Offset: 0x00220D20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060186D0 RID: 100048
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendCompositeDataLeaves_AppendFieldDataOff_01(HandleRef pThis);

		/// <summary>
		/// Set/get whether the field data of each dataset in the composite dataset is copied to the
		/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
		/// the output. If there are duplicates, the array on the first input encountered is taken.
		/// </summary>
		// Token: 0x060186D1 RID: 100049 RVA: 0x00222B2B File Offset: 0x00220D2B
		public virtual void AppendFieldDataOff()
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_AppendFieldDataOff_01(base.GetCppThis());
		}

		// Token: 0x060186D2 RID: 100050
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendCompositeDataLeaves_AppendFieldDataOn_02(HandleRef pThis);

		/// <summary>
		/// Set/get whether the field data of each dataset in the composite dataset is copied to the
		/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
		/// the output. If there are duplicates, the array on the first input encountered is taken.
		/// </summary>
		// Token: 0x060186D3 RID: 100051 RVA: 0x00222B3A File Offset: 0x00220D3A
		public virtual void AppendFieldDataOn()
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_AppendFieldDataOn_02(base.GetCppThis());
		}

		// Token: 0x060186D4 RID: 100052
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendCompositeDataLeaves_GetAppendFieldData_03(HandleRef pThis);

		/// <summary>
		/// Set/get whether the field data of each dataset in the composite dataset is copied to the
		/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
		/// the output. If there are duplicates, the array on the first input encountered is taken.
		/// </summary>
		// Token: 0x060186D5 RID: 100053 RVA: 0x00222B4C File Offset: 0x00220D4C
		public virtual int GetAppendFieldData()
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_GetAppendFieldData_03(base.GetCppThis());
		}

		// Token: 0x060186D6 RID: 100054
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186D7 RID: 100055 RVA: 0x00222B6C File Offset: 0x00220D6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060186D8 RID: 100056
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186D9 RID: 100057 RVA: 0x00222B8C File Offset: 0x00220D8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060186DA RID: 100058
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendCompositeDataLeaves_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186DB RID: 100059 RVA: 0x00222BA8 File Offset: 0x00220DA8
		public override int IsA(string type)
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060186DC RID: 100060
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAppendCompositeDataLeaves_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186DD RID: 100061 RVA: 0x00222BC8 File Offset: 0x00220DC8
		public new static int IsTypeOf(string type)
		{
			return vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_IsTypeOf_07(type);
		}

		// Token: 0x060186DE RID: 100062
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186DF RID: 100063 RVA: 0x00222BE4 File Offset: 0x00220DE4
		public new vtkAppendCompositeDataLeaves NewInstance()
		{
			vtkAppendCompositeDataLeaves result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060186E0 RID: 100064
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAppendCompositeDataLeaves_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060186E1 RID: 100065 RVA: 0x00222C40 File Offset: 0x00220E40
		public new static vtkAppendCompositeDataLeaves SafeDownCast(vtkObjectBase o)
		{
			vtkAppendCompositeDataLeaves vtkAppendCompositeDataLeaves = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAppendCompositeDataLeaves = (vtkAppendCompositeDataLeaves)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAppendCompositeDataLeaves.Register(null);
				}
			}
			return vtkAppendCompositeDataLeaves;
		}

		// Token: 0x060186E2 RID: 100066
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAppendCompositeDataLeaves_SetAppendFieldData_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get whether the field data of each dataset in the composite dataset is copied to the
		/// output. If AppendFieldData is non-zero, then field data arrays from all the inputs are added to
		/// the output. If there are duplicates, the array on the first input encountered is taken.
		/// </summary>
		// Token: 0x060186E3 RID: 100067 RVA: 0x00222CBF File Offset: 0x00220EBF
		public virtual void SetAppendFieldData(int _arg)
		{
			vtkAppendCompositeDataLeaves.vtkAppendCompositeDataLeaves_SetAppendFieldData_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B18 RID: 6936
		public new const string MRFullTypeName = "Kitware.VTK.vtkAppendCompositeDataLeaves";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B19 RID: 6937
		public new static readonly string MRClassNameKey = "class vtkAppendCompositeDataLeaves";
	}
}
