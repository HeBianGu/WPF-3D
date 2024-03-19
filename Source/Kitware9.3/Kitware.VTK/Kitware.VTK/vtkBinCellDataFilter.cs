using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBinCellDataFilter
	/// </summary>
	/// <remarks>
	///    bin source cell data into input cells.
	///
	/// vtkBinCellDataFilter takes a source mesh containing scalar cell data, an
	/// input mesh and a set of bin values and bins the source mesh's scalar cell
	/// data into the cells of the input mesh. The resulting output mesh is identical
	/// to the input mesh, with an additional cell data field, with tuple size equal
	/// to the number of bins + 1, that represents a histogram of the cell data
	/// values for all of the source cells whose centroid lie within the input cell.
	///
	/// This filter is useful for analyzing the efficacy of an input mesh's ability
	/// to represent the cell data of the source mesh.
	/// </remarks>
	// Token: 0x02000943 RID: 2371
	public class vtkBinCellDataFilter : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018922 RID: 100642 RVA: 0x00225893 File Offset: 0x00223A93
		static vtkBinCellDataFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBinCellDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBinCellDataFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018923 RID: 100643 RVA: 0x002258BB File Offset: 0x00223ABB
		public vtkBinCellDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018924 RID: 100644
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with initial range (VTK_DOUBLE_MIN, VTK_DOUBLE_MAX) and
		/// a single bin.
		/// </summary>
		// Token: 0x06018925 RID: 100645 RVA: 0x002258CC File Offset: 0x00223ACC
		public new static vtkBinCellDataFilter New()
		{
			vtkBinCellDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinCellDataFilter.vtkBinCellDataFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBinCellDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with initial range (VTK_DOUBLE_MIN, VTK_DOUBLE_MAX) and
		/// a single bin.
		/// </summary>
		// Token: 0x06018926 RID: 100646 RVA: 0x00225920 File Offset: 0x00223B20
		public vtkBinCellDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBinCellDataFilter.vtkBinCellDataFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018927 RID: 100647 RVA: 0x00225964 File Offset: 0x00223B64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018928 RID: 100648
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_ComputeToleranceOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field value is ignored.
		/// Off by default.
		/// </summary>
		// Token: 0x06018929 RID: 100649 RVA: 0x0022596F File Offset: 0x00223B6F
		public virtual void ComputeToleranceOff()
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_ComputeToleranceOff_01(base.GetCppThis());
		}

		// Token: 0x0601892A RID: 100650
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_ComputeToleranceOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field value is ignored.
		/// Off by default.
		/// </summary>
		// Token: 0x0601892B RID: 100651 RVA: 0x0022597E File Offset: 0x00223B7E
		public virtual void ComputeToleranceOn()
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_ComputeToleranceOn_02(base.GetCppThis());
		}

		// Token: 0x0601892C RID: 100652
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_GenerateValues_03(HandleRef pThis, int numBins, IntPtr range);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x0601892D RID: 100653 RVA: 0x0022598D File Offset: 0x00223B8D
		public void GenerateValues(int numBins, IntPtr range)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_GenerateValues_03(base.GetCppThis(), numBins, range);
		}

		// Token: 0x0601892E RID: 100654
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_GenerateValues_04(HandleRef pThis, int numBins, double rangeStart, double rangeEnd);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x0601892F RID: 100655 RVA: 0x0022599E File Offset: 0x00223B9E
		public void GenerateValues(int numBins, double rangeStart, double rangeEnd)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_GenerateValues_04(base.GetCppThis(), numBins, rangeStart, rangeEnd);
		}

		// Token: 0x06018930 RID: 100656
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_GetArrayComponent_05(HandleRef pThis);

		/// <summary>
		/// Set/get which component of the scalar array to bin; defaults to 0.
		/// </summary>
		// Token: 0x06018931 RID: 100657 RVA: 0x002259B0 File Offset: 0x00223BB0
		public virtual int GetArrayComponent()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetArrayComponent_05(base.GetCppThis());
		}

		// Token: 0x06018932 RID: 100658
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_GetCellLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a spatial locator for speeding the search process. By
		/// default an instance of vtkStaticCellLocator is used.
		/// </summary>
		// Token: 0x06018933 RID: 100659 RVA: 0x002259D0 File Offset: 0x00223BD0
		public virtual vtkAbstractCellLocator GetCellLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinCellDataFilter.vtkBinCellDataFilter_GetCellLocator_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x06018934 RID: 100660
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_GetCellOverlapMethod_07(HandleRef pThis);

		/// <summary>
		/// Set whether cell overlap is determined by source cell centroid or by source
		/// cell points.
		/// Centroid by default.
		/// </summary>
		// Token: 0x06018935 RID: 100661 RVA: 0x00225A40 File Offset: 0x00223C40
		public virtual int GetCellOverlapMethod()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetCellOverlapMethod_07(base.GetCppThis());
		}

		// Token: 0x06018936 RID: 100662
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_GetCellOverlapMethodMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set whether cell overlap is determined by source cell centroid or by source
		/// cell points.
		/// Centroid by default.
		/// </summary>
		// Token: 0x06018937 RID: 100663 RVA: 0x00225A60 File Offset: 0x00223C60
		public virtual int GetCellOverlapMethodMaxValue()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetCellOverlapMethodMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06018938 RID: 100664
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_GetCellOverlapMethodMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set whether cell overlap is determined by source cell centroid or by source
		/// cell points.
		/// Centroid by default.
		/// </summary>
		// Token: 0x06018939 RID: 100665 RVA: 0x00225A80 File Offset: 0x00223C80
		public virtual int GetCellOverlapMethodMinValue()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetCellOverlapMethodMinValue_09(base.GetCppThis());
		}

		// Token: 0x0601893A RID: 100666
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBinCellDataFilter_GetComputeTolerance_10(HandleRef pThis);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field value is ignored.
		/// Off by default.
		/// </summary>
		// Token: 0x0601893B RID: 100667 RVA: 0x00225AA0 File Offset: 0x00223CA0
		public virtual bool GetComputeTolerance()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetComputeTolerance_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601893C RID: 100668
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBinCellDataFilter_GetNumberOfBins_11(HandleRef pThis);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x0601893D RID: 100669 RVA: 0x00225AC8 File Offset: 0x00223CC8
		public long GetNumberOfBins()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetNumberOfBins_11(base.GetCppThis());
		}

		// Token: 0x0601893E RID: 100670
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBinCellDataFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x0601893F RID: 100671 RVA: 0x00225AE8 File Offset: 0x00223CE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x06018940 RID: 100672
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBinCellDataFilter_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x06018941 RID: 100673 RVA: 0x00225B08 File Offset: 0x00223D08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x06018942 RID: 100674
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_GetNumberOfNonzeroBinsArrayName_14(HandleRef pThis);

		/// <summary>
		/// Returns the name of the id array added to the output that holds the number
		/// of nonzero bins per cell.
		/// Set to "NumberOfNonzeroBins" by default.
		/// </summary>
		// Token: 0x06018943 RID: 100675 RVA: 0x00225B24 File Offset: 0x00223D24
		public virtual string GetNumberOfNonzeroBinsArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkBinCellDataFilter.vtkBinCellDataFilter_GetNumberOfNonzeroBinsArrayName_14(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06018944 RID: 100676
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_GetSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the data set whose cells will be counted.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is used to determine how many source cells lie within
		/// each input cell.
		/// </summary>
		// Token: 0x06018945 RID: 100677 RVA: 0x00225B60 File Offset: 0x00223D60
		public vtkDataObject GetSource()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinCellDataFilter.vtkBinCellDataFilter_GetSource_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06018946 RID: 100678
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_GetSpatialMatch_16(HandleRef pThis);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x06018947 RID: 100679 RVA: 0x00225BD0 File Offset: 0x00223DD0
		public virtual int GetSpatialMatch()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetSpatialMatch_16(base.GetCppThis());
		}

		// Token: 0x06018948 RID: 100680
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkBinCellDataFilter_GetStoreNumberOfNonzeroBins_17(HandleRef pThis);

		/// <summary>
		/// Set whether to store the number of nonzero bins for each cell.
		/// On by default.
		/// </summary>
		// Token: 0x06018949 RID: 100681 RVA: 0x00225BF0 File Offset: 0x00223DF0
		public virtual bool GetStoreNumberOfNonzeroBins()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetStoreNumberOfNonzeroBins_17(base.GetCppThis()) != 0;
		}

		// Token: 0x0601894A RID: 100682
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBinCellDataFilter_GetTolerance_18(HandleRef pThis);

		/// <summary>
		/// Set the tolerance used to compute whether a cell centroid in the
		/// source is in a cell of the input.  This value is only used
		/// if ComputeTolerance is off.
		/// </summary>
		// Token: 0x0601894B RID: 100683 RVA: 0x00225C18 File Offset: 0x00223E18
		public virtual double GetTolerance()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetTolerance_18(base.GetCppThis());
		}

		// Token: 0x0601894C RID: 100684
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBinCellDataFilter_GetValue_19(HandleRef pThis, int i);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x0601894D RID: 100685 RVA: 0x00225C38 File Offset: 0x00223E38
		public double GetValue(int i)
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetValue_19(base.GetCppThis(), i);
		}

		// Token: 0x0601894E RID: 100686
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_GetValues_20(HandleRef pThis);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x0601894F RID: 100687 RVA: 0x00225C58 File Offset: 0x00223E58
		public IntPtr GetValues()
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_GetValues_20(base.GetCppThis());
		}

		// Token: 0x06018950 RID: 100688
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_GetValues_21(HandleRef pThis, IntPtr binValues);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x06018951 RID: 100689 RVA: 0x00225C77 File Offset: 0x00223E77
		public void GetValues(IntPtr binValues)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_GetValues_21(base.GetCppThis(), binValues);
		}

		// Token: 0x06018952 RID: 100690
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x06018953 RID: 100691 RVA: 0x00225C88 File Offset: 0x00223E88
		public override int IsA(string type)
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06018954 RID: 100692
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBinCellDataFilter_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x06018955 RID: 100693 RVA: 0x00225CA8 File Offset: 0x00223EA8
		public new static int IsTypeOf(string type)
		{
			return vtkBinCellDataFilter.vtkBinCellDataFilter_IsTypeOf_23(type);
		}

		// Token: 0x06018956 RID: 100694
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x06018957 RID: 100695 RVA: 0x00225CC4 File Offset: 0x00223EC4
		public new vtkBinCellDataFilter NewInstance()
		{
			vtkBinCellDataFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinCellDataFilter.vtkBinCellDataFilter_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBinCellDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018958 RID: 100696
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBinCellDataFilter_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type and printing.
		/// </summary>
		// Token: 0x06018959 RID: 100697 RVA: 0x00225D20 File Offset: 0x00223F20
		public new static vtkBinCellDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkBinCellDataFilter vtkBinCellDataFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBinCellDataFilter.vtkBinCellDataFilter_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBinCellDataFilter = (vtkBinCellDataFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBinCellDataFilter.Register(null);
				}
			}
			return vtkBinCellDataFilter;
		}

		// Token: 0x0601895A RID: 100698
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetArrayComponent_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get which component of the scalar array to bin; defaults to 0.
		/// </summary>
		// Token: 0x0601895B RID: 100699 RVA: 0x00225D9F File Offset: 0x00223F9F
		public virtual void SetArrayComponent(int _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetArrayComponent_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601895C RID: 100700
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetCellLocator_28(HandleRef pThis, HandleRef cellLocator);

		/// <summary>
		/// Set/Get a spatial locator for speeding the search process. By
		/// default an instance of vtkStaticCellLocator is used.
		/// </summary>
		// Token: 0x0601895D RID: 100701 RVA: 0x00225DB0 File Offset: 0x00223FB0
		public virtual void SetCellLocator(vtkAbstractCellLocator cellLocator)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetCellLocator_28(base.GetCppThis(), (cellLocator == null) ? default(HandleRef) : cellLocator.GetCppThis());
		}

		// Token: 0x0601895E RID: 100702
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetCellOverlapMethod_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether cell overlap is determined by source cell centroid or by source
		/// cell points.
		/// Centroid by default.
		/// </summary>
		// Token: 0x0601895F RID: 100703 RVA: 0x00225DDF File Offset: 0x00223FDF
		public virtual void SetCellOverlapMethod(int _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetCellOverlapMethod_29(base.GetCppThis(), _arg);
		}

		// Token: 0x06018960 RID: 100704
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetComputeTolerance_30(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to use the Tolerance field or precompute the tolerance.
		/// When on, the tolerance will be computed and the field value is ignored.
		/// Off by default.
		/// </summary>
		// Token: 0x06018961 RID: 100705 RVA: 0x00225DEF File Offset: 0x00223FEF
		public virtual void SetComputeTolerance(bool _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetComputeTolerance_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06018962 RID: 100706
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetNumberOfBins_31(HandleRef pThis, int numBins);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x06018963 RID: 100707 RVA: 0x00225E07 File Offset: 0x00224007
		public void SetNumberOfBins(int numBins)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetNumberOfBins_31(base.GetCppThis(), numBins);
		}

		// Token: 0x06018964 RID: 100708
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetNumberOfNonzeroBinsArrayName_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Returns the name of the id array added to the output that holds the number
		/// of nonzero bins per cell.
		/// Set to "NumberOfNonzeroBins" by default.
		/// </summary>
		// Token: 0x06018965 RID: 100709 RVA: 0x00225E17 File Offset: 0x00224017
		public virtual void SetNumberOfNonzeroBinsArrayName(string _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetNumberOfNonzeroBinsArrayName_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06018966 RID: 100710
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetSourceConnection_33(HandleRef pThis, HandleRef algOutput);

		/// <summary>
		/// Specify the data set whose cells will be counted.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is used to determine how many source cells lie within
		/// each input cell.
		/// </summary>
		// Token: 0x06018967 RID: 100711 RVA: 0x00225E28 File Offset: 0x00224028
		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetSourceConnection_33(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		// Token: 0x06018968 RID: 100712
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetSourceData_34(HandleRef pThis, HandleRef source);

		/// <summary>
		/// Specify the data set whose cells will be counted.
		/// The Input gives the geometry (the points and cells) for the output,
		/// while the Source is used to determine how many source cells lie within
		/// each input cell.
		/// </summary>
		// Token: 0x06018969 RID: 100713 RVA: 0x00225E58 File Offset: 0x00224058
		public void SetSourceData(vtkDataObject source)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetSourceData_34(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601896A RID: 100714
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetSpatialMatch_35(HandleRef pThis, int _arg);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x0601896B RID: 100715 RVA: 0x00225E87 File Offset: 0x00224087
		public virtual void SetSpatialMatch(int _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetSpatialMatch_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0601896C RID: 100716
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetStoreNumberOfNonzeroBins_36(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set whether to store the number of nonzero bins for each cell.
		/// On by default.
		/// </summary>
		// Token: 0x0601896D RID: 100717 RVA: 0x00225E97 File Offset: 0x00224097
		public virtual void SetStoreNumberOfNonzeroBins(bool _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetStoreNumberOfNonzeroBins_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601896E RID: 100718
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetTolerance_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance used to compute whether a cell centroid in the
		/// source is in a cell of the input.  This value is only used
		/// if ComputeTolerance is off.
		/// </summary>
		// Token: 0x0601896F RID: 100719 RVA: 0x00225EAF File Offset: 0x002240AF
		public virtual void SetTolerance(double _arg)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetTolerance_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06018970 RID: 100720
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SetValue_38(HandleRef pThis, int i, double value);

		/// <summary>
		/// Methods to set / get bin values.
		/// </summary>
		// Token: 0x06018971 RID: 100721 RVA: 0x00225EBF File Offset: 0x002240BF
		public void SetValue(int i, double value)
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SetValue_38(base.GetCppThis(), i, value);
		}

		// Token: 0x06018972 RID: 100722
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SpatialMatchOff_39(HandleRef pThis);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x06018973 RID: 100723 RVA: 0x00225ED0 File Offset: 0x002240D0
		public virtual void SpatialMatchOff()
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SpatialMatchOff_39(base.GetCppThis());
		}

		// Token: 0x06018974 RID: 100724
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_SpatialMatchOn_40(HandleRef pThis);

		/// <summary>
		/// This flag is used only when a piece is requested to update.  By default
		/// the flag is off.  Because no spatial correspondence between input pieces
		/// and source pieces is known, all of the source has to be requested no
		/// matter what piece of the output is requested.  When there is a spatial
		/// correspondence, the user/application can set this flag.  This hint allows
		/// the breakup of the probe operation to be much more efficient.  When piece
		/// m of n is requested for update by the user, then only n of m needs to
		/// be requested of the source.
		/// </summary>
		// Token: 0x06018975 RID: 100725 RVA: 0x00225EDF File Offset: 0x002240DF
		public virtual void SpatialMatchOn()
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_SpatialMatchOn_40(base.GetCppThis());
		}

		// Token: 0x06018976 RID: 100726
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOff_41(HandleRef pThis);

		/// <summary>
		/// Set whether to store the number of nonzero bins for each cell.
		/// On by default.
		/// </summary>
		// Token: 0x06018977 RID: 100727 RVA: 0x00225EEE File Offset: 0x002240EE
		public virtual void StoreNumberOfNonzeroBinsOff()
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOff_41(base.GetCppThis());
		}

		// Token: 0x06018978 RID: 100728
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOn_42(HandleRef pThis);

		/// <summary>
		/// Set whether to store the number of nonzero bins for each cell.
		/// On by default.
		/// </summary>
		// Token: 0x06018979 RID: 100729 RVA: 0x00225EFD File Offset: 0x002240FD
		public virtual void StoreNumberOfNonzeroBinsOn()
		{
			vtkBinCellDataFilter.vtkBinCellDataFilter_StoreNumberOfNonzeroBinsOn_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B36 RID: 6966
		public new const string MRFullTypeName = "Kitware.VTK.vtkBinCellDataFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B37 RID: 6967
		public new static readonly string MRClassNameKey = "class vtkBinCellDataFilter";

		/// <summary>
		/// Set/get which component of the scalar array to bin; defaults to 0.
		/// </summary>
		// Token: 0x02000944 RID: 2372
		public enum CellOverlapCriterion
		{
			/// <summary>enum member</summary>
			// Token: 0x04001B39 RID: 6969
			CELL_CENTROID,
			/// <summary>enum member</summary>
			// Token: 0x04001B3A RID: 6970
			CELL_POINTS
		}
	}
}
