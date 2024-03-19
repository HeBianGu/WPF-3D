using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    A helper class for interpolating between times during particle tracing
	///
	/// vtkTemporalInterpolatedVelocityField is a general purpose
	/// helper for the temporal particle tracing code (vtkParticleTracerBase)
	///
	/// It maintains two copies of vtkCompositeInterpolatedVelocityField internally
	/// and uses them to obtain velocity values at time T0 and T1.
	///
	/// In fact the class does quite a bit more than this because when the geometry
	/// of the datasets is the same at T0 and T1, we can re-use cached cell Ids and
	/// weights used in the cell interpolation routines.
	/// Additionally, the same weights can be used when interpolating (point) scalar
	/// values and computing vorticity etc.
	///
	/// @warning
	/// vtkTemporalInterpolatedVelocityField is not thread safe.
	/// A new instance should be created by each thread.
	///
	/// @warning
	/// Datasets are added in lists. The list for T1 must be identical to that for T0
	/// in structure/topology and dataset order, and any datasets marked as static,
	/// must remain so for all T - changing a dataset from static to dynamic
	/// between time steps will result in undefined behaviour (=crash probably)
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCompositeInterpolatedVelocityField vtkParticleTracerBase
	/// vtkParticleTracer vtkParticlePathFilter vtkStreaklineFilter
	/// </seealso>
	// Token: 0x020004C6 RID: 1222
	public class vtkTemporalInterpolatedVelocityField : vtkFunctionSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DF2B RID: 57131 RVA: 0x001359E9 File Offset: 0x00133BE9
		static vtkTemporalInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DF2C RID: 57132 RVA: 0x00135A11 File Offset: 0x00133C11
		public vtkTemporalInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DF2D RID: 57133
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkTemporalInterpolatedVelocityField with no initial data set.
		/// Caching is on. LastCellId is set to -1.
		/// </summary>
		// Token: 0x0600DF2E RID: 57134 RVA: 0x00135A20 File Offset: 0x00133C20
		public new static vtkTemporalInterpolatedVelocityField New()
		{
			vtkTemporalInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkTemporalInterpolatedVelocityField with no initial data set.
		/// Caching is on. LastCellId is set to -1.
		/// </summary>
		// Token: 0x0600DF2F RID: 57135 RVA: 0x00135A74 File Offset: 0x00133C74
		public vtkTemporalInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DF30 RID: 57136 RVA: 0x00135AB8 File Offset: 0x00133CB8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DF31 RID: 57137
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_AddDataSetAtTime_01(HandleRef pThis, int N, double T, HandleRef dataset);

		/// <summary>
		/// In order to use this class, two sets of data must be supplied,
		/// corresponding to times T1 and T2. Data is added via
		/// this function.
		/// </summary>
		// Token: 0x0600DF32 RID: 57138 RVA: 0x00135AC4 File Offset: 0x00133CC4
		public void AddDataSetAtTime(int N, double T, vtkDataSet dataset)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_AddDataSetAtTime_01(base.GetCppThis(), N, T, (dataset == null) ? default(HandleRef) : dataset.GetCppThis());
		}

		// Token: 0x0600DF33 RID: 57139
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_AdvanceOneTimeStep_02(HandleRef pThis);

		/// <summary>
		/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
		/// </summary>
		// Token: 0x0600DF34 RID: 57140 RVA: 0x00135AF5 File Offset: 0x00133CF5
		public void AdvanceOneTimeStep()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_AdvanceOneTimeStep_02(base.GetCppThis());
		}

		// Token: 0x0600DF35 RID: 57141
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_ClearCache_03(HandleRef pThis);

		/// <summary>
		/// Set the last cell id to -1 so that the next search does not
		/// start from the previous cell
		/// </summary>
		// Token: 0x0600DF36 RID: 57142 RVA: 0x00135B04 File Offset: 0x00133D04
		public void ClearCache()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_ClearCache_03(base.GetCppThis());
		}

		// Token: 0x0600DF37 RID: 57143
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_CopyParameters_04(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// interpolators between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		/// </summary>
		// Token: 0x0600DF38 RID: 57144 RVA: 0x00135B14 File Offset: 0x00133D14
		public virtual void CopyParameters(vtkTemporalInterpolatedVelocityField from)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_CopyParameters_04(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0600DF39 RID: 57145
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_FunctionValues_05(HandleRef pThis, IntPtr x, IntPtr u);

		/// <summary>
		/// Evaluate the velocity field, f, at (x, y, z, t).
		/// For now, t is ignored.
		/// </summary>
		// Token: 0x0600DF3A RID: 57146 RVA: 0x00135B44 File Offset: 0x00133D44
		public override int FunctionValues(IntPtr x, IntPtr u)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_FunctionValues_05(base.GetCppThis(), x, u);
		}

		// Token: 0x0600DF3B RID: 57147
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_FunctionValuesAtT_06(HandleRef pThis, int T, IntPtr x, IntPtr u);

		/// <summary>
		/// Evaluate the velocity field, f, at (x, y, z, t).
		/// For now, t is ignored.
		/// </summary>
		// Token: 0x0600DF3C RID: 57148 RVA: 0x00135B68 File Offset: 0x00133D68
		public int FunctionValuesAtT(int T, IntPtr x, IntPtr u)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_FunctionValuesAtT_06(base.GetCppThis(), T, x, u);
		}

		// Token: 0x0600DF3D RID: 57149
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalInterpolatedVelocityField_GetCachedCellIds_07(HandleRef pThis, IntPtr id, IntPtr ds);

		/// <summary>
		/// Between iterations of the Particle Tracer, Id's of the Cell
		/// are stored and then at the start of the next particle the
		/// Ids are set to 'pre-fill' the cache.
		/// </summary>
		// Token: 0x0600DF3E RID: 57150 RVA: 0x00135B8C File Offset: 0x00133D8C
		public bool GetCachedCellIds(IntPtr id, IntPtr ds)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetCachedCellIds_07(base.GetCppThis(), id, ds) != 0;
		}

		// Token: 0x0600DF3F RID: 57151
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkTemporalInterpolatedVelocityField_GetCurrentWeight_08(HandleRef pThis);

		/// <summary>
		/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
		/// </summary>
		// Token: 0x0600DF40 RID: 57152 RVA: 0x00135BB4 File Offset: 0x00133DB4
		public virtual double GetCurrentWeight()
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetCurrentWeight_08(base.GetCppThis());
		}

		// Token: 0x0600DF41 RID: 57153
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_GetFindCellStrategy_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the strategy used to perform the FindCell() operation. This
		/// strategy is used when operating on vtkPointSet subclasses. Note if the
		/// input is a composite dataset then the strategy will be used to clone
		/// one strategy per leaf dataset.
		/// </summary>
		// Token: 0x0600DF42 RID: 57154 RVA: 0x00135BD4 File Offset: 0x00133DD4
		public virtual vtkFindCellStrategy GetFindCellStrategy()
		{
			vtkFindCellStrategy vtkFindCellStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetFindCellStrategy_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFindCellStrategy = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFindCellStrategy.Register(null);
				}
			}
			return vtkFindCellStrategy;
		}

		// Token: 0x0600DF43 RID: 57155
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_10(HandleRef pThis);

		/// <summary>
		/// If an interpolation was successful, we can retrieve the last computed
		/// value from here. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x0600DF44 RID: 57156 RVA: 0x00135C44 File Offset: 0x00133E44
		public virtual double[] GetLastGoodVelocity()
		{
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600DF45 RID: 57157
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// If an interpolation was successful, we can retrieve the last computed
		/// value from here. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x0600DF46 RID: 57158 RVA: 0x00135C8C File Offset: 0x00133E8C
		public virtual void GetLastGoodVelocity(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600DF47 RID: 57159
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// If an interpolation was successful, we can retrieve the last computed
		/// value from here. Initial value is (0.0,0.0,0.0)
		/// </summary>
		// Token: 0x0600DF48 RID: 57160 RVA: 0x00135C9E File Offset: 0x00133E9E
		public virtual void GetLastGoodVelocity(IntPtr _arg)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetLastGoodVelocity_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DF49 RID: 57161
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_GetMeshOverTime_13(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF4A RID: 57162 RVA: 0x00135CB0 File Offset: 0x00133EB0
		public virtual int GetMeshOverTime()
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetMeshOverTime_13(base.GetCppThis());
		}

		// Token: 0x0600DF4B RID: 57163
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMaxValue_14(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF4C RID: 57164 RVA: 0x00135CD0 File Offset: 0x00133ED0
		public virtual int GetMeshOverTimeMaxValue()
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMaxValue_14(base.GetCppThis());
		}

		// Token: 0x0600DF4D RID: 57165
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMinValue_15(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF4E RID: 57166 RVA: 0x00135CF0 File Offset: 0x00133EF0
		public virtual int GetMeshOverTimeMinValue()
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetMeshOverTimeMinValue_15(base.GetCppThis());
		}

		// Token: 0x0600DF4F RID: 57167
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF50 RID: 57168 RVA: 0x00135D10 File Offset: 0x00133F10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600DF51 RID: 57169
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF52 RID: 57170 RVA: 0x00135D30 File Offset: 0x00133F30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600DF53 RID: 57171
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalInterpolatedVelocityField_GetVorticityData_18(HandleRef pThis, int T, IntPtr pcoords, IntPtr weights, HandleRef cell, HandleRef cellVectors);

		/// <summary>
		/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
		/// </summary>
		// Token: 0x0600DF54 RID: 57172 RVA: 0x00135D4C File Offset: 0x00133F4C
		public bool GetVorticityData(int T, IntPtr pcoords, IntPtr weights, vtkGenericCell cell, vtkDoubleArray cellVectors)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_GetVorticityData_18(base.GetCppThis(), T, pcoords, weights, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (cellVectors == null) ? default(HandleRef) : cellVectors.GetCppThis()) != 0;
		}

		// Token: 0x0600DF55 RID: 57173
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_Initialize_19(HandleRef pThis, HandleRef t0, HandleRef t1);

		/// <summary>
		/// The Initialize() method is used to build and cache supporting structures
		/// (such as locators) which are used when operating on the interpolated
		/// velocity field. This method is needed mainly to deal with thread safety
		/// issues; i.e., these supporting structures must be built at the right
		/// time to avoid race conditions.
		/// </summary>
		// Token: 0x0600DF56 RID: 57174 RVA: 0x00135DA4 File Offset: 0x00133FA4
		public void Initialize(vtkCompositeDataSet t0, vtkCompositeDataSet t1)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_Initialize_19(base.GetCppThis(), (t0 == null) ? default(HandleRef) : t0.GetCppThis(), (t1 == null) ? default(HandleRef) : t1.GetCppThis());
		}

		// Token: 0x0600DF57 RID: 57175
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalInterpolatedVelocityField_InterpolatePoint_20(HandleRef pThis, HandleRef outPD1, HandleRef outPD2, long outIndex);

		/// <summary>
		/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
		/// </summary>
		// Token: 0x0600DF58 RID: 57176 RVA: 0x00135DE8 File Offset: 0x00133FE8
		public bool InterpolatePoint(vtkPointData outPD1, vtkPointData outPD2, long outIndex)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_InterpolatePoint_20(base.GetCppThis(), (outPD1 == null) ? default(HandleRef) : outPD1.GetCppThis(), (outPD2 == null) ? default(HandleRef) : outPD2.GetCppThis(), outIndex) != 0;
		}

		// Token: 0x0600DF59 RID: 57177
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalInterpolatedVelocityField_InterpolatePoint_21(HandleRef pThis, int T, HandleRef outPD1, long outIndex);

		/// <summary>
		/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
		/// </summary>
		// Token: 0x0600DF5A RID: 57178 RVA: 0x00135E3C File Offset: 0x0013403C
		public bool InterpolatePoint(int T, vtkPointData outPD1, long outIndex)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_InterpolatePoint_21(base.GetCppThis(), T, (outPD1 == null) ? default(HandleRef) : outPD1.GetCppThis(), outIndex) != 0;
		}

		// Token: 0x0600DF5B RID: 57179
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF5C RID: 57180 RVA: 0x00135E7C File Offset: 0x0013407C
		public override int IsA(string type)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x0600DF5D RID: 57181
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF5E RID: 57182 RVA: 0x00135E9C File Offset: 0x0013409C
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_IsTypeOf_23(type);
		}

		// Token: 0x0600DF5F RID: 57183
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF60 RID: 57184 RVA: 0x00135EB8 File Offset: 0x001340B8
		public new vtkTemporalInterpolatedVelocityField NewInstance()
		{
			vtkTemporalInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DF61 RID: 57185
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_QuickTestPoint_26(HandleRef pThis, IntPtr x);

		/// <summary>
		/// A utility function which evaluates the point at T1, T2 to see
		/// if it is inside the data at both times or only one.
		/// </summary>
		// Token: 0x0600DF62 RID: 57186 RVA: 0x00135F14 File Offset: 0x00134114
		public int QuickTestPoint(IntPtr x)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_QuickTestPoint_26(base.GetCppThis(), x);
		}

		// Token: 0x0600DF63 RID: 57187
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalInterpolatedVelocityField_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DF64 RID: 57188 RVA: 0x00135F34 File Offset: 0x00134134
		public new static vtkTemporalInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalInterpolatedVelocityField vtkTemporalInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalInterpolatedVelocityField = (vtkTemporalInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalInterpolatedVelocityField.Register(null);
				}
			}
			return vtkTemporalInterpolatedVelocityField;
		}

		// Token: 0x0600DF65 RID: 57189
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SelectVectors_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to work with an arbitrary vector array, then set its name
		/// here. By default this is nullptr and the filter will use the active vector
		/// array.
		/// </summary>
		// Token: 0x0600DF66 RID: 57190 RVA: 0x00135FB3 File Offset: 0x001341B3
		public void SelectVectors(string fieldName)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SelectVectors_28(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600DF67 RID: 57191
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetCachedCellIds_29(HandleRef pThis, IntPtr id, IntPtr ds);

		/// <summary>
		/// Between iterations of the Particle Tracer, Id's of the Cell
		/// are stored and then at the start of the next particle the
		/// Ids are set to 'pre-fill' the cache.
		/// </summary>
		// Token: 0x0600DF68 RID: 57192 RVA: 0x00135FC3 File Offset: 0x001341C3
		public void SetCachedCellIds(IntPtr id, IntPtr ds)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetCachedCellIds_29(base.GetCppThis(), id, ds);
		}

		// Token: 0x0600DF69 RID: 57193
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetFindCellStrategy_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the strategy used to perform the FindCell() operation. This
		/// strategy is used when operating on vtkPointSet subclasses. Note if the
		/// input is a composite dataset then the strategy will be used to clone
		/// one strategy per leaf dataset.
		/// </summary>
		// Token: 0x0600DF6A RID: 57194 RVA: 0x00135FD4 File Offset: 0x001341D4
		public virtual void SetFindCellStrategy(vtkFindCellStrategy arg0)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetFindCellStrategy_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DF6B RID: 57195
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTime_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF6C RID: 57196 RVA: 0x00136003 File Offset: 0x00134203
		public virtual void SetMeshOverTime(int _arg)
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetMeshOverTime_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600DF6D RID: 57197
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToDifferent_32(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF6E RID: 57198 RVA: 0x00136013 File Offset: 0x00134213
		public void SetMeshOverTimeToDifferent()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToDifferent_32(base.GetCppThis());
		}

		// Token: 0x0600DF6F RID: 57199
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToLinearTransformation_33(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF70 RID: 57200 RVA: 0x00136022 File Offset: 0x00134222
		public void SetMeshOverTimeToLinearTransformation()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToLinearTransformation_33(base.GetCppThis());
		}

		// Token: 0x0600DF71 RID: 57201
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToSameTopology_34(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF72 RID: 57202 RVA: 0x00136031 File Offset: 0x00134231
		public void SetMeshOverTimeToSameTopology()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToSameTopology_34(base.GetCppThis());
		}

		// Token: 0x0600DF73 RID: 57203
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToStatic_35(HandleRef pThis);

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x0600DF74 RID: 57204 RVA: 0x00136040 File Offset: 0x00134240
		public void SetMeshOverTimeToStatic()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_SetMeshOverTimeToStatic_35(base.GetCppThis());
		}

		// Token: 0x0600DF75 RID: 57205
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalInterpolatedVelocityField_ShowCacheResults_36(HandleRef pThis);

		/// <summary>
		/// Get the most recent weight between 0-&gt;1 from T1-&gt;T2. Initial value is 0.
		/// </summary>
		// Token: 0x0600DF76 RID: 57206 RVA: 0x0013604F File Offset: 0x0013424F
		public void ShowCacheResults()
		{
			vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_ShowCacheResults_36(base.GetCppThis());
		}

		// Token: 0x0600DF77 RID: 57207
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalInterpolatedVelocityField_TestPoint_37(HandleRef pThis, IntPtr x);

		/// <summary>
		/// A utility function which evaluates the point at T1, T2 to see
		/// if it is inside the data at both times or only one.
		/// </summary>
		// Token: 0x0600DF78 RID: 57208 RVA: 0x00136060 File Offset: 0x00134260
		public int TestPoint(IntPtr x)
		{
			return vtkTemporalInterpolatedVelocityField.vtkTemporalInterpolatedVelocityField_TestPoint_37(base.GetCppThis(), x);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001061 RID: 4193
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001062 RID: 4194
		public new static readonly string MRClassNameKey = "class vtkTemporalInterpolatedVelocityField";

		/// <summary>
		/// States that define where the cell id are
		/// </summary>
		// Token: 0x020004C7 RID: 1223
		public enum IDStates
		{
			/// <summary>enum member</summary>
			// Token: 0x04001064 RID: 4196
			INSIDE_ALL,
			/// <summary>enum member</summary>
			// Token: 0x04001065 RID: 4197
			OUTSIDE_ALL,
			/// <summary>enum member</summary>
			// Token: 0x04001066 RID: 4198
			OUTSIDE_T0,
			/// <summary>enum member</summary>
			// Token: 0x04001067 RID: 4199
			OUTSIDE_T1
		}

		/// <summary>
		/// Types of Variance of Mesh over time
		/// </summary>
		// Token: 0x020004C8 RID: 1224
		public enum MeshOverTimeTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001069 RID: 4201
			DIFFERENT,
			/// <summary>enum member</summary>
			// Token: 0x0400106A RID: 4202
			LINEAR_TRANSFORMATION = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400106B RID: 4203
			SAME_TOPOLOGY,
			/// <summary>enum member</summary>
			// Token: 0x0400106C RID: 4204
			STATIC = 1
		}
	}
}
