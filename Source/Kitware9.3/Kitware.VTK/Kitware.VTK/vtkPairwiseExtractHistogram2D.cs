using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPairwiseExtractHistogram2D
	/// </summary>
	/// <remarks>
	///    compute a 2D histogram between
	///  all adjacent columns of an input vtkTable.
	///
	///
	///  This class computes a 2D histogram between all adjacent pairs of columns
	///  of an input vtkTable. Internally it creates multiple vtkExtractHistogram2D
	///  instances (one for each pair of adjacent table columns).  It also
	///  manages updating histogram computations intelligently, only recomputing
	///  those histograms for whom a relevant property has been altered.
	///
	///  Note that there are two different outputs from this filter.  One is a
	///  table for which each column contains a flattened 2D histogram array.
	///  The other is a vtkMultiBlockDataSet for which each block is a
	///  vtkImageData representation of the 2D histogram.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkExtractHistogram2D vtkPPairwiseExtractHistogram2D
	///
	/// @par Thanks:
	///  Developed by David Feng and Philippe Pebay at Sandia National Laboratories
	///             ------------------------------------------------------------------------------
	/// </seealso>
	// Token: 0x02000478 RID: 1144
	public class vtkPairwiseExtractHistogram2D : vtkStatisticsAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D2FF RID: 54015 RVA: 0x00125A7B File Offset: 0x00123C7B
		static vtkPairwiseExtractHistogram2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPairwiseExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPairwiseExtractHistogram2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D300 RID: 54016 RVA: 0x00125AA3 File Offset: 0x00123CA3
		public vtkPairwiseExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D301 RID: 54017
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D302 RID: 54018 RVA: 0x00125AB4 File Offset: 0x00123CB4
		public new static vtkPairwiseExtractHistogram2D New()
		{
			vtkPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D303 RID: 54019 RVA: 0x00125B08 File Offset: 0x00123D08
		public vtkPairwiseExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D304 RID: 54020 RVA: 0x00125B4C File Offset: 0x00123D4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D305 RID: 54021
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_Aggregate_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Given a collection of models, calculate aggregate model.  Not used
		/// </summary>
		// Token: 0x0600D306 RID: 54022 RVA: 0x00125B58 File Offset: 0x00123D58
		public override void Aggregate(vtkDataObjectCollection arg0, vtkMultiBlockDataSet arg1)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_Aggregate_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600D307 RID: 54023
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPairwiseExtractHistogram2D_GetBinRange_02(HandleRef pThis, int idx, long binX, long binY, IntPtr range);

		/// <summary>
		/// Compute the range of the bin located at position (binX,binY) in
		/// the 2D histogram at idx.
		/// </summary>
		// Token: 0x0600D308 RID: 54024 RVA: 0x00125B9C File Offset: 0x00123D9C
		public int GetBinRange(int idx, long binX, long binY, IntPtr range)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetBinRange_02(base.GetCppThis(), idx, binX, binY, range);
		}

		// Token: 0x0600D309 RID: 54025
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPairwiseExtractHistogram2D_GetBinRange_03(HandleRef pThis, int idx, long bin, IntPtr range);

		/// <summary>
		/// Get the range of the of the bin located at 1D position index bin
		/// in the 2D histogram array at idx.
		/// </summary>
		// Token: 0x0600D30A RID: 54026 RVA: 0x00125BC0 File Offset: 0x00123DC0
		public int GetBinRange(int idx, long bin, IntPtr range)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetBinRange_03(base.GetCppThis(), idx, bin, range);
		}

		// Token: 0x0600D30B RID: 54027
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_GetBinWidth_04(HandleRef pThis, int idx, IntPtr bw);

		/// <summary>
		/// Get the width of all of the bins. Also stored in the spacing
		/// ivar of the histogram image output at idx.
		/// </summary>
		// Token: 0x0600D30C RID: 54028 RVA: 0x00125BE2 File Offset: 0x00123DE2
		public void GetBinWidth(int idx, IntPtr bw)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetBinWidth_04(base.GetCppThis(), idx, bw);
		}

		// Token: 0x0600D30D RID: 54029
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetHistogramExtents_05(HandleRef pThis, int idx);

		/// <summary>
		/// Get the histogram extents currently in use, either computed
		/// or set by the user for the idx'th histogram.
		/// </summary>
		// Token: 0x0600D30E RID: 54030 RVA: 0x00125BF4 File Offset: 0x00123DF4
		public IntPtr GetHistogramExtents(int idx)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetHistogramExtents_05(base.GetCppThis(), idx);
		}

		// Token: 0x0600D30F RID: 54031
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetHistogramFilter_06(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a pointer to the idx'th histogram filter.
		/// </summary>
		// Token: 0x0600D310 RID: 54032 RVA: 0x00125C14 File Offset: 0x00123E14
		public vtkExtractHistogram2D GetHistogramFilter(int idx)
		{
			vtkExtractHistogram2D vtkExtractHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetHistogramFilter_06(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D311 RID: 54033
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPairwiseExtractHistogram2D_GetMaximumBinCount_07(HandleRef pThis, int idx);

		/// <summary>
		/// Get the maximum bin count for a single histogram
		/// </summary>
		// Token: 0x0600D312 RID: 54034 RVA: 0x00125C84 File Offset: 0x00123E84
		public double GetMaximumBinCount(int idx)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetMaximumBinCount_07(base.GetCppThis(), idx);
		}

		// Token: 0x0600D313 RID: 54035
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPairwiseExtractHistogram2D_GetMaximumBinCount_08(HandleRef pThis);

		/// <summary>
		/// Get the maximum bin count over all histograms
		/// </summary>
		// Token: 0x0600D314 RID: 54036 RVA: 0x00125CA4 File Offset: 0x00123EA4
		public double GetMaximumBinCount()
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetMaximumBinCount_08(base.GetCppThis());
		}

		// Token: 0x0600D315 RID: 54037
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetNumberOfBins_09(HandleRef pThis);

		/// <summary>
		/// Set/get the bin dimensions of the histograms to compute
		/// </summary>
		// Token: 0x0600D316 RID: 54038 RVA: 0x00125CC4 File Offset: 0x00123EC4
		public virtual int[] GetNumberOfBins()
		{
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfBins_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600D317 RID: 54039
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_GetNumberOfBins_10(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Set/get the bin dimensions of the histograms to compute
		/// </summary>
		// Token: 0x0600D318 RID: 54040 RVA: 0x00125D0C File Offset: 0x00123F0C
		public virtual void GetNumberOfBins(ref int _arg1, ref int _arg2)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfBins_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600D319 RID: 54041
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_GetNumberOfBins_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the bin dimensions of the histograms to compute
		/// </summary>
		// Token: 0x0600D31A RID: 54042 RVA: 0x00125D1D File Offset: 0x00123F1D
		public virtual void GetNumberOfBins(IntPtr _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfBins_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D31B RID: 54043
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBase_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D31C RID: 54044 RVA: 0x00125D30 File Offset: 0x00123F30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBase_12(base.GetCppThis(), type);
		}

		// Token: 0x0600D31D RID: 54045
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBaseType_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D31E RID: 54046 RVA: 0x00125D50 File Offset: 0x00123F50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBaseType_13(type);
		}

		// Token: 0x0600D31F RID: 54047
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_GetOutputHistogramImage_14(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkImageData output of the idx'th histogram filter
		/// </summary>
		// Token: 0x0600D320 RID: 54048 RVA: 0x00125D6C File Offset: 0x00123F6C
		public vtkImageData GetOutputHistogramImage(int idx)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetOutputHistogramImage_14(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600D321 RID: 54049
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPairwiseExtractHistogram2D_GetScalarType_15(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for each of the computed histograms.
		/// </summary>
		// Token: 0x0600D322 RID: 54050 RVA: 0x00125DDC File Offset: 0x00123FDC
		public virtual int GetScalarType()
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_GetScalarType_15(base.GetCppThis());
		}

		// Token: 0x0600D323 RID: 54051
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPairwiseExtractHistogram2D_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D324 RID: 54052 RVA: 0x00125DFC File Offset: 0x00123FFC
		public override int IsA(string type)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x0600D325 RID: 54053
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPairwiseExtractHistogram2D_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D326 RID: 54054 RVA: 0x00125E1C File Offset: 0x0012401C
		public new static int IsTypeOf(string type)
		{
			return vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_IsTypeOf_17(type);
		}

		// Token: 0x0600D327 RID: 54055
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D328 RID: 54056 RVA: 0x00125E38 File Offset: 0x00124038
		public new vtkPairwiseExtractHistogram2D NewInstance()
		{
			vtkPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D329 RID: 54057
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPairwiseExtractHistogram2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D32A RID: 54058 RVA: 0x00125E94 File Offset: 0x00124094
		public new static vtkPairwiseExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPairwiseExtractHistogram2D vtkPairwiseExtractHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPairwiseExtractHistogram2D = (vtkPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPairwiseExtractHistogram2D.Register(null);
				}
			}
			return vtkPairwiseExtractHistogram2D;
		}

		// Token: 0x0600D32B RID: 54059
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRange_21(HandleRef pThis, int col, IntPtr range);

		/// <summary>
		/// More standard way to set the custom range for a particular column.
		/// This makes sure that only the affected histograms know that they
		/// need to be updated.
		/// </summary>
		// Token: 0x0600D32C RID: 54060 RVA: 0x00125F13 File Offset: 0x00124113
		public void SetCustomColumnRange(int col, IntPtr range)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRange_21(base.GetCppThis(), col, range);
		}

		// Token: 0x0600D32D RID: 54061
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRange_22(HandleRef pThis, int col, double rmin, double rmax);

		/// <summary>
		/// More standard way to set the custom range for a particular column.
		/// This makes sure that only the affected histograms know that they
		/// need to be updated.
		/// </summary>
		// Token: 0x0600D32E RID: 54062 RVA: 0x00125F24 File Offset: 0x00124124
		public void SetCustomColumnRange(int col, double rmin, double rmax)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRange_22(base.GetCppThis(), col, rmin, rmax);
		}

		// Token: 0x0600D32F RID: 54063
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRangeByIndex_23(HandleRef pThis, double arg0, double arg1);

		/// <summary>
		/// Strange method for setting an index to be used for setting custom
		/// column range. This was (probably) necessary to get this class
		/// to interact with the ParaView client/server message passing interface.
		/// </summary>
		// Token: 0x0600D330 RID: 54064 RVA: 0x00125F36 File Offset: 0x00124136
		public void SetCustomColumnRangeByIndex(double arg0, double arg1)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRangeByIndex_23(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0600D331 RID: 54065
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetCustomColumnRangeIndex_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Strange method for setting an index to be used for setting custom
		/// column range. This was (probably) necessary to get this class
		/// to interact with the ParaView client/server message passing interface.
		/// </summary>
		// Token: 0x0600D332 RID: 54066 RVA: 0x00125F47 File Offset: 0x00124147
		public virtual void SetCustomColumnRangeIndex(int _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetCustomColumnRangeIndex_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D333 RID: 54067
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetNumberOfBins_25(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/get the bin dimensions of the histograms to compute
		/// </summary>
		// Token: 0x0600D334 RID: 54068 RVA: 0x00125F57 File Offset: 0x00124157
		public virtual void SetNumberOfBins(int _arg1, int _arg2)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetNumberOfBins_25(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600D335 RID: 54069
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetNumberOfBins_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the bin dimensions of the histograms to compute
		/// </summary>
		// Token: 0x0600D336 RID: 54070 RVA: 0x00125F68 File Offset: 0x00124168
		public void SetNumberOfBins(IntPtr _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetNumberOfBins_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D337 RID: 54071
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarType_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the scalar type for each of the computed histograms.
		/// </summary>
		// Token: 0x0600D338 RID: 54072 RVA: 0x00125F78 File Offset: 0x00124178
		public virtual void SetScalarType(int _arg)
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarType_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D339 RID: 54073
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedChar_28(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for each of the computed histograms.
		/// </summary>
		// Token: 0x0600D33A RID: 54074 RVA: 0x00125F88 File Offset: 0x00124188
		public void SetScalarTypeToUnsignedChar()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedChar_28(base.GetCppThis());
		}

		// Token: 0x0600D33B RID: 54075
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedInt_29(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for each of the computed histograms.
		/// </summary>
		// Token: 0x0600D33C RID: 54076 RVA: 0x00125F97 File Offset: 0x00124197
		public void SetScalarTypeToUnsignedInt()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedInt_29(base.GetCppThis());
		}

		// Token: 0x0600D33D RID: 54077
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedLong_30(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for each of the computed histograms.
		/// </summary>
		// Token: 0x0600D33E RID: 54078 RVA: 0x00125FA6 File Offset: 0x001241A6
		public void SetScalarTypeToUnsignedLong()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedLong_30(base.GetCppThis());
		}

		// Token: 0x0600D33F RID: 54079
		[DllImport("Kitware.VTK.FiltersImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedShort_31(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for each of the computed histograms.
		/// </summary>
		// Token: 0x0600D340 RID: 54080 RVA: 0x00125FB5 File Offset: 0x001241B5
		public void SetScalarTypeToUnsignedShort()
		{
			vtkPairwiseExtractHistogram2D.vtkPairwiseExtractHistogram2D_SetScalarTypeToUnsignedShort_31(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F98 RID: 3992
		public new const string MRFullTypeName = "Kitware.VTK.vtkPairwiseExtractHistogram2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F99 RID: 3993
		public new static readonly string MRClassNameKey = "class vtkPairwiseExtractHistogram2D";

		/// <summary>
		/// Get a pointer to the idx'th histogram filter.
		/// </summary>
		// Token: 0x02000479 RID: 1145
		public new enum OutputIndices
		{
			/// <summary>enum member</summary>
			// Token: 0x04000F9B RID: 3995
			HISTOGRAM_IMAGE = 3
		}
	}
}
