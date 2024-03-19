using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractHistogram2D
	/// </summary>
	/// <remarks>
	///    compute a 2D histogram between two columns
	///  of an input vtkTable.
	///
	///
	///  This class computes a 2D histogram between two columns of an input
	///  vtkTable. Just as with a 1D histogram, a 2D histogram breaks
	///  up the input domain into bins, and each pair of values (row in
	///  the table) fits into a single bin and increments a row counter
	///  for that bin.
	///
	///  To use this class, set the input with a table and call AddColumnPair(nameX,nameY),
	///  where nameX and nameY are the names of the two columns to be used.
	///
	///  In addition to the number of bins (in X and Y), the domain of
	///  the histogram can be customized by toggling the UseCustomHistogramExtents
	///  flag and setting the CustomHistogramExtents variable to the
	///  desired value.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkPExtractHistogram2D
	///
	/// @par Thanks:
	///  Developed by David Feng and Philippe Pebay at Sandia National Laboratories
	///             ------------------------------------------------------------------------------
	/// </seealso>
	// Token: 0x02000475 RID: 1141
	public class vtkExtractHistogram2D : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D287 RID: 53895 RVA: 0x001250C1 File Offset: 0x001232C1
		static vtkExtractHistogram2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHistogram2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D288 RID: 53896 RVA: 0x001250E9 File Offset: 0x001232E9
		public vtkExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D289 RID: 53897
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D28A RID: 53898 RVA: 0x001250F8 File Offset: 0x001232F8
		public new static vtkExtractHistogram2D New()
		{
			vtkExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D28B RID: 53899 RVA: 0x0012514C File Offset: 0x0012334C
		public vtkExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractHistogram2D.vtkExtractHistogram2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D28C RID: 53900 RVA: 0x00125190 File Offset: 0x00123390
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D28D RID: 53901
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model. Not used.
		/// </summary>
		// Token: 0x0600D28E RID: 53902 RVA: 0x0012519C File Offset: 0x0012339C
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600D28F RID: 53903
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_GetBinRange_02(HandleRef pThis, long binX, long binY, IntPtr range);

		/// <summary>
		/// Compute the range of the bin located at position (binX,binY) in
		/// the 2D histogram.
		/// </summary>
		// Token: 0x0600D290 RID: 53904 RVA: 0x001251E0 File Offset: 0x001233E0
		public int GetBinRange(long binX, long binY, IntPtr range)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetBinRange_02(base.GetCppThis(), binX, binY, range);
		}

		// Token: 0x0600D291 RID: 53905
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_GetBinRange_03(HandleRef pThis, long bin, IntPtr range);

		/// <summary>
		/// Get the range of the of the bin located at 1D position index bin
		/// in the 2D histogram array.
		/// </summary>
		// Token: 0x0600D292 RID: 53906 RVA: 0x00125204 File Offset: 0x00123404
		public int GetBinRange(long bin, IntPtr range)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetBinRange_03(base.GetCppThis(), bin, range);
		}

		// Token: 0x0600D293 RID: 53907
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetBinWidth_04(HandleRef pThis, IntPtr bw);

		/// <summary>
		/// Get the width of all of the bins. Also stored in the spacing
		/// ivar of the histogram image output.
		/// </summary>
		// Token: 0x0600D294 RID: 53908 RVA: 0x00125225 File Offset: 0x00123425
		public void GetBinWidth(IntPtr bw)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetBinWidth_04(base.GetCppThis(), bw);
		}

		// Token: 0x0600D295 RID: 53909
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_GetComponentsToProcess_05(HandleRef pThis);

		/// <summary>
		/// Set/get the components of the arrays in the two input columns
		/// to be used during histogram computation.  Defaults to component 0.
		/// </summary>
		// Token: 0x0600D296 RID: 53910 RVA: 0x00125238 File Offset: 0x00123438
		public virtual int[] GetComponentsToProcess()
		{
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetComponentsToProcess_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D297 RID: 53911
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetComponentsToProcess_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the components of the arrays in the two input columns
		/// to be used during histogram computation.  Defaults to component 0.
		/// </summary>
		// Token: 0x0600D298 RID: 53912 RVA: 0x00125280 File Offset: 0x00123480
		public virtual void GetComponentsToProcess(ref int _arg1, ref int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetComponentsToProcess_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600D299 RID: 53913
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetComponentsToProcess_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the components of the arrays in the two input columns
		/// to be used during histogram computation.  Defaults to component 0.
		/// </summary>
		// Token: 0x0600D29A RID: 53914 RVA: 0x00125291 File Offset: 0x00123491
		public virtual void GetComponentsToProcess(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetComponentsToProcess_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D29B RID: 53915
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_GetCustomHistogramExtents_08(HandleRef pThis);

		/// <summary>
		/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
		/// must be called for these to actually be used.
		/// </summary>
		// Token: 0x0600D29C RID: 53916 RVA: 0x001252A4 File Offset: 0x001234A4
		public virtual double[] GetCustomHistogramExtents()
		{
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetCustomHistogramExtents_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D29D RID: 53917
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetCustomHistogramExtents_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
		/// must be called for these to actually be used.
		/// </summary>
		// Token: 0x0600D29E RID: 53918 RVA: 0x001252EC File Offset: 0x001234EC
		public virtual void GetCustomHistogramExtents(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetCustomHistogramExtents_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600D29F RID: 53919
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetCustomHistogramExtents_10(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
		/// must be called for these to actually be used.
		/// </summary>
		// Token: 0x0600D2A0 RID: 53920 RVA: 0x00125300 File Offset: 0x00123500
		public virtual void GetCustomHistogramExtents(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetCustomHistogramExtents_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2A1 RID: 53921
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_GetHistogramExtents_11(HandleRef pThis);

		/// <summary>
		/// Get the histogram extents currently in use, either computed
		/// or set by the user.
		/// </summary>
		// Token: 0x0600D2A2 RID: 53922 RVA: 0x00125310 File Offset: 0x00123510
		public IntPtr GetHistogramExtents()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetHistogramExtents_11(base.GetCppThis());
		}

		// Token: 0x0600D2A3 RID: 53923
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkExtractHistogram2D_GetMaximumBinCount_12(HandleRef pThis);

		/// <summary>
		/// Access the count of the histogram bin containing the largest number
		/// of input rows.
		/// </summary>
		// Token: 0x0600D2A4 RID: 53924 RVA: 0x00125330 File Offset: 0x00123530
		public virtual double GetMaximumBinCount()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetMaximumBinCount_12(base.GetCppThis());
		}

		// Token: 0x0600D2A5 RID: 53925
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_GetNumberOfBins_13(HandleRef pThis);

		/// <summary>
		/// Set/get the number of bins to be used per dimension (x,y)
		/// </summary>
		// Token: 0x0600D2A6 RID: 53926 RVA: 0x00125350 File Offset: 0x00123550
		public virtual int[] GetNumberOfBins()
		{
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfBins_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D2A7 RID: 53927
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetNumberOfBins_14(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the number of bins to be used per dimension (x,y)
		/// </summary>
		// Token: 0x0600D2A8 RID: 53928 RVA: 0x00125398 File Offset: 0x00123598
		public virtual void GetNumberOfBins(ref int _arg1, ref int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfBins_14(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600D2A9 RID: 53929
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_GetNumberOfBins_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the number of bins to be used per dimension (x,y)
		/// </summary>
		// Token: 0x0600D2AA RID: 53930 RVA: 0x001253A9 File Offset: 0x001235A9
		public virtual void GetNumberOfBins(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfBins_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2AB RID: 53931
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractHistogram2D_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2AC RID: 53932 RVA: 0x001253BC File Offset: 0x001235BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D2AD RID: 53933
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractHistogram2D_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2AE RID: 53934 RVA: 0x001253DC File Offset: 0x001235DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600D2AF RID: 53935
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_GetOutputHistogramImage_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Gets the data object at the histogram image output port and
		/// casts it to a vtkImageData.
		/// </summary>
		// Token: 0x0600D2B0 RID: 53936 RVA: 0x001253F8 File Offset: 0x001235F8
		public vtkImageData GetOutputHistogramImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetOutputHistogramImage_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600D2B1 RID: 53937
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_GetRowMask_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an optional mask that can ignore rows of the table
		/// </summary>
		// Token: 0x0600D2B2 RID: 53938 RVA: 0x00125468 File Offset: 0x00123668
		public virtual vtkDataArray GetRowMask()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_GetRowMask_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600D2B3 RID: 53939
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_GetScalarType_20(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2B4 RID: 53940 RVA: 0x001254D8 File Offset: 0x001236D8
		public virtual int GetScalarType()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetScalarType_20(base.GetCppThis());
		}

		// Token: 0x0600D2B5 RID: 53941
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_GetSwapColumns_21(HandleRef pThis);

		/// <summary>
		/// Get the histogram extents currently in use, either computed
		/// or set by the user.
		/// </summary>
		// Token: 0x0600D2B6 RID: 53942 RVA: 0x001254F8 File Offset: 0x001236F8
		public virtual int GetSwapColumns()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetSwapColumns_21(base.GetCppThis());
		}

		// Token: 0x0600D2B7 RID: 53943
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_GetUseCustomHistogramExtents_22(HandleRef pThis);

		/// <summary>
		/// Use the extents in CustomHistogramExtents when computing the
		/// histogram, rather than the simple range of the input columns.
		/// </summary>
		// Token: 0x0600D2B8 RID: 53944 RVA: 0x00125518 File Offset: 0x00123718
		public virtual int GetUseCustomHistogramExtents()
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_GetUseCustomHistogramExtents_22(base.GetCppThis());
		}

		// Token: 0x0600D2B9 RID: 53945
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2BA RID: 53946 RVA: 0x00125538 File Offset: 0x00123738
		public override int IsA(string type)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0600D2BB RID: 53947
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHistogram2D_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2BC RID: 53948 RVA: 0x00125558 File Offset: 0x00123758
		public new static int IsTypeOf(string type)
		{
			return vtkExtractHistogram2D.vtkExtractHistogram2D_IsTypeOf_24(type);
		}

		// Token: 0x0600D2BD RID: 53949
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2BE RID: 53950 RVA: 0x00125574 File Offset: 0x00123774
		public new vtkExtractHistogram2D NewInstance()
		{
			vtkExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D2BF RID: 53951
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHistogram2D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D2C0 RID: 53952 RVA: 0x001255D0 File Offset: 0x001237D0
		public new static vtkExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkExtractHistogram2D vtkExtractHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHistogram2D.vtkExtractHistogram2D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractHistogram2D = (vtkExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractHistogram2D.Register(null);
				}
			}
			return vtkExtractHistogram2D;
		}

		// Token: 0x0600D2C1 RID: 53953
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetComponentsToProcess_28(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the components of the arrays in the two input columns
		/// to be used during histogram computation.  Defaults to component 0.
		/// </summary>
		// Token: 0x0600D2C2 RID: 53954 RVA: 0x0012564F File Offset: 0x0012384F
		public virtual void SetComponentsToProcess(int _arg1, int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetComponentsToProcess_28(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600D2C3 RID: 53955
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetComponentsToProcess_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the components of the arrays in the two input columns
		/// to be used during histogram computation.  Defaults to component 0.
		/// </summary>
		// Token: 0x0600D2C4 RID: 53956 RVA: 0x00125660 File Offset: 0x00123860
		public void SetComponentsToProcess(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetComponentsToProcess_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2C5 RID: 53957
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetCustomHistogramExtents_30(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
		/// must be called for these to actually be used.
		/// </summary>
		// Token: 0x0600D2C6 RID: 53958 RVA: 0x00125670 File Offset: 0x00123870
		public virtual void SetCustomHistogramExtents(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetCustomHistogramExtents_30(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600D2C7 RID: 53959
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetCustomHistogramExtents_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get a custom domain for histogram computation.  UseCustomHistogramExtents
		/// must be called for these to actually be used.
		/// </summary>
		// Token: 0x0600D2C8 RID: 53960 RVA: 0x00125684 File Offset: 0x00123884
		public virtual void SetCustomHistogramExtents(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetCustomHistogramExtents_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2C9 RID: 53961
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetNumberOfBins_32(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the number of bins to be used per dimension (x,y)
		/// </summary>
		// Token: 0x0600D2CA RID: 53962 RVA: 0x00125694 File Offset: 0x00123894
		public virtual void SetNumberOfBins(int _arg1, int _arg2)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetNumberOfBins_32(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600D2CB RID: 53963
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetNumberOfBins_33(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the number of bins to be used per dimension (x,y)
		/// </summary>
		// Token: 0x0600D2CC RID: 53964 RVA: 0x001256A5 File Offset: 0x001238A5
		public void SetNumberOfBins(IntPtr _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetNumberOfBins_33(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2CD RID: 53965
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetRowMask_34(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set an optional mask that can ignore rows of the table
		/// </summary>
		// Token: 0x0600D2CE RID: 53966 RVA: 0x001256B8 File Offset: 0x001238B8
		public virtual void SetRowMask(vtkDataArray arg0)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetRowMask_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D2CF RID: 53967
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarType_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2D0 RID: 53968 RVA: 0x001256E7 File Offset: 0x001238E7
		public virtual void SetScalarType(int _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarType_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2D1 RID: 53969
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToDouble_36(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2D2 RID: 53970 RVA: 0x001256F7 File Offset: 0x001238F7
		public void SetScalarTypeToDouble()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToDouble_36(base.GetCppThis());
		}

		// Token: 0x0600D2D3 RID: 53971
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToFloat_37(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2D4 RID: 53972 RVA: 0x00125706 File Offset: 0x00123906
		public void SetScalarTypeToFloat()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToFloat_37(base.GetCppThis());
		}

		// Token: 0x0600D2D5 RID: 53973
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedChar_38(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2D6 RID: 53974 RVA: 0x00125715 File Offset: 0x00123915
		public void SetScalarTypeToUnsignedChar()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedChar_38(base.GetCppThis());
		}

		// Token: 0x0600D2D7 RID: 53975
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedInt_39(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2D8 RID: 53976 RVA: 0x00125724 File Offset: 0x00123924
		public void SetScalarTypeToUnsignedInt()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedInt_39(base.GetCppThis());
		}

		// Token: 0x0600D2D9 RID: 53977
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedLong_40(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2DA RID: 53978 RVA: 0x00125733 File Offset: 0x00123933
		public void SetScalarTypeToUnsignedLong()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedLong_40(base.GetCppThis());
		}

		// Token: 0x0600D2DB RID: 53979
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetScalarTypeToUnsignedShort_41(HandleRef pThis);

		/// <summary>
		/// Control the scalar type of the output histogram.  If the input
		/// is relatively small, you can save space by using a smaller
		/// data type.  Defaults to unsigned integer.
		/// </summary>
		// Token: 0x0600D2DC RID: 53980 RVA: 0x00125742 File Offset: 0x00123942
		public void SetScalarTypeToUnsignedShort()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetScalarTypeToUnsignedShort_41(base.GetCppThis());
		}

		// Token: 0x0600D2DD RID: 53981
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetSwapColumns_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Get the histogram extents currently in use, either computed
		/// or set by the user.
		/// </summary>
		// Token: 0x0600D2DE RID: 53982 RVA: 0x00125751 File Offset: 0x00123951
		public virtual void SetSwapColumns(int _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetSwapColumns_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2DF RID: 53983
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SetUseCustomHistogramExtents_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Use the extents in CustomHistogramExtents when computing the
		/// histogram, rather than the simple range of the input columns.
		/// </summary>
		// Token: 0x0600D2E0 RID: 53984 RVA: 0x00125761 File Offset: 0x00123961
		public virtual void SetUseCustomHistogramExtents(int _arg)
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SetUseCustomHistogramExtents_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D2E1 RID: 53985
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SwapColumnsOff_44(HandleRef pThis);

		/// <summary>
		/// Get the histogram extents currently in use, either computed
		/// or set by the user.
		/// </summary>
		// Token: 0x0600D2E2 RID: 53986 RVA: 0x00125771 File Offset: 0x00123971
		public virtual void SwapColumnsOff()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SwapColumnsOff_44(base.GetCppThis());
		}

		// Token: 0x0600D2E3 RID: 53987
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_SwapColumnsOn_45(HandleRef pThis);

		/// <summary>
		/// Get the histogram extents currently in use, either computed
		/// or set by the user.
		/// </summary>
		// Token: 0x0600D2E4 RID: 53988 RVA: 0x00125780 File Offset: 0x00123980
		public virtual void SwapColumnsOn()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_SwapColumnsOn_45(base.GetCppThis());
		}

		// Token: 0x0600D2E5 RID: 53989
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_UseCustomHistogramExtentsOff_46(HandleRef pThis);

		/// <summary>
		/// Use the extents in CustomHistogramExtents when computing the
		/// histogram, rather than the simple range of the input columns.
		/// </summary>
		// Token: 0x0600D2E6 RID: 53990 RVA: 0x0012578F File Offset: 0x0012398F
		public virtual void UseCustomHistogramExtentsOff()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_UseCustomHistogramExtentsOff_46(base.GetCppThis());
		}

		// Token: 0x0600D2E7 RID: 53991
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHistogram2D_UseCustomHistogramExtentsOn_47(HandleRef pThis);

		/// <summary>
		/// Use the extents in CustomHistogramExtents when computing the
		/// histogram, rather than the simple range of the input columns.
		/// </summary>
		// Token: 0x0600D2E8 RID: 53992 RVA: 0x0012579E File Offset: 0x0012399E
		public virtual void UseCustomHistogramExtentsOn()
		{
			vtkExtractHistogram2D.vtkExtractHistogram2D_UseCustomHistogramExtentsOn_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F92 RID: 3986
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHistogram2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F93 RID: 3987
		public new static readonly string MRClassNameKey = "class vtkExtractHistogram2D";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000476 RID: 1142
		public new enum OutputIndices
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F95 RID: 3989
			HISTOGRAM_IMAGE = 3
		}
	}
}
