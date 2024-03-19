using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitModeller
	/// </summary>
	/// <remarks>
	///    compute distance from input geometry on structured point dataset
	///
	/// vtkImplicitModeller is a filter that computes the distance from the input
	/// geometry to the points of an output structured point set. This distance
	/// function can then be "contoured" to generate new, offset surfaces from
	/// the original geometry. An important feature of this object is
	/// "capping". If capping is turned on, after the implicit model is created,
	/// the values on the boundary of the structured points dataset are set to
	/// the cap value. This is used to force closure of the resulting contoured
	/// surface. Note, however, that large cap values can generate weird surface
	/// normals in those cells adjacent to the boundary of the dataset. Using
	/// smaller cap value will reduce this effect.
	/// &lt;P&gt;
	/// Another important ivar is MaximumDistance. This controls how far into the
	/// volume the distance function is computed from the input geometry.  Small
	/// values give significant increases in performance. However, there can
	/// strange sampling effects at the extreme range of the MaximumDistance.
	/// &lt;P&gt;
	/// In order to properly execute and sample the input data, a rectangular
	/// region in space must be defined (this is the ivar ModelBounds).  If not
	/// explicitly defined, the model bounds will be computed. Note that to avoid
	/// boundary effects, it is possible to adjust the model bounds (i.e., using
	/// the AdjustBounds and AdjustDistance ivars) to strictly contain the
	/// sampled data.
	/// &lt;P&gt;
	/// This filter has one other unusual capability: it is possible to append
	/// data in a sequence of operations to generate a single output. This is
	/// useful when you have multiple datasets and want to create a
	/// conglomeration of all the data.  However, the user must be careful to
	/// either specify the ModelBounds or specify the first item such that its
	/// bounds completely contain all other items.  This is because the
	/// rectangular region of the output can not be changed after the 1st Append.
	/// &lt;P&gt;
	/// The ProcessMode ivar controls the method used within the Append function
	/// (where the actual work is done regardless if the Append function is
	/// explicitly called) to compute the implicit model.  If set to work in voxel
	/// mode, each voxel is visited once.  If set to cell mode, each cell is visited
	/// once.  Tests have shown once per voxel to be faster when there are a
	/// lot of cells (at least a thousand?); relative performance improvement
	/// increases with addition cells. Primitives should not be stripped for best
	/// performance of the voxel mode.  Also, if explicitly using the Append feature
	/// many times, the cell mode will probably be better because each voxel will be
	/// visited each Append.  Append the data before input if possible when using
	/// the voxel mode.  Do not switch between voxel and cell mode between execution
	/// of StartAppend and EndAppend.
	/// &lt;P&gt;
	/// Further performance improvement is now possible using the PerVoxel process
	/// mode on multi-processor machines (the mode is now multithreaded).  Each
	/// thread processes a different "slab" of the output.  Also, if the input is
	/// vtkPolyData, it is appropriately clipped for each thread; that is, each
	/// thread only considers the input which could affect its slab of the output.
	/// &lt;P&gt;
	/// This filter can now produce output of any type supported by vtkImageData.
	/// However to support this change, additional sqrts must be executed during the
	/// Append step.  Previously, the output was initialized to the squared CapValue
	/// in StartAppend, the output was updated with squared distance values during
	/// the Append, and then the sqrt of the distances was computed in EndAppend.
	/// To support different scalar types in the output (largely to reduce memory
	/// requirements as an vtkImageShiftScale and/or vtkImageCast could have
	/// achieved the same result), we can't "afford" to save squared value in the
	/// output, because then we could only represent up to the sqrt of the scalar
	/// max for an integer type in the output; 1 (instead of 255) for an unsigned
	/// char; 11 for a char (instead of 127).  Thus this change may result in a
	/// minor performance degradation.  Non-float output types can be scaled to the
	/// CapValue by turning ScaleToMaximumDistance On.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSampleFunction vtkContourFilter
	/// </seealso>
	// Token: 0x0200060F RID: 1551
	public class vtkImplicitModeller : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010D8A RID: 69002 RVA: 0x00177C82 File Offset: 0x00175E82
		static vtkImplicitModeller()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitModeller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitModeller"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010D8B RID: 69003 RVA: 0x00177CAA File Offset: 0x00175EAA
		public vtkImplicitModeller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010D8C RID: 69004
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitModeller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with sample dimensions=(50,50,50), and so that model bounds are
		/// automatically computed from the input. Capping is turned on with CapValue
		/// equal to a large positive number.
		/// </summary>
		// Token: 0x06010D8D RID: 69005 RVA: 0x00177CB8 File Offset: 0x00175EB8
		public new static vtkImplicitModeller New()
		{
			vtkImplicitModeller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with sample dimensions=(50,50,50), and so that model bounds are
		/// automatically computed from the input. Capping is turned on with CapValue
		/// equal to a large positive number.
		/// </summary>
		// Token: 0x06010D8E RID: 69006 RVA: 0x00177D0C File Offset: 0x00175F0C
		public vtkImplicitModeller() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitModeller.vtkImplicitModeller_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010D8F RID: 69007 RVA: 0x00177D50 File Offset: 0x00175F50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010D90 RID: 69008
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_AdjustBoundsOff_01(HandleRef pThis);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x06010D91 RID: 69009 RVA: 0x00177D5B File Offset: 0x00175F5B
		public virtual void AdjustBoundsOff()
		{
			vtkImplicitModeller.vtkImplicitModeller_AdjustBoundsOff_01(base.GetCppThis());
		}

		// Token: 0x06010D92 RID: 69010
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_AdjustBoundsOn_02(HandleRef pThis);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x06010D93 RID: 69011 RVA: 0x00177D6A File Offset: 0x00175F6A
		public virtual void AdjustBoundsOn()
		{
			vtkImplicitModeller.vtkImplicitModeller_AdjustBoundsOn_02(base.GetCppThis());
		}

		// Token: 0x06010D94 RID: 69012
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_Append_03(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Append a data set to the existing output. To use this function,
		/// you'll have to invoke the StartAppend() method before doing
		/// successive appends. It's also a good idea to specify the model
		/// bounds; otherwise the input model bounds is used. When you've
		/// finished appending, use the EndAppend() method.
		/// </summary>
		// Token: 0x06010D95 RID: 69013 RVA: 0x00177D7C File Offset: 0x00175F7C
		public void Append(vtkDataSet input)
		{
			vtkImplicitModeller.vtkImplicitModeller_Append_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06010D96 RID: 69014
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_CappingOff_04(HandleRef pThis);

		/// <summary>
		/// The outer boundary of the structured point set can be assigned a
		/// particular value. This can be used to close or "cap" all surfaces.
		/// </summary>
		// Token: 0x06010D97 RID: 69015 RVA: 0x00177DAB File Offset: 0x00175FAB
		public virtual void CappingOff()
		{
			vtkImplicitModeller.vtkImplicitModeller_CappingOff_04(base.GetCppThis());
		}

		// Token: 0x06010D98 RID: 69016
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_CappingOn_05(HandleRef pThis);

		/// <summary>
		/// The outer boundary of the structured point set can be assigned a
		/// particular value. This can be used to close or "cap" all surfaces.
		/// </summary>
		// Token: 0x06010D99 RID: 69017 RVA: 0x00177DBA File Offset: 0x00175FBA
		public virtual void CappingOn()
		{
			vtkImplicitModeller.vtkImplicitModeller_CappingOn_05(base.GetCppThis());
		}

		// Token: 0x06010D9A RID: 69018
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_ComputeModelBounds_06(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Compute ModelBounds from input geometry. If input is not specified, the
		/// input of the filter will be used.
		/// </summary>
		// Token: 0x06010D9B RID: 69019 RVA: 0x00177DCC File Offset: 0x00175FCC
		public double ComputeModelBounds(vtkDataSet input)
		{
			return vtkImplicitModeller.vtkImplicitModeller_ComputeModelBounds_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06010D9C RID: 69020
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_EndAppend_07(HandleRef pThis);

		/// <summary>
		/// Method completes the append process.
		/// </summary>
		// Token: 0x06010D9D RID: 69021 RVA: 0x00177E00 File Offset: 0x00176000
		public void EndAppend()
		{
			vtkImplicitModeller.vtkImplicitModeller_EndAppend_07(base.GetCppThis());
		}

		// Token: 0x06010D9E RID: 69022
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetAdjustBounds_08(HandleRef pThis);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x06010D9F RID: 69023 RVA: 0x00177E10 File Offset: 0x00176010
		public virtual int GetAdjustBounds()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustBounds_08(base.GetCppThis());
		}

		// Token: 0x06010DA0 RID: 69024
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetAdjustDistance_09(HandleRef pThis);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x06010DA1 RID: 69025 RVA: 0x00177E30 File Offset: 0x00176030
		public virtual double GetAdjustDistance()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustDistance_09(base.GetCppThis());
		}

		// Token: 0x06010DA2 RID: 69026
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetAdjustDistanceMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x06010DA3 RID: 69027 RVA: 0x00177E50 File Offset: 0x00176050
		public virtual double GetAdjustDistanceMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustDistanceMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06010DA4 RID: 69028
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetAdjustDistanceMinValue_11(HandleRef pThis);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x06010DA5 RID: 69029 RVA: 0x00177E70 File Offset: 0x00176070
		public virtual double GetAdjustDistanceMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustDistanceMinValue_11(base.GetCppThis());
		}

		// Token: 0x06010DA6 RID: 69030
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetCapValue_12(HandleRef pThis);

		/// <summary>
		/// Specify the capping value to use. The CapValue is also used as an
		/// initial distance value at each point in the dataset.
		/// </summary>
		// Token: 0x06010DA7 RID: 69031 RVA: 0x00177E90 File Offset: 0x00176090
		public virtual double GetCapValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetCapValue_12(base.GetCppThis());
		}

		// Token: 0x06010DA8 RID: 69032
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetCapping_13(HandleRef pThis);

		/// <summary>
		/// The outer boundary of the structured point set can be assigned a
		/// particular value. This can be used to close or "cap" all surfaces.
		/// </summary>
		// Token: 0x06010DA9 RID: 69033 RVA: 0x00177EB0 File Offset: 0x001760B0
		public virtual int GetCapping()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetCapping_13(base.GetCppThis());
		}

		// Token: 0x06010DAA RID: 69034
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetLocatorMaxLevel_14(HandleRef pThis);

		/// <summary>
		/// Specify the level of the locator to use when using the per voxel
		/// process mode.
		/// </summary>
		// Token: 0x06010DAB RID: 69035 RVA: 0x00177ED0 File Offset: 0x001760D0
		public virtual int GetLocatorMaxLevel()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetLocatorMaxLevel_14(base.GetCppThis());
		}

		// Token: 0x06010DAC RID: 69036
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetMaximumDistance_15(HandleRef pThis);

		/// <summary>
		/// Set / get the distance away from surface of input geometry to
		/// sample. This value is specified as a percentage of the length of
		/// the diagonal of the input data bounding box.
		/// Smaller values make large increases in performance.
		/// </summary>
		// Token: 0x06010DAD RID: 69037 RVA: 0x00177EF0 File Offset: 0x001760F0
		public virtual double GetMaximumDistance()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetMaximumDistance_15(base.GetCppThis());
		}

		// Token: 0x06010DAE RID: 69038
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetMaximumDistanceMaxValue_16(HandleRef pThis);

		/// <summary>
		/// Set / get the distance away from surface of input geometry to
		/// sample. This value is specified as a percentage of the length of
		/// the diagonal of the input data bounding box.
		/// Smaller values make large increases in performance.
		/// </summary>
		// Token: 0x06010DAF RID: 69039 RVA: 0x00177F10 File Offset: 0x00176110
		public virtual double GetMaximumDistanceMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetMaximumDistanceMaxValue_16(base.GetCppThis());
		}

		// Token: 0x06010DB0 RID: 69040
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitModeller_GetMaximumDistanceMinValue_17(HandleRef pThis);

		/// <summary>
		/// Set / get the distance away from surface of input geometry to
		/// sample. This value is specified as a percentage of the length of
		/// the diagonal of the input data bounding box.
		/// Smaller values make large increases in performance.
		/// </summary>
		// Token: 0x06010DB1 RID: 69041 RVA: 0x00177F30 File Offset: 0x00176130
		public virtual double GetMaximumDistanceMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetMaximumDistanceMinValue_17(base.GetCppThis());
		}

		// Token: 0x06010DB2 RID: 69042
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitModeller_GetModelBounds_18(HandleRef pThis);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x06010DB3 RID: 69043 RVA: 0x00177F50 File Offset: 0x00176150
		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_GetModelBounds_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010DB4 RID: 69044
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_GetModelBounds_19(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x06010DB5 RID: 69045 RVA: 0x00177F98 File Offset: 0x00176198
		public virtual void GetModelBounds(IntPtr data)
		{
			vtkImplicitModeller.vtkImplicitModeller_GetModelBounds_19(base.GetCppThis(), data);
		}

		// Token: 0x06010DB6 RID: 69046
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitModeller_GetNumberOfGenerationsFromBase_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010DB7 RID: 69047 RVA: 0x00177FA8 File Offset: 0x001761A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfGenerationsFromBase_20(base.GetCppThis(), type);
		}

		// Token: 0x06010DB8 RID: 69048
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitModeller_GetNumberOfGenerationsFromBaseType_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010DB9 RID: 69049 RVA: 0x00177FC8 File Offset: 0x001761C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfGenerationsFromBaseType_21(type);
		}

		// Token: 0x06010DBA RID: 69050
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetNumberOfThreads_22(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of threads used during Per-Voxel processing mode
		/// </summary>
		// Token: 0x06010DBB RID: 69051 RVA: 0x00177FE4 File Offset: 0x001761E4
		public virtual int GetNumberOfThreads()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfThreads_22(base.GetCppThis());
		}

		// Token: 0x06010DBC RID: 69052
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetNumberOfThreadsMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of threads used during Per-Voxel processing mode
		/// </summary>
		// Token: 0x06010DBD RID: 69053 RVA: 0x00178004 File Offset: 0x00176204
		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfThreadsMaxValue_23(base.GetCppThis());
		}

		// Token: 0x06010DBE RID: 69054
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetNumberOfThreadsMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set / Get the number of threads used during Per-Voxel processing mode
		/// </summary>
		// Token: 0x06010DBF RID: 69055 RVA: 0x00178024 File Offset: 0x00176224
		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfThreadsMinValue_24(base.GetCppThis());
		}

		// Token: 0x06010DC0 RID: 69056
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetOutputScalarType_25(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DC1 RID: 69057 RVA: 0x00178044 File Offset: 0x00176244
		public virtual int GetOutputScalarType()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetOutputScalarType_25(base.GetCppThis());
		}

		// Token: 0x06010DC2 RID: 69058
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetProcessMode_26(HandleRef pThis);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010DC3 RID: 69059 RVA: 0x00178064 File Offset: 0x00176264
		public virtual int GetProcessMode()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetProcessMode_26(base.GetCppThis());
		}

		// Token: 0x06010DC4 RID: 69060
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitModeller_GetProcessModeAsString_27(HandleRef pThis);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010DC5 RID: 69061 RVA: 0x00178084 File Offset: 0x00176284
		public string GetProcessModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImplicitModeller.vtkImplicitModeller_GetProcessModeAsString_27(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010DC6 RID: 69062
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetProcessModeMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010DC7 RID: 69063 RVA: 0x001780C0 File Offset: 0x001762C0
		public virtual int GetProcessModeMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetProcessModeMaxValue_28(base.GetCppThis());
		}

		// Token: 0x06010DC8 RID: 69064
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetProcessModeMinValue_29(HandleRef pThis);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010DC9 RID: 69065 RVA: 0x001780E0 File Offset: 0x001762E0
		public virtual int GetProcessModeMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetProcessModeMinValue_29(base.GetCppThis());
		}

		// Token: 0x06010DCA RID: 69066
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitModeller_GetSampleDimensions_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to sample distance function.
		/// </summary>
		// Token: 0x06010DCB RID: 69067 RVA: 0x00178100 File Offset: 0x00176300
		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_GetSampleDimensions_30(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06010DCC RID: 69068
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_GetSampleDimensions_31(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to sample distance function.
		/// </summary>
		// Token: 0x06010DCD RID: 69069 RVA: 0x00178148 File Offset: 0x00176348
		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkImplicitModeller.vtkImplicitModeller_GetSampleDimensions_31(base.GetCppThis(), data);
		}

		// Token: 0x06010DCE RID: 69070
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_GetScaleToMaximumDistance_32(HandleRef pThis);

		/// <summary>
		/// If a non-floating output type is specified, the output distances can be
		/// scaled to use the entire positive scalar range of the output type
		/// specified (up to the CapValue which is equal to the max for the type
		/// unless modified by the user).  For example, if ScaleToMaximumDistance
		/// is On and the OutputScalarType is UnsignedChar the distances saved in the
		/// output would be linearly scaled between 0 (for distances "very close" to
		/// the surface) and 255 (at the specified maximum distance)... assuming the
		/// CapValue is not changed from 255.
		/// </summary>
		// Token: 0x06010DCF RID: 69071 RVA: 0x00178158 File Offset: 0x00176358
		public virtual int GetScaleToMaximumDistance()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetScaleToMaximumDistance_32(base.GetCppThis());
		}

		// Token: 0x06010DD0 RID: 69072
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010DD1 RID: 69073 RVA: 0x00178178 File Offset: 0x00176378
		public override int IsA(string type)
		{
			return vtkImplicitModeller.vtkImplicitModeller_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x06010DD2 RID: 69074
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitModeller_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010DD3 RID: 69075 RVA: 0x00178198 File Offset: 0x00176398
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitModeller.vtkImplicitModeller_IsTypeOf_34(type);
		}

		// Token: 0x06010DD4 RID: 69076
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitModeller_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010DD5 RID: 69077 RVA: 0x001781B4 File Offset: 0x001763B4
		public new vtkImplicitModeller NewInstance()
		{
			vtkImplicitModeller result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_NewInstance_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010DD6 RID: 69078
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitModeller_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010DD7 RID: 69079 RVA: 0x00178210 File Offset: 0x00176410
		public new static vtkImplicitModeller SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitModeller vtkImplicitModeller = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_SafeDownCast_37((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitModeller = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitModeller.Register(null);
				}
			}
			return vtkImplicitModeller;
		}

		// Token: 0x06010DD8 RID: 69080
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_ScaleToMaximumDistanceOff_38(HandleRef pThis);

		/// <summary>
		/// If a non-floating output type is specified, the output distances can be
		/// scaled to use the entire positive scalar range of the output type
		/// specified (up to the CapValue which is equal to the max for the type
		/// unless modified by the user).  For example, if ScaleToMaximumDistance
		/// is On and the OutputScalarType is UnsignedChar the distances saved in the
		/// output would be linearly scaled between 0 (for distances "very close" to
		/// the surface) and 255 (at the specified maximum distance)... assuming the
		/// CapValue is not changed from 255.
		/// </summary>
		// Token: 0x06010DD9 RID: 69081 RVA: 0x0017828F File Offset: 0x0017648F
		public virtual void ScaleToMaximumDistanceOff()
		{
			vtkImplicitModeller.vtkImplicitModeller_ScaleToMaximumDistanceOff_38(base.GetCppThis());
		}

		// Token: 0x06010DDA RID: 69082
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_ScaleToMaximumDistanceOn_39(HandleRef pThis);

		/// <summary>
		/// If a non-floating output type is specified, the output distances can be
		/// scaled to use the entire positive scalar range of the output type
		/// specified (up to the CapValue which is equal to the max for the type
		/// unless modified by the user).  For example, if ScaleToMaximumDistance
		/// is On and the OutputScalarType is UnsignedChar the distances saved in the
		/// output would be linearly scaled between 0 (for distances "very close" to
		/// the surface) and 255 (at the specified maximum distance)... assuming the
		/// CapValue is not changed from 255.
		/// </summary>
		// Token: 0x06010DDB RID: 69083 RVA: 0x0017829E File Offset: 0x0017649E
		public virtual void ScaleToMaximumDistanceOn()
		{
			vtkImplicitModeller.vtkImplicitModeller_ScaleToMaximumDistanceOn_39(base.GetCppThis());
		}

		// Token: 0x06010DDC RID: 69084
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetAdjustBounds_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the model bounds are computed. If the ivar AdjustBounds
		/// is set, then the bounds specified (or computed automatically) is modified
		/// by the fraction given by AdjustDistance. This means that the model
		/// bounds is expanded in each of the x-y-z directions.
		/// </summary>
		// Token: 0x06010DDD RID: 69085 RVA: 0x001782AD File Offset: 0x001764AD
		public virtual void SetAdjustBounds(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetAdjustBounds_40(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DDE RID: 69086
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetAdjustDistance_41(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the amount to grow the model bounds (if the ivar AdjustBounds
		/// is set). The value is a fraction of the maximum length of the sides
		/// of the box specified by the model bounds.
		/// </summary>
		// Token: 0x06010DDF RID: 69087 RVA: 0x001782BD File Offset: 0x001764BD
		public virtual void SetAdjustDistance(double _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetAdjustDistance_41(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DE0 RID: 69088
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetCapValue_42(HandleRef pThis, double value);

		/// <summary>
		/// Specify the capping value to use. The CapValue is also used as an
		/// initial distance value at each point in the dataset.
		/// </summary>
		// Token: 0x06010DE1 RID: 69089 RVA: 0x001782CD File Offset: 0x001764CD
		public void SetCapValue(double value)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetCapValue_42(base.GetCppThis(), value);
		}

		// Token: 0x06010DE2 RID: 69090
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetCapping_43(HandleRef pThis, int _arg);

		/// <summary>
		/// The outer boundary of the structured point set can be assigned a
		/// particular value. This can be used to close or "cap" all surfaces.
		/// </summary>
		// Token: 0x06010DE3 RID: 69091 RVA: 0x001782DD File Offset: 0x001764DD
		public virtual void SetCapping(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetCapping_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DE4 RID: 69092
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetLocatorMaxLevel_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the level of the locator to use when using the per voxel
		/// process mode.
		/// </summary>
		// Token: 0x06010DE5 RID: 69093 RVA: 0x001782ED File Offset: 0x001764ED
		public virtual void SetLocatorMaxLevel(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetLocatorMaxLevel_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DE6 RID: 69094
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetMaximumDistance_45(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the distance away from surface of input geometry to
		/// sample. This value is specified as a percentage of the length of
		/// the diagonal of the input data bounding box.
		/// Smaller values make large increases in performance.
		/// </summary>
		// Token: 0x06010DE7 RID: 69095 RVA: 0x001782FD File Offset: 0x001764FD
		public virtual void SetMaximumDistance(double _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetMaximumDistance_45(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DE8 RID: 69096
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetModelBounds_46(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x06010DE9 RID: 69097 RVA: 0x0017830D File Offset: 0x0017650D
		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetModelBounds_46(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06010DEA RID: 69098
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetModelBounds_47(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the region in space in which to perform the sampling. If
		/// not specified, it will be computed automatically.
		/// </summary>
		// Token: 0x06010DEB RID: 69099 RVA: 0x00178325 File Offset: 0x00176525
		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetModelBounds_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DEC RID: 69100
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetNumberOfThreads_48(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the number of threads used during Per-Voxel processing mode
		/// </summary>
		// Token: 0x06010DED RID: 69101 RVA: 0x00178335 File Offset: 0x00176535
		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetNumberOfThreads_48(base.GetCppThis(), _arg);
		}

		// Token: 0x06010DEE RID: 69102
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarType_49(HandleRef pThis, int type);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DEF RID: 69103 RVA: 0x00178345 File Offset: 0x00176545
		public void SetOutputScalarType(int type)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarType_49(base.GetCppThis(), type);
		}

		// Token: 0x06010DF0 RID: 69104
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToChar_50(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DF1 RID: 69105 RVA: 0x00178355 File Offset: 0x00176555
		public void SetOutputScalarTypeToChar()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToChar_50(base.GetCppThis());
		}

		// Token: 0x06010DF2 RID: 69106
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToDouble_51(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DF3 RID: 69107 RVA: 0x00178364 File Offset: 0x00176564
		public void SetOutputScalarTypeToDouble()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToDouble_51(base.GetCppThis());
		}

		// Token: 0x06010DF4 RID: 69108
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToFloat_52(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DF5 RID: 69109 RVA: 0x00178373 File Offset: 0x00176573
		public void SetOutputScalarTypeToFloat()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToFloat_52(base.GetCppThis());
		}

		// Token: 0x06010DF6 RID: 69110
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToInt_53(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DF7 RID: 69111 RVA: 0x00178382 File Offset: 0x00176582
		public void SetOutputScalarTypeToInt()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToInt_53(base.GetCppThis());
		}

		// Token: 0x06010DF8 RID: 69112
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToLong_54(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DF9 RID: 69113 RVA: 0x00178391 File Offset: 0x00176591
		public void SetOutputScalarTypeToLong()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToLong_54(base.GetCppThis());
		}

		// Token: 0x06010DFA RID: 69114
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToShort_55(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DFB RID: 69115 RVA: 0x001783A0 File Offset: 0x001765A0
		public void SetOutputScalarTypeToShort()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToShort_55(base.GetCppThis());
		}

		// Token: 0x06010DFC RID: 69116
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedChar_56(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DFD RID: 69117 RVA: 0x001783AF File Offset: 0x001765AF
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedChar_56(base.GetCppThis());
		}

		// Token: 0x06010DFE RID: 69118
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedInt_57(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010DFF RID: 69119 RVA: 0x001783BE File Offset: 0x001765BE
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedInt_57(base.GetCppThis());
		}

		// Token: 0x06010E00 RID: 69120
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedLong_58(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010E01 RID: 69121 RVA: 0x001783CD File Offset: 0x001765CD
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedLong_58(base.GetCppThis());
		}

		// Token: 0x06010E02 RID: 69122
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedShort_59(HandleRef pThis);

		/// <summary>
		/// Set the desired output scalar type.
		/// </summary>
		// Token: 0x06010E03 RID: 69123 RVA: 0x001783DC File Offset: 0x001765DC
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedShort_59(base.GetCppThis());
		}

		// Token: 0x06010E04 RID: 69124
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetProcessMode_60(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010E05 RID: 69125 RVA: 0x001783EB File Offset: 0x001765EB
		public virtual void SetProcessMode(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetProcessMode_60(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E06 RID: 69126
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetProcessModeToPerCell_61(HandleRef pThis);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010E07 RID: 69127 RVA: 0x001783FB File Offset: 0x001765FB
		public void SetProcessModeToPerCell()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetProcessModeToPerCell_61(base.GetCppThis());
		}

		// Token: 0x06010E08 RID: 69128
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetProcessModeToPerVoxel_62(HandleRef pThis);

		/// <summary>
		/// Specify whether to visit each cell once per append or each voxel once
		/// per append.  Some tests have shown once per voxel to be faster
		/// when there are a lot of cells (at least a thousand?); relative
		/// performance improvement increases with addition cells.  Primitives
		/// should not be stripped for best performance of the voxel mode.
		/// </summary>
		// Token: 0x06010E09 RID: 69129 RVA: 0x0017840A File Offset: 0x0017660A
		public void SetProcessModeToPerVoxel()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetProcessModeToPerVoxel_62(base.GetCppThis());
		}

		// Token: 0x06010E0A RID: 69130
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetSampleDimensions_63(HandleRef pThis, int i, int j, int k);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to sample distance function.
		/// </summary>
		// Token: 0x06010E0B RID: 69131 RVA: 0x00178419 File Offset: 0x00176619
		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetSampleDimensions_63(base.GetCppThis(), i, j, k);
		}

		// Token: 0x06010E0C RID: 69132
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetSampleDimensions_64(HandleRef pThis, IntPtr dim);

		/// <summary>
		/// Set/Get the i-j-k dimensions on which to sample distance function.
		/// </summary>
		// Token: 0x06010E0D RID: 69133 RVA: 0x0017842B File Offset: 0x0017662B
		public void SetSampleDimensions(IntPtr dim)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetSampleDimensions_64(base.GetCppThis(), dim);
		}

		// Token: 0x06010E0E RID: 69134
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_SetScaleToMaximumDistance_65(HandleRef pThis, int _arg);

		/// <summary>
		/// If a non-floating output type is specified, the output distances can be
		/// scaled to use the entire positive scalar range of the output type
		/// specified (up to the CapValue which is equal to the max for the type
		/// unless modified by the user).  For example, if ScaleToMaximumDistance
		/// is On and the OutputScalarType is UnsignedChar the distances saved in the
		/// output would be linearly scaled between 0 (for distances "very close" to
		/// the surface) and 255 (at the specified maximum distance)... assuming the
		/// CapValue is not changed from 255.
		/// </summary>
		// Token: 0x06010E0F RID: 69135 RVA: 0x0017843B File Offset: 0x0017663B
		public virtual void SetScaleToMaximumDistance(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetScaleToMaximumDistance_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06010E10 RID: 69136
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitModeller_StartAppend_66(HandleRef pThis);

		/// <summary>
		/// Initialize the filter for appending data. You must invoke the
		/// StartAppend() method before doing successive Appends(). It's also a
		/// good idea to manually specify the model bounds; otherwise the input
		/// bounds for the data will be used.
		/// </summary>
		// Token: 0x06010E11 RID: 69137 RVA: 0x0017844B File Offset: 0x0017664B
		public void StartAppend()
		{
			vtkImplicitModeller.vtkImplicitModeller_StartAppend_66(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001378 RID: 4984
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitModeller";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001379 RID: 4985
		public new static readonly string MRClassNameKey = "class vtkImplicitModeller";
	}
}
