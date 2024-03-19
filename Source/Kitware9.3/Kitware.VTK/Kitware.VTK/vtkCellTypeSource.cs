using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellTypeSource
	/// </summary>
	/// <remarks>
	///    Create cells of a given type
	///
	/// vtkCellTypeSource is a source object that creates cells of the given
	/// input type. BlocksDimensions specifies the number of cell "blocks" in each
	/// direction. A cell block may be divided into multiple cells based on
	/// the chosen cell type (e.g. 6 pyramid cells make up a single cell block).
	/// If a 1D cell is selected then only the first dimension is
	/// used to specify how many cells are generated. If a 2D cell is
	/// selected then only the first and second dimensions are used to
	/// determine how many cells are created. The source respects pieces.
	/// </remarks>
	// Token: 0x02000821 RID: 2081
	public class vtkCellTypeSource : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601575C RID: 87900 RVA: 0x001E5AC1 File Offset: 0x001E3CC1
		static vtkCellTypeSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellTypeSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellTypeSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601575D RID: 87901 RVA: 0x001E5AE9 File Offset: 0x001E3CE9
		public vtkCellTypeSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601575E RID: 87902
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypeSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x0601575F RID: 87903 RVA: 0x001E5AF8 File Offset: 0x001E3CF8
		public new static vtkCellTypeSource New()
		{
			vtkCellTypeSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypeSource.vtkCellTypeSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTypeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015760 RID: 87904 RVA: 0x001E5B4C File Offset: 0x001E3D4C
		public vtkCellTypeSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellTypeSource.vtkCellTypeSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015761 RID: 87905 RVA: 0x001E5B90 File Offset: 0x001E3D90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015762 RID: 87906
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_CompleteQuadraticSimplicialElementsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
		///
		/// By default, quadratic Lagrange cells with simplicial shapes
		/// do not completely span the basis of all polynomial of the maximal
		/// degree. This can be corrected by adding mid-face and body-centered
		/// nodes. Setting this option to true will generate cells with these
		/// additional nodes.
		///
		/// This is only used when
		/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
		/// and (2) \a CellOrder is set to 2 (quadratic elements).
		/// The default is false.
		///
		/// When true, generated
		/// (1) triangles will have 7 nodes instead of 6;
		/// (2) tetrahedra will have 15 nodes instead of 10;
		/// (3) wedges will have 21 nodes instead of 18.
		/// </summary>
		// Token: 0x06015763 RID: 87907 RVA: 0x001E5B9B File Offset: 0x001E3D9B
		public virtual void CompleteQuadraticSimplicialElementsOff()
		{
			vtkCellTypeSource.vtkCellTypeSource_CompleteQuadraticSimplicialElementsOff_01(base.GetCppThis());
		}

		// Token: 0x06015764 RID: 87908
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_CompleteQuadraticSimplicialElementsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
		///
		/// By default, quadratic Lagrange cells with simplicial shapes
		/// do not completely span the basis of all polynomial of the maximal
		/// degree. This can be corrected by adding mid-face and body-centered
		/// nodes. Setting this option to true will generate cells with these
		/// additional nodes.
		///
		/// This is only used when
		/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
		/// and (2) \a CellOrder is set to 2 (quadratic elements).
		/// The default is false.
		///
		/// When true, generated
		/// (1) triangles will have 7 nodes instead of 6;
		/// (2) tetrahedra will have 15 nodes instead of 10;
		/// (3) wedges will have 21 nodes instead of 18.
		/// </summary>
		// Token: 0x06015765 RID: 87909 RVA: 0x001E5BAA File Offset: 0x001E3DAA
		public virtual void CompleteQuadraticSimplicialElementsOn()
		{
			vtkCellTypeSource.vtkCellTypeSource_CompleteQuadraticSimplicialElementsOn_02(base.GetCppThis());
		}

		// Token: 0x06015766 RID: 87910
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypeSource_GetBlocksDimensions_03(HandleRef pThis);

		/// <summary>
		/// Set the number of cells in each direction. If a 1D cell type is
		/// selected then only the first dimension is used and if a 2D cell
		/// type is selected then the first and second dimensions are used.
		/// Default is (1, 1, 1), which results in a single block of cells.
		/// </summary>
		// Token: 0x06015767 RID: 87911 RVA: 0x001E5BBC File Offset: 0x001E3DBC
		public virtual int[] GetBlocksDimensions()
		{
			IntPtr intPtr = vtkCellTypeSource.vtkCellTypeSource_GetBlocksDimensions_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06015768 RID: 87912
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_GetBlocksDimensions_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set the number of cells in each direction. If a 1D cell type is
		/// selected then only the first dimension is used and if a 2D cell
		/// type is selected then the first and second dimensions are used.
		/// Default is (1, 1, 1), which results in a single block of cells.
		/// </summary>
		// Token: 0x06015769 RID: 87913 RVA: 0x001E5C04 File Offset: 0x001E3E04
		public virtual void GetBlocksDimensions(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkCellTypeSource.vtkCellTypeSource_GetBlocksDimensions_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601576A RID: 87914
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_GetBlocksDimensions_05(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the number of cells in each direction. If a 1D cell type is
		/// selected then only the first dimension is used and if a 2D cell
		/// type is selected then the first and second dimensions are used.
		/// Default is (1, 1, 1), which results in a single block of cells.
		/// </summary>
		// Token: 0x0601576B RID: 87915 RVA: 0x001E5C16 File Offset: 0x001E3E16
		public virtual void GetBlocksDimensions(IntPtr _arg)
		{
			vtkCellTypeSource.vtkCellTypeSource_GetBlocksDimensions_05(base.GetCppThis(), _arg);
		}

		// Token: 0x0601576C RID: 87916
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetCellDimension_06(HandleRef pThis);

		/// <summary>
		/// Get the dimension of the cell blocks to be generated
		/// </summary>
		// Token: 0x0601576D RID: 87917 RVA: 0x001E5C28 File Offset: 0x001E3E28
		public int GetCellDimension()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetCellDimension_06(base.GetCppThis());
		}

		// Token: 0x0601576E RID: 87918
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetCellOrder_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the order of Lagrange interpolation to be used.
		///
		/// This is only used when the cell type is a Lagrange element.
		/// The default is cubic (order 3).
		/// Lagrange elements are the same order along all axes
		/// (i.e., you cannot specify a different interpolation order
		/// for the i, j, and k axes of a hexahedron).
		/// </summary>
		// Token: 0x0601576F RID: 87919 RVA: 0x001E5C48 File Offset: 0x001E3E48
		public virtual int GetCellOrder()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetCellOrder_07(base.GetCppThis());
		}

		// Token: 0x06015770 RID: 87920
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetCellType_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the type of cells to be generated.
		/// </summary>
		// Token: 0x06015771 RID: 87921 RVA: 0x001E5C68 File Offset: 0x001E3E68
		public virtual int GetCellType()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetCellType_08(base.GetCppThis());
		}

		// Token: 0x06015772 RID: 87922
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellTypeSource_GetCompleteQuadraticSimplicialElements_09(HandleRef pThis);

		/// <summary>
		/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
		///
		/// By default, quadratic Lagrange cells with simplicial shapes
		/// do not completely span the basis of all polynomial of the maximal
		/// degree. This can be corrected by adding mid-face and body-centered
		/// nodes. Setting this option to true will generate cells with these
		/// additional nodes.
		///
		/// This is only used when
		/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
		/// and (2) \a CellOrder is set to 2 (quadratic elements).
		/// The default is false.
		///
		/// When true, generated
		/// (1) triangles will have 7 nodes instead of 6;
		/// (2) tetrahedra will have 15 nodes instead of 10;
		/// (3) wedges will have 21 nodes instead of 18.
		/// </summary>
		// Token: 0x06015773 RID: 87923 RVA: 0x001E5C88 File Offset: 0x001E3E88
		public virtual bool GetCompleteQuadraticSimplicialElements()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetCompleteQuadraticSimplicialElements_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06015774 RID: 87924
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypeSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015775 RID: 87925 RVA: 0x001E5CB0 File Offset: 0x001E3EB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x06015776 RID: 87926
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellTypeSource_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015777 RID: 87927 RVA: 0x001E5CD0 File Offset: 0x001E3ED0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x06015778 RID: 87928
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetOutputPrecision_12(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015779 RID: 87929 RVA: 0x001E5CEC File Offset: 0x001E3EEC
		public virtual int GetOutputPrecision()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetOutputPrecision_12(base.GetCppThis());
		}

		// Token: 0x0601577A RID: 87930
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetOutputPrecisionMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
		/// </summary>
		// Token: 0x0601577B RID: 87931 RVA: 0x001E5D0C File Offset: 0x001E3F0C
		public virtual int GetOutputPrecisionMaxValue()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetOutputPrecisionMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0601577C RID: 87932
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetOutputPrecisionMinValue_14(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
		/// </summary>
		// Token: 0x0601577D RID: 87933 RVA: 0x001E5D2C File Offset: 0x001E3F2C
		public virtual int GetOutputPrecisionMinValue()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetOutputPrecisionMinValue_14(base.GetCppThis());
		}

		// Token: 0x0601577E RID: 87934
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetPolynomialFieldOrder_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the polynomial order of the "Polynomial" point field.
		/// The default is 1.
		/// </summary>
		// Token: 0x0601577F RID: 87935 RVA: 0x001E5D4C File Offset: 0x001E3F4C
		public virtual int GetPolynomialFieldOrder()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetPolynomialFieldOrder_15(base.GetCppThis());
		}

		// Token: 0x06015780 RID: 87936
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetPolynomialFieldOrderMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the polynomial order of the "Polynomial" point field.
		/// The default is 1.
		/// </summary>
		// Token: 0x06015781 RID: 87937 RVA: 0x001E5D6C File Offset: 0x001E3F6C
		public virtual int GetPolynomialFieldOrderMaxValue()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetPolynomialFieldOrderMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06015782 RID: 87938
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_GetPolynomialFieldOrderMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the polynomial order of the "Polynomial" point field.
		/// The default is 1.
		/// </summary>
		// Token: 0x06015783 RID: 87939 RVA: 0x001E5D8C File Offset: 0x001E3F8C
		public virtual int GetPolynomialFieldOrderMinValue()
		{
			return vtkCellTypeSource.vtkCellTypeSource_GetPolynomialFieldOrderMinValue_17(base.GetCppThis());
		}

		// Token: 0x06015784 RID: 87940
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015785 RID: 87941 RVA: 0x001E5DAC File Offset: 0x001E3FAC
		public override int IsA(string type)
		{
			return vtkCellTypeSource.vtkCellTypeSource_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06015786 RID: 87942
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellTypeSource_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015787 RID: 87943 RVA: 0x001E5DCC File Offset: 0x001E3FCC
		public new static int IsTypeOf(string type)
		{
			return vtkCellTypeSource.vtkCellTypeSource_IsTypeOf_19(type);
		}

		// Token: 0x06015788 RID: 87944
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypeSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x06015789 RID: 87945 RVA: 0x001E5DE8 File Offset: 0x001E3FE8
		public new vtkCellTypeSource NewInstance()
		{
			vtkCellTypeSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypeSource.vtkCellTypeSource_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellTypeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601578A RID: 87946
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellTypeSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type and printing instance values.
		/// </summary>
		// Token: 0x0601578B RID: 87947 RVA: 0x001E5E44 File Offset: 0x001E4044
		public new static vtkCellTypeSource SafeDownCast(vtkObjectBase o)
		{
			vtkCellTypeSource vtkCellTypeSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellTypeSource.vtkCellTypeSource_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellTypeSource = (vtkCellTypeSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellTypeSource.Register(null);
				}
			}
			return vtkCellTypeSource;
		}

		// Token: 0x0601578C RID: 87948
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetBlocksDimensions_23(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set the number of cells in each direction. If a 1D cell type is
		/// selected then only the first dimension is used and if a 2D cell
		/// type is selected then the first and second dimensions are used.
		/// Default is (1, 1, 1), which results in a single block of cells.
		/// </summary>
		// Token: 0x0601578D RID: 87949 RVA: 0x001E5EC3 File Offset: 0x001E40C3
		public void SetBlocksDimensions(IntPtr arg0)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetBlocksDimensions_23(base.GetCppThis(), arg0);
		}

		// Token: 0x0601578E RID: 87950
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetBlocksDimensions_24(HandleRef pThis, int arg0, int arg1, int arg2);

		/// <summary>
		/// Set the number of cells in each direction. If a 1D cell type is
		/// selected then only the first dimension is used and if a 2D cell
		/// type is selected then the first and second dimensions are used.
		/// Default is (1, 1, 1), which results in a single block of cells.
		/// </summary>
		// Token: 0x0601578F RID: 87951 RVA: 0x001E5ED3 File Offset: 0x001E40D3
		public void SetBlocksDimensions(int arg0, int arg1, int arg2)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetBlocksDimensions_24(base.GetCppThis(), arg0, arg1, arg2);
		}

		// Token: 0x06015790 RID: 87952
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetCellOrder_25(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the order of Lagrange interpolation to be used.
		///
		/// This is only used when the cell type is a Lagrange element.
		/// The default is cubic (order 3).
		/// Lagrange elements are the same order along all axes
		/// (i.e., you cannot specify a different interpolation order
		/// for the i, j, and k axes of a hexahedron).
		/// </summary>
		// Token: 0x06015791 RID: 87953 RVA: 0x001E5EE5 File Offset: 0x001E40E5
		public virtual void SetCellOrder(int _arg)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetCellOrder_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06015792 RID: 87954
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetCellType_26(HandleRef pThis, int cellType);

		/// <summary>
		/// Set/Get the type of cells to be generated.
		/// </summary>
		// Token: 0x06015793 RID: 87955 RVA: 0x001E5EF5 File Offset: 0x001E40F5
		public void SetCellType(int cellType)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetCellType_26(base.GetCppThis(), cellType);
		}

		// Token: 0x06015794 RID: 87956
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetCompleteQuadraticSimplicialElements_27(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get whether quadratic cells with simplicial shapes should be "completed".
		///
		/// By default, quadratic Lagrange cells with simplicial shapes
		/// do not completely span the basis of all polynomial of the maximal
		/// degree. This can be corrected by adding mid-face and body-centered
		/// nodes. Setting this option to true will generate cells with these
		/// additional nodes.
		///
		/// This is only used when
		/// (1) the cell type is a Lagrange triangle, tetrahedron, or wedge;
		/// and (2) \a CellOrder is set to 2 (quadratic elements).
		/// The default is false.
		///
		/// When true, generated
		/// (1) triangles will have 7 nodes instead of 6;
		/// (2) tetrahedra will have 15 nodes instead of 10;
		/// (3) wedges will have 21 nodes instead of 18.
		/// </summary>
		// Token: 0x06015795 RID: 87957 RVA: 0x001E5F05 File Offset: 0x001E4105
		public virtual void SetCompleteQuadraticSimplicialElements(bool _arg)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetCompleteQuadraticSimplicialElements_27(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06015796 RID: 87958
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetOutputPrecision_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points.
		/// vtkAlgorithm::SINGLE_PRECISION (0) - Output single-precision floating point.
		/// vtkAlgorithm::DOUBLE_PRECISION (1) - Output double-precision floating point.
		/// </summary>
		// Token: 0x06015797 RID: 87959 RVA: 0x001E5F1D File Offset: 0x001E411D
		public virtual void SetOutputPrecision(int _arg)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetOutputPrecision_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06015798 RID: 87960
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellTypeSource_SetPolynomialFieldOrder_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the polynomial order of the "Polynomial" point field.
		/// The default is 1.
		/// </summary>
		// Token: 0x06015799 RID: 87961 RVA: 0x001E5F2D File Offset: 0x001E412D
		public virtual void SetPolynomialFieldOrder(int _arg)
		{
			vtkCellTypeSource.vtkCellTypeSource_SetPolynomialFieldOrder_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400188B RID: 6283
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellTypeSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400188C RID: 6284
		public new static readonly string MRClassNameKey = "class vtkCellTypeSource";
	}
}
