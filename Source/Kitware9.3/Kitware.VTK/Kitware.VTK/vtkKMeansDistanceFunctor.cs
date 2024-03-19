using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkKMeansDistanceFunctor
	/// </summary>
	/// <remarks>
	///    measure distance from k-means cluster centers
	///
	/// This is an abstract class (with a default concrete subclass) that implements
	/// algorithms used by the vtkKMeansStatistics filter that rely on a distance metric.
	/// If you wish to use a non-Euclidean distance metric (this could include
	/// working with strings that do not have a Euclidean distance metric, implementing
	/// k-mediods, or trying distance metrics in norms other than L2), you
	/// should subclass vtkKMeansDistanceFunctor.
	/// </remarks>
	// Token: 0x02000746 RID: 1862
	public class vtkKMeansDistanceFunctor : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060135BB RID: 79291 RVA: 0x001B60CB File Offset: 0x001B42CB
		static vtkKMeansDistanceFunctor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKMeansDistanceFunctor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansDistanceFunctor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060135BC RID: 79292 RVA: 0x001B60F3 File Offset: 0x001B42F3
		public vtkKMeansDistanceFunctor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060135BD RID: 79293
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135BE RID: 79294 RVA: 0x001B6104 File Offset: 0x001B4304
		public new static vtkKMeansDistanceFunctor New()
		{
			vtkKMeansDistanceFunctor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135BF RID: 79295 RVA: 0x001B6158 File Offset: 0x001B4358
		public vtkKMeansDistanceFunctor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060135C0 RID: 79296 RVA: 0x001B619C File Offset: 0x001B439C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060135C1 RID: 79297
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctor_AllocateElementArray_01(HandleRef pThis, long size);

		/// <summary>
		/// Allocate an array large enough to hold \a size coordinates and return a void pointer to this
		/// array. This is used by vtkPKMeansStatistics to send (receive) cluster center coordinates to
		/// (from) other processes.
		/// </summary>
		// Token: 0x060135C2 RID: 79298 RVA: 0x001B61A8 File Offset: 0x001B43A8
		public virtual IntPtr AllocateElementArray(long size)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_AllocateElementArray_01(base.GetCppThis(), size);
		}

		// Token: 0x060135C3 RID: 79299
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctor_CreateCoordinateArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a vtkAbstractArray capable of holding cluster center coordinates.
		/// This is used by vtkPKMeansStatistics to hold cluster center coordinates sent to (received from)
		/// other processes.
		/// </summary>
		// Token: 0x060135C4 RID: 79300 RVA: 0x001B61C8 File Offset: 0x001B43C8
		public virtual vtkAbstractArray CreateCoordinateArray()
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_CreateCoordinateArray_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x060135C5 RID: 79301
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctor_DeallocateElementArray_03(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Free an array allocated with AllocateElementArray.
		/// </summary>
		// Token: 0x060135C6 RID: 79302 RVA: 0x001B6237 File Offset: 0x001B4437
		public virtual void DeallocateElementArray(IntPtr arg0)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_DeallocateElementArray_03(base.GetCppThis(), arg0);
		}

		// Token: 0x060135C7 RID: 79303
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansDistanceFunctor_GetDataType_04(HandleRef pThis);

		/// <summary>
		/// Return the data type used to store cluster center coordinates.
		/// </summary>
		// Token: 0x060135C8 RID: 79304 RVA: 0x001B6248 File Offset: 0x001B4448
		public virtual int GetDataType()
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_GetDataType_04(base.GetCppThis());
		}

		// Token: 0x060135C9 RID: 79305
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctor_GetEmptyTuple_05(HandleRef pThis, long dimension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an empty tuple. These values are used as cluster center coordinates
		/// when no initial cluster centers are specified.
		/// </summary>
		// Token: 0x060135CA RID: 79306 RVA: 0x001B6268 File Offset: 0x001B4468
		public virtual vtkVariantArray GetEmptyTuple(long dimension)
		{
			vtkVariantArray vtkVariantArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_GetEmptyTuple_05(base.GetCppThis(), dimension, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVariantArray = (vtkVariantArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVariantArray.Register(null);
				}
			}
			return vtkVariantArray;
		}

		// Token: 0x060135CB RID: 79307
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135CC RID: 79308 RVA: 0x001B62D8 File Offset: 0x001B44D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060135CD RID: 79309
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135CE RID: 79310 RVA: 0x001B62F8 File Offset: 0x001B44F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060135CF RID: 79311
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansDistanceFunctor_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135D0 RID: 79312 RVA: 0x001B6314 File Offset: 0x001B4514
		public override int IsA(string type)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060135D1 RID: 79313
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkKMeansDistanceFunctor_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135D2 RID: 79314 RVA: 0x001B6334 File Offset: 0x001B4534
		public new static int IsTypeOf(string type)
		{
			return vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_IsTypeOf_09(type);
		}

		// Token: 0x060135D3 RID: 79315
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctor_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135D4 RID: 79316 RVA: 0x001B6350 File Offset: 0x001B4550
		public new vtkKMeansDistanceFunctor NewInstance()
		{
			vtkKMeansDistanceFunctor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060135D5 RID: 79317
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctor_PackElements_12(HandleRef pThis, HandleRef curTable, IntPtr vElements);

		/// <summary>
		/// Pack the cluster center coordinates in \a vElements into columns of \a curTable.
		/// This code may assume that the columns in \a curTable are all of the type returned by \a
		/// GetNewVTKArray().
		/// </summary>
		// Token: 0x060135D6 RID: 79318 RVA: 0x001B63AC File Offset: 0x001B45AC
		public virtual void PackElements(vtkTable curTable, IntPtr vElements)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_PackElements_12(base.GetCppThis(), (curTable == null) ? default(HandleRef) : curTable.GetCppThis(), vElements);
		}

		// Token: 0x060135D7 RID: 79319
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctor_PairwiseUpdate_13(HandleRef pThis, HandleRef clusterCenters, long row, HandleRef data, long dataCardinality, long totalCardinality);

		/// <summary>
		/// This is called once per observation per run per iteration in order to assign the
		/// observation to its nearest cluster center after the distance functor has been
		/// evaluated for all the cluster centers.
		///
		/// The distance functor is responsible for incrementally updating the cluster centers
		/// to account for the assignment.
		/// </summary>
		// Token: 0x060135D8 RID: 79320 RVA: 0x001B63DC File Offset: 0x001B45DC
		public virtual void PairwiseUpdate(vtkTable clusterCenters, long row, vtkVariantArray data, long dataCardinality, long totalCardinality)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_PairwiseUpdate_13(base.GetCppThis(), (clusterCenters == null) ? default(HandleRef) : clusterCenters.GetCppThis(), row, (data == null) ? default(HandleRef) : data.GetCppThis(), dataCardinality, totalCardinality);
		}

		// Token: 0x060135D9 RID: 79321
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctor_PerturbElement_14(HandleRef pThis, HandleRef arg0, HandleRef arg1, long arg2, long arg3, long arg4, double arg5);

		/// <summary>
		/// When a cluster center (1) has no observations that are closer to it than other cluster centers
		/// or (2) has exactly the same coordinates as another cluster center, its coordinates should be
		/// perturbed. This function should perform that perturbation.
		///
		/// Since perturbation relies on a distance metric, this function is the responsibility of the
		/// distance functor.
		/// </summary>
		// Token: 0x060135DA RID: 79322 RVA: 0x001B6428 File Offset: 0x001B4628
		public virtual void PerturbElement(vtkTable arg0, vtkTable arg1, long arg2, long arg3, long arg4, double arg5)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_PerturbElement_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3, arg4, arg5);
		}

		// Token: 0x060135DB RID: 79323
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkKMeansDistanceFunctor_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060135DC RID: 79324 RVA: 0x001B6474 File Offset: 0x001B4674
		public new static vtkKMeansDistanceFunctor SafeDownCast(vtkObjectBase o)
		{
			vtkKMeansDistanceFunctor vtkKMeansDistanceFunctor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKMeansDistanceFunctor = (vtkKMeansDistanceFunctor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKMeansDistanceFunctor.Register(null);
				}
			}
			return vtkKMeansDistanceFunctor;
		}

		// Token: 0x060135DD RID: 79325
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctor_UnPackElements_16(HandleRef pThis, HandleRef curTable, HandleRef newTable, IntPtr vLocalElements, IntPtr vGlobalElements, int np);

		/// <summary>
		/// Unpack the cluster center coordinates in \a vElements into columns of \a curTable.
		/// This code may assume that the columns in \a curTable are all of the type returned by \a
		/// GetNewVTKArray().
		/// </summary>
		// Token: 0x060135DE RID: 79326 RVA: 0x001B64F4 File Offset: 0x001B46F4
		public virtual void UnPackElements(vtkTable curTable, vtkTable newTable, IntPtr vLocalElements, IntPtr vGlobalElements, int np)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_UnPackElements_16(base.GetCppThis(), (curTable == null) ? default(HandleRef) : curTable.GetCppThis(), (newTable == null) ? default(HandleRef) : newTable.GetCppThis(), vLocalElements, vGlobalElements, np);
		}

		// Token: 0x060135DF RID: 79327
		[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkKMeansDistanceFunctor_UnPackElements_17(HandleRef pThis, HandleRef curTable, IntPtr vLocalElements, long numRows, long numCols);

		/// <summary>
		/// Unpack the cluster center coordinates in \a vElements into columns of \a curTable.
		/// This code may assume that the columns in \a curTable are all of the type returned by \a
		/// GetNewVTKArray().
		/// </summary>
		// Token: 0x060135E0 RID: 79328 RVA: 0x001B6540 File Offset: 0x001B4740
		public virtual void UnPackElements(vtkTable curTable, IntPtr vLocalElements, long numRows, long numCols)
		{
			vtkKMeansDistanceFunctor.vtkKMeansDistanceFunctor_UnPackElements_17(base.GetCppThis(), (curTable == null) ? default(HandleRef) : curTable.GetCppThis(), vLocalElements, numRows, numCols);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400165C RID: 5724
		public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansDistanceFunctor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400165D RID: 5725
		public new static readonly string MRClassNameKey = "class vtkKMeansDistanceFunctor";
	}
}
