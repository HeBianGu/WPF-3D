using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDataArray
	/// </summary>
	/// <remarks>
	///    abstract superclass for arrays of numeric data
	///
	///
	/// vtkDataArray is an abstract superclass for data array objects
	/// containing numeric data.  It extends the API defined in
	/// vtkAbstractArray.  vtkDataArray is an abstract superclass for data
	/// array objects. This class defines an API that all array objects
	/// must support. Note that the concrete subclasses of this class
	/// represent data in native form (char, int, etc.) and often have
	/// specialized more efficient methods for operating on this data (for
	/// example, getting pointers to data or getting/inserting data in
	/// native form).  Subclasses of vtkDataArray are assumed to contain
	/// data whose components are meaningful when cast to and from double.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBitArray vtkGenericDataArray
	/// </seealso>
	// Token: 0x02000B28 RID: 2856
	public abstract class vtkDataArray : vtkAbstractArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DF0F RID: 122639 RVA: 0x002A4785 File Offset: 0x002A2985
		static vtkDataArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DF10 RID: 122640 RVA: 0x002A47AD File Offset: 0x002A29AD
		public vtkDataArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DF11 RID: 122641 RVA: 0x002A47BB File Offset: 0x002A29BB
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DF12 RID: 122642
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_COMPONENT_RANGE_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is used to hold tight bounds on the range of
		/// one component over all tuples of the array.
		/// Two values (a minimum and maximum) are stored for each component.
		/// When GetRange() is called when no tuples are present in the array
		/// this value is set to { VTK_DOUBLE_MAX, VTK_DOUBLE_MIN }.
		/// </summary>
		// Token: 0x0601DF13 RID: 122643 RVA: 0x002A47C8 File Offset: 0x002A29C8
		public static vtkInformationDoubleVectorKey COMPONENT_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_COMPONENT_RANGE_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601DF14 RID: 122644
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_CopyComponent_02(HandleRef pThis, int dstComponent, HandleRef src, int srcComponent);

		/// <summary>
		/// Copy a component from one data array into a component on this data array.
		/// This method copies the specified component ("srcComponent") from the
		/// specified data array ("src") to the specified component ("dstComponent")
		/// over all the tuples in this data array.  This method can be used to extract
		/// a component (column) from one data array and paste that data into
		/// a component on this data array.
		/// </summary>
		// Token: 0x0601DF15 RID: 122645 RVA: 0x002A4834 File Offset: 0x002A2A34
		public virtual void CopyComponent(int dstComponent, vtkDataArray src, int srcComponent)
		{
			vtkDataArray.vtkDataArray_CopyComponent_02(base.GetCppThis(), dstComponent, (src == null) ? default(HandleRef) : src.GetCppThis(), srcComponent);
		}

		// Token: 0x0601DF16 RID: 122646
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArray_CopyInformation_03(HandleRef pThis, HandleRef infoFrom, int deep);

		/// <summary>
		/// Copy information instance. Arrays use information objects
		/// in a variety of ways. It is important to have flexibility in
		/// this regard because certain keys should not be copied, while
		/// others must be. NOTE: Up to the implmenter to make sure that
		/// keys not intended to be copied are excluded here.
		/// </summary>
		// Token: 0x0601DF17 RID: 122647 RVA: 0x002A4868 File Offset: 0x002A2A68
		public override int CopyInformation(vtkInformation infoFrom, int deep)
		{
			return vtkDataArray.vtkDataArray_CopyInformation_03(base.GetCppThis(), (infoFrom == null) ? default(HandleRef) : infoFrom.GetCppThis(), deep);
		}

		// Token: 0x0601DF18 RID: 122648
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_CreateDataArray_04(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Creates an array for dataType where dataType is one of
		/// VTK_BIT, VTK_CHAR, VTK_SIGNED_CHAR, VTK_UNSIGNED_CHAR, VTK_SHORT,
		/// VTK_UNSIGNED_SHORT, VTK_INT, VTK_UNSIGNED_INT, VTK_LONG,
		/// VTK_UNSIGNED_LONG, VTK_FLOAT, VTK_DOUBLE, VTK_ID_TYPE.
		/// Note that the data array returned has be deleted by the
		/// user.
		/// </summary>
		// Token: 0x0601DF19 RID: 122649 RVA: 0x002A48A0 File Offset: 0x002A2AA0
		public static vtkDataArray CreateDataArray(int dataType)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_CreateDataArray_04(dataType, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DF1A RID: 122650
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_CreateDefaultLookupTable_05(HandleRef pThis);

		/// <summary>
		/// Create default lookup table. Generally used to create one when none
		/// is available.
		/// </summary>
		// Token: 0x0601DF1B RID: 122651 RVA: 0x002A490A File Offset: 0x002A2B0A
		public void CreateDefaultLookupTable()
		{
			vtkDataArray.vtkDataArray_CreateDefaultLookupTable_05(base.GetCppThis());
		}

		// Token: 0x0601DF1C RID: 122652
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_DeepCopy_06(HandleRef pThis, HandleRef aa);

		/// <summary>
		/// Deep copy of data. Copies data from different data arrays even if
		/// they are different types (using doubleing-point exchange).
		/// </summary>
		// Token: 0x0601DF1D RID: 122653 RVA: 0x002A491C File Offset: 0x002A2B1C
		public override void DeepCopy(vtkAbstractArray aa)
		{
			vtkDataArray.vtkDataArray_DeepCopy_06(base.GetCppThis(), (aa == null) ? default(HandleRef) : aa.GetCppThis());
		}

		// Token: 0x0601DF1E RID: 122654
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_DeepCopy_07(HandleRef pThis, HandleRef da);

		/// <summary>
		/// Deep copy of data. Copies data from different data arrays even if
		/// they are different types (using doubleing-point exchange).
		/// </summary>
		// Token: 0x0601DF1F RID: 122655 RVA: 0x002A494C File Offset: 0x002A2B4C
		public virtual void DeepCopy(vtkDataArray da)
		{
			vtkDataArray.vtkDataArray_DeepCopy_07(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis());
		}

		// Token: 0x0601DF20 RID: 122656
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_FastDownCast_08(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Perform a fast, safe cast from a vtkAbstractArray to a vtkDataArray.
		/// This method checks if source-&gt;GetArrayType() returns DataArray
		/// or a more derived type, and performs a static_cast to return
		/// source as a vtkDataArray pointer. Otherwise, nullptr is returned.
		/// </summary>
		// Token: 0x0601DF21 RID: 122657 RVA: 0x002A497C File Offset: 0x002A2B7C
		public static vtkDataArray FastDownCast(vtkAbstractArray source)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_FastDownCast_08((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DF22 RID: 122658
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_Fill_09(HandleRef pThis, double value);

		/// <summary>
		/// Fill all values of a data array with a specified value.
		/// </summary>
		// Token: 0x0601DF23 RID: 122659 RVA: 0x002A49FB File Offset: 0x002A2BFB
		public virtual void Fill(double value)
		{
			vtkDataArray.vtkDataArray_Fill_09(base.GetCppThis(), value);
		}

		// Token: 0x0601DF24 RID: 122660
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_FillComponent_10(HandleRef pThis, int compIdx, double value);

		/// <summary>
		/// Fill a component of a data array with a specified value. This method
		/// sets the specified component to specified value for all tuples in the
		/// data array.  This methods can be used to initialize or reinitialize a
		/// single component of a multi-component array.
		/// </summary>
		// Token: 0x0601DF25 RID: 122661 RVA: 0x002A4A0B File Offset: 0x002A2C0B
		public virtual void FillComponent(int compIdx, double value)
		{
			vtkDataArray.vtkDataArray_FillComponent_10(base.GetCppThis(), compIdx, value);
		}

		// Token: 0x0601DF26 RID: 122662
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDataArray_GetActualMemorySize_11(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this data array. Used to
		/// support streaming and reading/writing data. The value returned is
		/// guaranteed to be greater than or equal to the memory required to
		/// actually represent the data represented by this object. The
		/// information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601DF27 RID: 122663 RVA: 0x002A4A1C File Offset: 0x002A2C1C
		public override uint GetActualMemorySize()
		{
			return vtkDataArray.vtkDataArray_GetActualMemorySize_11(base.GetCppThis());
		}

		// Token: 0x0601DF28 RID: 122664
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArray_GetArrayType_12(HandleRef pThis);

		/// <summary>
		/// Method for type-checking in FastDownCast implementations.
		/// </summary>
		// Token: 0x0601DF29 RID: 122665 RVA: 0x002A4A3C File Offset: 0x002A2C3C
		public override int GetArrayType()
		{
			return vtkDataArray.vtkDataArray_GetArrayType_12(base.GetCppThis());
		}

		// Token: 0x0601DF2A RID: 122666
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetComponent_13(HandleRef pThis, long tupleIdx, int compIdx);

		/// <summary>
		/// Return the data component at the location specified by tupleIdx and
		/// compIdx.
		/// </summary>
		// Token: 0x0601DF2B RID: 122667 RVA: 0x002A4A5C File Offset: 0x002A2C5C
		public virtual double GetComponent(long tupleIdx, int compIdx)
		{
			return vtkDataArray.vtkDataArray_GetComponent_13(base.GetCppThis(), tupleIdx, compIdx);
		}

		// Token: 0x0601DF2C RID: 122668
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetData_14(HandleRef pThis, long tupleMin, long tupleMax, int compMin, int compMax, HandleRef data);

		/// <summary>
		/// Get the data as a double array in the range (tupleMin,tupleMax) and
		/// (compMin, compMax). The resulting double array consists of all data in
		/// the tuple range specified and only the component range specified. This
		/// process typically requires casting the data from native form into
		/// doubleing point values. This method is provided as a convenience for data
		/// exchange, and is not very fast.
		/// </summary>
		// Token: 0x0601DF2D RID: 122669 RVA: 0x002A4A80 File Offset: 0x002A2C80
		public virtual void GetData(long tupleMin, long tupleMax, int compMin, int compMax, vtkDoubleArray data)
		{
			vtkDataArray.vtkDataArray_GetData_14(base.GetCppThis(), tupleMin, tupleMax, compMin, compMax, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601DF2E RID: 122670
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetDataTypeMax_15(HandleRef pThis);

		/// <summary>
		/// These methods return the Min and Max possible range of the native
		/// data type. For example if a vtkScalars consists of unsigned char
		/// data these will return (0,255).
		/// </summary>
		// Token: 0x0601DF2F RID: 122671 RVA: 0x002A4AB8 File Offset: 0x002A2CB8
		public double GetDataTypeMax()
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMax_15(base.GetCppThis());
		}

		// Token: 0x0601DF30 RID: 122672
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetDataTypeMax_16(int type);

		/// <summary>
		/// These methods return the Min and Max possible range of the native
		/// data type. For example if a vtkScalars consists of unsigned char
		/// data these will return (0,255).
		/// </summary>
		// Token: 0x0601DF31 RID: 122673 RVA: 0x002A4AD8 File Offset: 0x002A2CD8
		public static double GetDataTypeMax(int type)
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMax_16(type);
		}

		// Token: 0x0601DF32 RID: 122674
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetDataTypeMin_17(HandleRef pThis);

		/// <summary>
		/// These methods return the Min and Max possible range of the native
		/// data type. For example if a vtkScalars consists of unsigned char
		/// data these will return (0,255).
		/// </summary>
		// Token: 0x0601DF33 RID: 122675 RVA: 0x002A4AF4 File Offset: 0x002A2CF4
		public double GetDataTypeMin()
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMin_17(base.GetCppThis());
		}

		// Token: 0x0601DF34 RID: 122676
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetDataTypeMin_18(int type);

		/// <summary>
		/// These methods return the Min and Max possible range of the native
		/// data type. For example if a vtkScalars consists of unsigned char
		/// data these will return (0,255).
		/// </summary>
		// Token: 0x0601DF35 RID: 122677 RVA: 0x002A4B14 File Offset: 0x002A2D14
		public static double GetDataTypeMin(int type)
		{
			return vtkDataArray.vtkDataArray_GetDataTypeMin_18(type);
		}

		// Token: 0x0601DF36 RID: 122678
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetDataTypeRange_19(HandleRef pThis, IntPtr range);

		/// <summary>
		/// These methods return the Min and Max possible range of the native
		/// data type. For example if a vtkScalars consists of unsigned char
		/// data these will return (0,255).
		/// </summary>
		// Token: 0x0601DF37 RID: 122679 RVA: 0x002A4B2E File Offset: 0x002A2D2E
		public void GetDataTypeRange(IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetDataTypeRange_19(base.GetCppThis(), range);
		}

		// Token: 0x0601DF38 RID: 122680
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetDataTypeRange_20(int type, IntPtr range);

		/// <summary>
		/// These methods return the Min and Max possible range of the native
		/// data type. For example if a vtkScalars consists of unsigned char
		/// data these will return (0,255).
		/// </summary>
		// Token: 0x0601DF39 RID: 122681 RVA: 0x002A4B3E File Offset: 0x002A2D3E
		public static void GetDataTypeRange(int type, IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetDataTypeRange_20(type, range);
		}

		// Token: 0x0601DF3A RID: 122682
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArray_GetElementComponentSize_21(HandleRef pThis);

		/// <summary>
		/// Return the size, in bytes, of the lowest-level element of an
		/// array.  For vtkDataArray and subclasses this is the size of the
		/// data type.
		/// </summary>
		// Token: 0x0601DF3B RID: 122683 RVA: 0x002A4B4C File Offset: 0x002A2D4C
		public override int GetElementComponentSize()
		{
			return vtkDataArray.vtkDataArray_GetElementComponentSize_21(base.GetCppThis());
		}

		// Token: 0x0601DF3C RID: 122684
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetFiniteRange_22(HandleRef pThis, IntPtr range, int comp);

		/// <summary>
		/// The range of the data array values for the given component will be
		/// returned in the provided range array argument. If comp is -1, the range
		/// of the magnitude (L2 norm) over all components will be provided. The
		/// range is computed and then cached, and will not be re-computed on
		/// subsequent calls to GetRange() unless the array is modified or the
		/// requested component changes.
		///
		/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
		/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
		/// then the corresponding tuple is not accounted for when computing the range.
		///
		/// Note that when the ghost array is provided, no cached value is stored inside
		/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
		/// when using a ghost array.
		///
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF3D RID: 122685 RVA: 0x002A4B6B File Offset: 0x002A2D6B
		public void GetFiniteRange(IntPtr range, int comp)
		{
			vtkDataArray.vtkDataArray_GetFiniteRange_22(base.GetCppThis(), range, comp);
		}

		// Token: 0x0601DF3E RID: 122686
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetFiniteRange_23(HandleRef pThis, IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip);

		/// <summary>
		/// The range of the data array values for the given component will be
		/// returned in the provided range array argument. If comp is -1, the range
		/// of the magnitude (L2 norm) over all components will be provided. The
		/// range is computed and then cached, and will not be re-computed on
		/// subsequent calls to GetRange() unless the array is modified or the
		/// requested component changes.
		///
		/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
		/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
		/// then the corresponding tuple is not accounted for when computing the range.
		///
		/// Note that when the ghost array is provided, no cached value is stored inside
		/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
		/// when using a ghost array.
		///
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF3F RID: 122687 RVA: 0x002A4B7C File Offset: 0x002A2D7C
		public void GetFiniteRange(IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip)
		{
			vtkDataArray.vtkDataArray_GetFiniteRange_23(base.GetCppThis(), range, comp, ghosts, ghostsToSkip);
		}

		// Token: 0x0601DF40 RID: 122688
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetFiniteRange_24(HandleRef pThis, int comp);

		/// <summary>
		/// Return the range of the data array values for the given component. If
		/// comp is -1, return the range of the magnitude (L2 norm) over all
		/// components.The range is computed and then cached, and will not be
		/// re-computed on subsequent calls to GetRange() unless the array is
		/// modified or the requested component changes.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF41 RID: 122689 RVA: 0x002A4B90 File Offset: 0x002A2D90
		public IntPtr GetFiniteRange(int comp)
		{
			return vtkDataArray.vtkDataArray_GetFiniteRange_24(base.GetCppThis(), comp);
		}

		// Token: 0x0601DF42 RID: 122690
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetFiniteRange_25(HandleRef pThis);

		/// <summary>
		/// Return the range of the data array. If the array has multiple components,
		/// then this will return the range of only the first component (component
		/// zero). The range is computed and then cached, and will not be re-computed
		/// on subsequent calls to GetRange() unless the array is modified.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF43 RID: 122691 RVA: 0x002A4BB0 File Offset: 0x002A2DB0
		public IntPtr GetFiniteRange()
		{
			return vtkDataArray.vtkDataArray_GetFiniteRange_25(base.GetCppThis());
		}

		// Token: 0x0601DF44 RID: 122692
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetFiniteRange_26(HandleRef pThis, IntPtr range);

		/// <summary>
		/// The range of the data array values will be returned in the provided
		/// range array argument. If the data array has multiple components, then
		/// this will return the range of only the first component (component zero).
		/// The range is computend and then cached, and will not be re-computed on
		/// subsequent calls to GetRange() unless the array is modified.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF45 RID: 122693 RVA: 0x002A4BCF File Offset: 0x002A2DCF
		public void GetFiniteRange(IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetFiniteRange_26(base.GetCppThis(), range);
		}

		// Token: 0x0601DF46 RID: 122694
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetLookupTable_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the lookup table associated with this scalar data, if any.
		/// </summary>
		// Token: 0x0601DF47 RID: 122695 RVA: 0x002A4BE0 File Offset: 0x002A2DE0
		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetLookupTable_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x0601DF48 RID: 122696
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetMaxNorm_28(HandleRef pThis);

		/// <summary>
		/// Return the maximum norm for the tuples.
		/// Note that the max. is computed every time GetMaxNorm is called.
		/// </summary>
		// Token: 0x0601DF49 RID: 122697 RVA: 0x002A4C50 File Offset: 0x002A2E50
		public virtual double GetMaxNorm()
		{
			return vtkDataArray.vtkDataArray_GetMaxNorm_28(base.GetCppThis());
		}

		// Token: 0x0601DF4A RID: 122698
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArray_GetNumberOfGenerationsFromBase_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DF4B RID: 122699 RVA: 0x002A4C70 File Offset: 0x002A2E70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDataArray.vtkDataArray_GetNumberOfGenerationsFromBase_29(base.GetCppThis(), type);
		}

		// Token: 0x0601DF4C RID: 122700
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArray_GetNumberOfGenerationsFromBaseType_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DF4D RID: 122701 RVA: 0x002A4C90 File Offset: 0x002A2E90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDataArray.vtkDataArray_GetNumberOfGenerationsFromBaseType_30(type);
		}

		// Token: 0x0601DF4E RID: 122702
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetRange_31(HandleRef pThis, IntPtr range, int comp);

		/// <summary>
		/// The range of the data array values for the given component will be
		/// returned in the provided range array argument. If comp is -1, the range
		/// of the magnitude (L2 norm) over all components will be provided. The
		/// range is computed and then cached, and will not be re-computed on
		/// subsequent calls to GetRange() unless the array is modified or the
		/// requested component changes.
		///
		/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
		/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
		/// then the corresponding tuple is not accounted for when computing the range.
		/// Note that when the ghost array is provided, no cached value is stored inside
		/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
		/// when using a ghost array.
		///
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF4F RID: 122703 RVA: 0x002A4CAA File Offset: 0x002A2EAA
		public void GetRange(IntPtr range, int comp)
		{
			vtkDataArray.vtkDataArray_GetRange_31(base.GetCppThis(), range, comp);
		}

		// Token: 0x0601DF50 RID: 122704
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetRange_32(HandleRef pThis, IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip);

		/// <summary>
		/// The range of the data array values for the given component will be
		/// returned in the provided range array argument. If comp is -1, the range
		/// of the magnitude (L2 norm) over all components will be provided. The
		/// range is computed and then cached, and will not be re-computed on
		/// subsequent calls to GetRange() unless the array is modified or the
		/// requested component changes.
		///
		/// The version of this method with `ghosts` and `ghostsToSkip` allows to skip
		/// values in the computation of the range. At a given id, if `ghosts[id] &amp; ghostsToSkip != 0`,
		/// then the corresponding tuple is not accounted for when computing the range.
		/// Note that when the ghost array is provided, no cached value is stored inside
		/// this instance. See `vtkFieldData::GetRange`, which caches the computated range
		/// when using a ghost array.
		///
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF51 RID: 122705 RVA: 0x002A4CBB File Offset: 0x002A2EBB
		public void GetRange(IntPtr range, int comp, IntPtr ghosts, byte ghostsToSkip)
		{
			vtkDataArray.vtkDataArray_GetRange_32(base.GetCppThis(), range, comp, ghosts, ghostsToSkip);
		}

		// Token: 0x0601DF52 RID: 122706
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetRange_33(HandleRef pThis, int comp);

		/// <summary>
		/// Return the range of the data array values for the given component. If
		/// comp is -1, return the range of the magnitude (L2 norm) over all
		/// components.The range is computed and then cached, and will not be
		/// re-computed on subsequent calls to GetRange() unless the array is
		/// modified or the requested component changes.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF53 RID: 122707 RVA: 0x002A4CD0 File Offset: 0x002A2ED0
		public double[] GetRange(int comp)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetRange_33(base.GetCppThis(), comp);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF54 RID: 122708
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetRange_34(HandleRef pThis);

		/// <summary>
		/// Return the range of the data array. If the array has multiple components,
		/// then this will return the range of only the first component (component
		/// zero). The range is computed and then cached, and will not be re-computed
		/// on subsequent calls to GetRange() unless the array is modified.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF55 RID: 122709 RVA: 0x002A4D1C File Offset: 0x002A2F1C
		public double[] GetRange()
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetRange_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF56 RID: 122710
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetRange_35(HandleRef pThis, IntPtr range);

		/// <summary>
		/// The range of the data array values will be returned in the provided
		/// range array argument. If the data array has multiple components, then
		/// this will return the range of only the first component (component zero).
		/// The range is computend and then cached, and will not be re-computed on
		/// subsequent calls to GetRange() unless the array is modified.
		/// THIS METHOD IS NOT THREAD SAFE.
		/// </summary>
		// Token: 0x0601DF57 RID: 122711 RVA: 0x002A4D64 File Offset: 0x002A2F64
		public void GetRange(IntPtr range)
		{
			vtkDataArray.vtkDataArray_GetRange_35(base.GetCppThis(), range);
		}

		// Token: 0x0601DF58 RID: 122712
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetTuple_36(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// Get the data tuple at tupleIdx. Return it as a pointer to an array.
		/// Note: this method is not thread-safe, and the pointer is only valid
		/// as long as another method invocation to a vtk object is not performed.
		/// </summary>
		// Token: 0x0601DF59 RID: 122713 RVA: 0x002A4D74 File Offset: 0x002A2F74
		public virtual IntPtr GetTuple(long tupleIdx)
		{
			return vtkDataArray.vtkDataArray_GetTuple_36(base.GetCppThis(), tupleIdx);
		}

		// Token: 0x0601DF5A RID: 122714
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetTuple_37(HandleRef pThis, long tupleIdx, IntPtr tuple);

		/// <summary>
		/// Get the data tuple at tupleIdx by filling in a user-provided array,
		/// Make sure that your array is large enough to hold the NumberOfComponents
		/// amount of data being returned.
		/// </summary>
		// Token: 0x0601DF5B RID: 122715 RVA: 0x002A4D94 File Offset: 0x002A2F94
		public virtual void GetTuple(long tupleIdx, IntPtr tuple)
		{
			vtkDataArray.vtkDataArray_GetTuple_37(base.GetCppThis(), tupleIdx, tuple);
		}

		// Token: 0x0601DF5C RID: 122716
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDataArray_GetTuple1_38(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF5D RID: 122717 RVA: 0x002A4DA8 File Offset: 0x002A2FA8
		public double GetTuple1(long tupleIdx)
		{
			return vtkDataArray.vtkDataArray_GetTuple1_38(base.GetCppThis(), tupleIdx);
		}

		// Token: 0x0601DF5E RID: 122718
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetTuple2_39(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF5F RID: 122719 RVA: 0x002A4DC8 File Offset: 0x002A2FC8
		public double[] GetTuple2(long tupleIdx)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple2_39(base.GetCppThis(), tupleIdx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF60 RID: 122720
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetTuple3_40(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF61 RID: 122721 RVA: 0x002A4E14 File Offset: 0x002A3014
		public double[] GetTuple3(long tupleIdx)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple3_40(base.GetCppThis(), tupleIdx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF62 RID: 122722
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetTuple4_41(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF63 RID: 122723 RVA: 0x002A4E60 File Offset: 0x002A3060
		public double[] GetTuple4(long tupleIdx)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple4_41(base.GetCppThis(), tupleIdx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF64 RID: 122724
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetTuple6_42(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF65 RID: 122725 RVA: 0x002A4EAC File Offset: 0x002A30AC
		public double[] GetTuple6(long tupleIdx)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple6_42(base.GetCppThis(), tupleIdx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF66 RID: 122726
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_GetTuple9_43(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF67 RID: 122727 RVA: 0x002A4EF8 File Offset: 0x002A30F8
		public double[] GetTuple9(long tupleIdx)
		{
			IntPtr intPtr = vtkDataArray.vtkDataArray_GetTuple9_43(base.GetCppThis(), tupleIdx);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[9];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601DF68 RID: 122728
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetTuples_44(HandleRef pThis, HandleRef tupleIds, HandleRef output);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF69 RID: 122729 RVA: 0x002A4F44 File Offset: 0x002A3144
		public override void GetTuples(vtkIdList tupleIds, vtkAbstractArray output)
		{
			vtkDataArray.vtkDataArray_GetTuples_44(base.GetCppThis(), (tupleIds == null) ? default(HandleRef) : tupleIds.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601DF6A RID: 122730
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_GetTuples_45(HandleRef pThis, long p1, long p2, HandleRef output);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF6B RID: 122731 RVA: 0x002A4F88 File Offset: 0x002A3188
		public override void GetTuples(long p1, long p2, vtkAbstractArray output)
		{
			vtkDataArray.vtkDataArray_GetTuples_45(base.GetCppThis(), p1, p2, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601DF6C RID: 122732
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertComponent_46(HandleRef pThis, long tupleIdx, int compIdx, double value);

		/// <summary>
		/// Insert value at the location specified by tupleIdx and compIdx.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601DF6D RID: 122733 RVA: 0x002A4FB9 File Offset: 0x002A31B9
		public virtual void InsertComponent(long tupleIdx, int compIdx, double value)
		{
			vtkDataArray.vtkDataArray_InsertComponent_46(base.GetCppThis(), tupleIdx, compIdx, value);
		}

		// Token: 0x0601DF6E RID: 122734
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArray_InsertNextTuple_47(HandleRef pThis, long srcTupleIdx, HandleRef source);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF6F RID: 122735 RVA: 0x002A4FCC File Offset: 0x002A31CC
		public override long InsertNextTuple(long srcTupleIdx, vtkAbstractArray source)
		{
			return vtkDataArray.vtkDataArray_InsertNextTuple_47(base.GetCppThis(), srcTupleIdx, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DF70 RID: 122736
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDataArray_InsertNextTuple_48(HandleRef pThis, IntPtr tuple);

		/// <summary>
		/// Insert the data tuple at the end of the array and return the tuple index at
		/// which the data was inserted. Memory is allocated as necessary to hold
		/// the data.
		/// </summary>
		// Token: 0x0601DF71 RID: 122737 RVA: 0x002A5004 File Offset: 0x002A3204
		public virtual long InsertNextTuple(IntPtr tuple)
		{
			return vtkDataArray.vtkDataArray_InsertNextTuple_48(base.GetCppThis(), tuple);
		}

		// Token: 0x0601DF72 RID: 122738
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertNextTuple1_49(HandleRef pThis, double value);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF73 RID: 122739 RVA: 0x002A5024 File Offset: 0x002A3224
		public void InsertNextTuple1(double value)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple1_49(base.GetCppThis(), value);
		}

		// Token: 0x0601DF74 RID: 122740
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertNextTuple2_50(HandleRef pThis, double val0, double val1);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF75 RID: 122741 RVA: 0x002A5034 File Offset: 0x002A3234
		public void InsertNextTuple2(double val0, double val1)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple2_50(base.GetCppThis(), val0, val1);
		}

		// Token: 0x0601DF76 RID: 122742
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertNextTuple3_51(HandleRef pThis, double val0, double val1, double val2);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF77 RID: 122743 RVA: 0x002A5045 File Offset: 0x002A3245
		public void InsertNextTuple3(double val0, double val1, double val2)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple3_51(base.GetCppThis(), val0, val1, val2);
		}

		// Token: 0x0601DF78 RID: 122744
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertNextTuple4_52(HandleRef pThis, double val0, double val1, double val2, double val3);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF79 RID: 122745 RVA: 0x002A5057 File Offset: 0x002A3257
		public void InsertNextTuple4(double val0, double val1, double val2, double val3)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple4_52(base.GetCppThis(), val0, val1, val2, val3);
		}

		// Token: 0x0601DF7A RID: 122746
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertNextTuple6_53(HandleRef pThis, double val0, double val1, double val2, double val3, double val4, double val5);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF7B RID: 122747 RVA: 0x002A506B File Offset: 0x002A326B
		public void InsertNextTuple6(double val0, double val1, double val2, double val3, double val4, double val5)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple6_53(base.GetCppThis(), val0, val1, val2, val3, val4, val5);
		}

		// Token: 0x0601DF7C RID: 122748
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertNextTuple9_54(HandleRef pThis, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF7D RID: 122749 RVA: 0x002A5084 File Offset: 0x002A3284
		public void InsertNextTuple9(double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
		{
			vtkDataArray.vtkDataArray_InsertNextTuple9_54(base.GetCppThis(), val0, val1, val2, val3, val4, val5, val6, val7, val8);
		}

		// Token: 0x0601DF7E RID: 122750
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple_55(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF7F RID: 122751 RVA: 0x002A50B0 File Offset: 0x002A32B0
		public override void InsertTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_InsertTuple_55(base.GetCppThis(), dstTupleIdx, srcTupleIdx, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DF80 RID: 122752
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple_56(HandleRef pThis, long tupleIdx, IntPtr tuple);

		/// <summary>
		/// Insert the data tuple at tupleIdx. Note that memory allocation
		/// is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601DF81 RID: 122753 RVA: 0x002A50E1 File Offset: 0x002A32E1
		public virtual void InsertTuple(long tupleIdx, IntPtr tuple)
		{
			vtkDataArray.vtkDataArray_InsertTuple_56(base.GetCppThis(), tupleIdx, tuple);
		}

		// Token: 0x0601DF82 RID: 122754
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple1_57(HandleRef pThis, long tupleIdx, double value);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF83 RID: 122755 RVA: 0x002A50F2 File Offset: 0x002A32F2
		public void InsertTuple1(long tupleIdx, double value)
		{
			vtkDataArray.vtkDataArray_InsertTuple1_57(base.GetCppThis(), tupleIdx, value);
		}

		// Token: 0x0601DF84 RID: 122756
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple2_58(HandleRef pThis, long tupleIdx, double val0, double val1);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF85 RID: 122757 RVA: 0x002A5103 File Offset: 0x002A3303
		public void InsertTuple2(long tupleIdx, double val0, double val1)
		{
			vtkDataArray.vtkDataArray_InsertTuple2_58(base.GetCppThis(), tupleIdx, val0, val1);
		}

		// Token: 0x0601DF86 RID: 122758
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple3_59(HandleRef pThis, long tupleIdx, double val0, double val1, double val2);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF87 RID: 122759 RVA: 0x002A5115 File Offset: 0x002A3315
		public void InsertTuple3(long tupleIdx, double val0, double val1, double val2)
		{
			vtkDataArray.vtkDataArray_InsertTuple3_59(base.GetCppThis(), tupleIdx, val0, val1, val2);
		}

		// Token: 0x0601DF88 RID: 122760
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple4_60(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF89 RID: 122761 RVA: 0x002A5129 File Offset: 0x002A3329
		public void InsertTuple4(long tupleIdx, double val0, double val1, double val2, double val3)
		{
			vtkDataArray.vtkDataArray_InsertTuple4_60(base.GetCppThis(), tupleIdx, val0, val1, val2, val3);
		}

		// Token: 0x0601DF8A RID: 122762
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple6_61(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF8B RID: 122763 RVA: 0x002A513F File Offset: 0x002A333F
		public void InsertTuple6(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
		{
			vtkDataArray.vtkDataArray_InsertTuple6_61(base.GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5);
		}

		// Token: 0x0601DF8C RID: 122764
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuple9_62(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// InsertTuple() which takes arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DF8D RID: 122765 RVA: 0x002A515C File Offset: 0x002A335C
		public void InsertTuple9(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
		{
			vtkDataArray.vtkDataArray_InsertTuple9_62(base.GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
		}

		// Token: 0x0601DF8E RID: 122766
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuples_63(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF8F RID: 122767 RVA: 0x002A5188 File Offset: 0x002A3388
		public override void InsertTuples(vtkIdList dstIds, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_InsertTuples_63(base.GetCppThis(), (dstIds == null) ? default(HandleRef) : dstIds.GetCppThis(), (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DF90 RID: 122768
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuples_64(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF91 RID: 122769 RVA: 0x002A51E4 File Offset: 0x002A33E4
		public override void InsertTuples(long dstStart, long n, long srcStart, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_InsertTuples_64(base.GetCppThis(), dstStart, n, srcStart, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DF92 RID: 122770
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InsertTuplesStartingAt_65(HandleRef pThis, long dstStart, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF93 RID: 122771 RVA: 0x002A5218 File Offset: 0x002A3418
		public override void InsertTuplesStartingAt(long dstStart, vtkIdList srcIds, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_InsertTuplesStartingAt_65(base.GetCppThis(), dstStart, (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DF94 RID: 122772
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InterpolateTuple_66(HandleRef pThis, long dstTupleIdx, HandleRef ptIndices, HandleRef source, IntPtr weights);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF95 RID: 122773 RVA: 0x002A5260 File Offset: 0x002A3460
		public override void InterpolateTuple(long dstTupleIdx, vtkIdList ptIndices, vtkAbstractArray source, IntPtr weights)
		{
			vtkDataArray.vtkDataArray_InterpolateTuple_66(base.GetCppThis(), dstTupleIdx, (ptIndices == null) ? default(HandleRef) : ptIndices.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis(), weights);
		}

		// Token: 0x0601DF96 RID: 122774
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_InterpolateTuple_67(HandleRef pThis, long dstTupleIdx, long srcTupleIdx1, HandleRef source1, long srcTupleIdx2, HandleRef source2, double t);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DF97 RID: 122775 RVA: 0x002A52A8 File Offset: 0x002A34A8
		public override void InterpolateTuple(long dstTupleIdx, long srcTupleIdx1, vtkAbstractArray source1, long srcTupleIdx2, vtkAbstractArray source2, double t)
		{
			vtkDataArray.vtkDataArray_InterpolateTuple_67(base.GetCppThis(), dstTupleIdx, srcTupleIdx1, (source1 == null) ? default(HandleRef) : source1.GetCppThis(), srcTupleIdx2, (source2 == null) ? default(HandleRef) : source2.GetCppThis(), t);
		}

		// Token: 0x0601DF98 RID: 122776
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArray_IsA_68(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DF99 RID: 122777 RVA: 0x002A52F4 File Offset: 0x002A34F4
		public override int IsA(string type)
		{
			return vtkDataArray.vtkDataArray_IsA_68(base.GetCppThis(), type);
		}

		// Token: 0x0601DF9A RID: 122778
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArray_IsNumeric_69(HandleRef pThis);

		/// <summary>
		/// This method is here to make backward compatibility easier.  It
		/// must return true if and only if an array contains numeric data.
		/// All vtkDataArray subclasses contain numeric data, hence this method
		/// always returns 1(true).
		/// </summary>
		// Token: 0x0601DF9B RID: 122779 RVA: 0x002A5314 File Offset: 0x002A3514
		public override int IsNumeric()
		{
			return vtkDataArray.vtkDataArray_IsNumeric_69(base.GetCppThis());
		}

		// Token: 0x0601DF9C RID: 122780
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDataArray_IsTypeOf_70([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DF9D RID: 122781 RVA: 0x002A5334 File Offset: 0x002A3534
		public new static int IsTypeOf(string type)
		{
			return vtkDataArray.vtkDataArray_IsTypeOf_70(type);
		}

		// Token: 0x0601DF9E RID: 122782
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_L2_NORM_FINITE_RANGE_71(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is used to hold tight bounds on the $L_2$ norm
		/// of tuples in the array.
		/// Two values (a minimum and maximum) are stored for each component.
		/// When GetFiniteRange() is called when no tuples are present in the array
		/// this value is set to { VTK_DOUBLE_MAX, VTK_DOUBLE_MIN }.
		/// </summary>
		// Token: 0x0601DF9F RID: 122783 RVA: 0x002A5350 File Offset: 0x002A3550
		public static vtkInformationDoubleVectorKey L2_NORM_FINITE_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_L2_NORM_FINITE_RANGE_71(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601DFA0 RID: 122784
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_L2_NORM_RANGE_72(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This key is used to hold tight bounds on the $L_2$ norm
		/// of tuples in the array.
		/// Two values (a minimum and maximum) are stored for each component.
		/// When GetRange() is called when no tuples are present in the array
		/// this value is set to { VTK_DOUBLE_MAX, VTK_DOUBLE_MIN }.
		/// </summary>
		// Token: 0x0601DFA1 RID: 122785 RVA: 0x002A53BC File Offset: 0x002A35BC
		public static vtkInformationDoubleVectorKey L2_NORM_RANGE()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_L2_NORM_RANGE_72(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601DFA2 RID: 122786
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_Modified_73(HandleRef pThis);

		/// <summary>
		/// Removes out-of-date L2_NORM_RANGE() and L2_NORM_FINITE_RANGE() values.
		/// </summary>
		// Token: 0x0601DFA3 RID: 122787 RVA: 0x002A5425 File Offset: 0x002A3625
		public override void Modified()
		{
			vtkDataArray.vtkDataArray_Modified_73(base.GetCppThis());
		}

		// Token: 0x0601DFA4 RID: 122788
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFA5 RID: 122789 RVA: 0x002A5434 File Offset: 0x002A3634
		public new vtkDataArray NewInstance()
		{
			vtkDataArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_NewInstance_74(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DFA6 RID: 122790
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_RemoveFirstTuple_75(HandleRef pThis);

		/// <summary>
		/// These methods remove tuples from the data array. They shift data and
		/// resize array, so the data array is still valid after this operation. Note,
		/// this operation is fairly slow.
		/// </summary>
		// Token: 0x0601DFA7 RID: 122791 RVA: 0x002A548E File Offset: 0x002A368E
		public virtual void RemoveFirstTuple()
		{
			vtkDataArray.vtkDataArray_RemoveFirstTuple_75(base.GetCppThis());
		}

		// Token: 0x0601DFA8 RID: 122792
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_RemoveLastTuple_76(HandleRef pThis);

		/// <summary>
		/// These methods remove tuples from the data array. They shift data and
		/// resize array, so the data array is still valid after this operation. Note,
		/// this operation is fairly slow.
		/// </summary>
		// Token: 0x0601DFA9 RID: 122793 RVA: 0x002A549D File Offset: 0x002A369D
		public virtual void RemoveLastTuple()
		{
			vtkDataArray.vtkDataArray_RemoveLastTuple_76(base.GetCppThis());
		}

		// Token: 0x0601DFAA RID: 122794
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_RemoveTuple_77(HandleRef pThis, long tupleIdx);

		/// <summary>
		/// These methods remove tuples from the data array. They shift data and
		/// resize array, so the data array is still valid after this operation. Note,
		/// this operation is fairly slow.
		/// </summary>
		// Token: 0x0601DFAB RID: 122795 RVA: 0x002A54AC File Offset: 0x002A36AC
		public virtual void RemoveTuple(long tupleIdx)
		{
			vtkDataArray.vtkDataArray_RemoveTuple_77(base.GetCppThis(), tupleIdx);
		}

		// Token: 0x0601DFAC RID: 122796
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_SafeDownCast_78(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFAD RID: 122797 RVA: 0x002A54BC File Offset: 0x002A36BC
		public new static vtkDataArray SafeDownCast(vtkObjectBase o)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_SafeDownCast_78((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DFAE RID: 122798
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetComponent_79(HandleRef pThis, long tupleIdx, int compIdx, double value);

		/// <summary>
		/// Set the data component at the location specified by tupleIdx and compIdx
		/// to value.
		/// Note that i is less than NumberOfTuples and j is less than
		/// NumberOfComponents. Make sure enough memory has been allocated
		/// (use SetNumberOfTuples() and SetNumberOfComponents()).
		/// </summary>
		// Token: 0x0601DFAF RID: 122799 RVA: 0x002A553B File Offset: 0x002A373B
		public virtual void SetComponent(long tupleIdx, int compIdx, double value)
		{
			vtkDataArray.vtkDataArray_SetComponent_79(base.GetCppThis(), tupleIdx, compIdx, value);
		}

		// Token: 0x0601DFB0 RID: 122800
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetLookupTable_80(HandleRef pThis, HandleRef lut);

		/// <summary>
		/// Set/get the lookup table associated with this scalar data, if any.
		/// </summary>
		// Token: 0x0601DFB1 RID: 122801 RVA: 0x002A5550 File Offset: 0x002A3750
		public void SetLookupTable(vtkLookupTable lut)
		{
			vtkDataArray.vtkDataArray_SetLookupTable_80(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		// Token: 0x0601DFB2 RID: 122802
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple_81(HandleRef pThis, long dstTupleIdx, long srcTupleIdx, HandleRef source);

		/// <summary>
		/// See documentation from parent class.
		/// This method assumes that the `source` inherits from `vtkDataArray`, but its value type doesn't
		/// have to match the type of the current instance.
		/// </summary>
		// Token: 0x0601DFB3 RID: 122803 RVA: 0x002A5580 File Offset: 0x002A3780
		public override void SetTuple(long dstTupleIdx, long srcTupleIdx, vtkAbstractArray source)
		{
			vtkDataArray.vtkDataArray_SetTuple_81(base.GetCppThis(), dstTupleIdx, srcTupleIdx, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601DFB4 RID: 122804
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple_82(HandleRef pThis, long tupleIdx, IntPtr tuple);

		/// <summary>
		/// Set the data tuple at tupleIdx. Note that range checking or
		/// memory allocation is not performed; use this method in conjunction
		/// with SetNumberOfTuples() to allocate space.
		/// </summary>
		// Token: 0x0601DFB5 RID: 122805 RVA: 0x002A55B1 File Offset: 0x002A37B1
		public virtual void SetTuple(long tupleIdx, IntPtr tuple)
		{
			vtkDataArray.vtkDataArray_SetTuple_82(base.GetCppThis(), tupleIdx, tuple);
		}

		// Token: 0x0601DFB6 RID: 122806
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple1_83(HandleRef pThis, long tupleIdx, double value);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DFB7 RID: 122807 RVA: 0x002A55C2 File Offset: 0x002A37C2
		public void SetTuple1(long tupleIdx, double value)
		{
			vtkDataArray.vtkDataArray_SetTuple1_83(base.GetCppThis(), tupleIdx, value);
		}

		// Token: 0x0601DFB8 RID: 122808
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple2_84(HandleRef pThis, long tupleIdx, double val0, double val1);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DFB9 RID: 122809 RVA: 0x002A55D3 File Offset: 0x002A37D3
		public void SetTuple2(long tupleIdx, double val0, double val1)
		{
			vtkDataArray.vtkDataArray_SetTuple2_84(base.GetCppThis(), tupleIdx, val0, val1);
		}

		// Token: 0x0601DFBA RID: 122810
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple3_85(HandleRef pThis, long tupleIdx, double val0, double val1, double val2);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DFBB RID: 122811 RVA: 0x002A55E5 File Offset: 0x002A37E5
		public void SetTuple3(long tupleIdx, double val0, double val1, double val2)
		{
			vtkDataArray.vtkDataArray_SetTuple3_85(base.GetCppThis(), tupleIdx, val0, val1, val2);
		}

		// Token: 0x0601DFBC RID: 122812
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple4_86(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DFBD RID: 122813 RVA: 0x002A55F9 File Offset: 0x002A37F9
		public void SetTuple4(long tupleIdx, double val0, double val1, double val2, double val3)
		{
			vtkDataArray.vtkDataArray_SetTuple4_86(base.GetCppThis(), tupleIdx, val0, val1, val2, val3);
		}

		// Token: 0x0601DFBE RID: 122814
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple6_87(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DFBF RID: 122815 RVA: 0x002A560F File Offset: 0x002A380F
		public void SetTuple6(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5)
		{
			vtkDataArray.vtkDataArray_SetTuple6_87(base.GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5);
		}

		// Token: 0x0601DFC0 RID: 122816
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_SetTuple9_88(HandleRef pThis, long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8);

		/// <summary>
		/// These methods are included as convenience for the wrappers.
		/// GetTuple() and SetTuple() which return/take arrays can not be
		/// used from wrapped languages. These methods can be used instead.
		/// </summary>
		// Token: 0x0601DFC1 RID: 122817 RVA: 0x002A562C File Offset: 0x002A382C
		public void SetTuple9(long tupleIdx, double val0, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8)
		{
			vtkDataArray.vtkDataArray_SetTuple9_88(base.GetCppThis(), tupleIdx, val0, val1, val2, val3, val4, val5, val6, val7, val8);
		}

		// Token: 0x0601DFC2 RID: 122818
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDataArray_ShallowCopy_89(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Create a shallow copy of other into this, if possible. Shallow copies are
		/// only possible:
		/// (a) if both arrays are the same data type
		/// (b) if both arrays are the same array type (e.g. AOS vs. SOA)
		/// (c) if both arrays support shallow copies (e.g. vtkBitArray currently
		/// does not.)
		/// If a shallow copy is not possible, a deep copy will be performed instead.
		/// </summary>
		// Token: 0x0601DFC3 RID: 122819 RVA: 0x002A5658 File Offset: 0x002A3858
		public virtual void ShallowCopy(vtkDataArray other)
		{
			vtkDataArray.vtkDataArray_ShallowCopy_89(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601DFC4 RID: 122820
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_UNITS_LABEL_90(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A human-readable string indicating the units for the array data.
		/// </summary>
		// Token: 0x0601DFC5 RID: 122821 RVA: 0x002A5688 File Offset: 0x002A3888
		public static vtkInformationStringKey UNITS_LABEL()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDataArray.vtkDataArray_UNITS_LABEL_90(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601DFC6 RID: 122822
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDataArray_WriteVoidPointer_91(HandleRef pThis, long valueIdx, long numValues);

		/// <summary>
		/// Get the address of a particular data index. Make sure data is allocated
		/// for the number of items requested. If needed, increase MaxId to mark any
		/// new value ranges as in-use.
		/// </summary>
		// Token: 0x0601DFC7 RID: 122823 RVA: 0x002A56F4 File Offset: 0x002A38F4
		public virtual IntPtr WriteVoidPointer(long valueIdx, long numValues)
		{
			return vtkDataArray.vtkDataArray_WriteVoidPointer_91(base.GetCppThis(), valueIdx, numValues);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F9F RID: 8095
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA0 RID: 8096
		public new static readonly string MRClassNameKey = "class vtkDataArray";
	}
}
