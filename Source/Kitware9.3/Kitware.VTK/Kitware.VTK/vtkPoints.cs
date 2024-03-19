using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPoints
	/// </summary>
	/// <remarks>
	///    represent and manipulate 3D points
	///
	/// vtkPoints represents 3D points. The data model for vtkPoints is an
	/// array of vx-vy-vz triplets accessible by (point or cell) id.
	/// </remarks>
	// Token: 0x02000A9D RID: 2717
	public class vtkPoints : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C7D9 RID: 116697 RVA: 0x00280677 File Offset: 0x0027E877
		static vtkPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C7DA RID: 116698 RVA: 0x0028069F File Offset: 0x0027E89F
		public vtkPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C7DB RID: 116699
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7DC RID: 116700 RVA: 0x002806B0 File Offset: 0x0027E8B0
		public new static vtkPoints New()
		{
			vtkPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints.vtkPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7DD RID: 116701 RVA: 0x00280704 File Offset: 0x0027E904
		public vtkPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPoints.vtkPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C7DE RID: 116702 RVA: 0x00280748 File Offset: 0x0027E948
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C7DF RID: 116703
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate initial memory size. ext is no longer used.
		/// </summary>
		// Token: 0x0601C7E0 RID: 116704 RVA: 0x00280754 File Offset: 0x0027E954
		public virtual int Allocate(long sz, long ext)
		{
			return vtkPoints.vtkPoints_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601C7E1 RID: 116705
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_ComputeBounds_02(HandleRef pThis);

		/// <summary>
		/// Determine (xmin,xmax, ymin,ymax, zmin,zmax) bounds of points.
		/// </summary>
		// Token: 0x0601C7E2 RID: 116706 RVA: 0x00280775 File Offset: 0x0027E975
		public virtual void ComputeBounds()
		{
			vtkPoints.vtkPoints_ComputeBounds_02(base.GetCppThis());
		}

		// Token: 0x0601C7E3 RID: 116707
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_DeepCopy_03(HandleRef pThis, HandleRef ad);

		/// <summary>
		/// Different ways to copy data. Shallow copy does reference count (i.e.,
		/// assigns pointers and updates reference count); deep copy runs through
		/// entire data array assigning values.
		/// </summary>
		// Token: 0x0601C7E4 RID: 116708 RVA: 0x00280784 File Offset: 0x0027E984
		public virtual void DeepCopy(vtkPoints ad)
		{
			vtkPoints.vtkPoints_DeepCopy_03(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		// Token: 0x0601C7E5 RID: 116709
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPoints_GetActualMemorySize_04(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this attribute data.
		/// Used to support streaming and reading/writing data. The value
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to actually represent the data represented
		/// by this object. The information returned is valid only after
		/// the pipeline has been updated.
		/// </summary>
		// Token: 0x0601C7E6 RID: 116710 RVA: 0x002807B4 File Offset: 0x0027E9B4
		public uint GetActualMemorySize()
		{
			return vtkPoints.vtkPoints_GetActualMemorySize_04(base.GetCppThis());
		}

		// Token: 0x0601C7E7 RID: 116711
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Return the bounds of the points.
		/// </summary>
		// Token: 0x0601C7E8 RID: 116712 RVA: 0x002807D4 File Offset: 0x0027E9D4
		public double[] GetBounds()
		{
			IntPtr intPtr = vtkPoints.vtkPoints_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C7E9 RID: 116713
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_GetBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return the bounds of the points.
		/// </summary>
		// Token: 0x0601C7EA RID: 116714 RVA: 0x0028081C File Offset: 0x0027EA1C
		public void GetBounds(IntPtr bounds)
		{
			vtkPoints.vtkPoints_GetBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x0601C7EB RID: 116715
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the underlying data array. This function must be implemented
		/// in a concrete subclass to check for consistency. (The tuple size must
		/// match the type of data. For example, 3-tuple data array can be assigned to
		/// a vector, normal, or points object, but not a tensor object, which has a
		/// tuple dimension of 9. Scalars, on the other hand, can have tuple dimension
		/// from 1-4, depending on the type of scalar.)
		/// </summary>
		// Token: 0x0601C7EC RID: 116716 RVA: 0x0028082C File Offset: 0x0027EA2C
		public vtkDataArray GetData()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints.vtkPoints_GetData_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601C7ED RID: 116717
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints_GetDataType_08(HandleRef pThis);

		/// <summary>
		/// Return the underlying data type. An integer indicating data type is
		/// returned as specified in vtkSetGet.h.
		/// </summary>
		// Token: 0x0601C7EE RID: 116718 RVA: 0x0028089C File Offset: 0x0027EA9C
		public virtual int GetDataType()
		{
			return vtkPoints.vtkPoints_GetDataType_08(base.GetCppThis());
		}

		// Token: 0x0601C7EF RID: 116719
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPoints_GetMTime_09(HandleRef pThis);

		/// <summary>
		/// The modified time of the points.
		/// </summary>
		// Token: 0x0601C7F0 RID: 116720 RVA: 0x002808BC File Offset: 0x0027EABC
		public override ulong GetMTime()
		{
			return vtkPoints.vtkPoints_GetMTime_09(base.GetCppThis());
		}

		// Token: 0x0601C7F1 RID: 116721
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7F2 RID: 116722 RVA: 0x002808DC File Offset: 0x0027EADC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPoints.vtkPoints_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0601C7F3 RID: 116723
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C7F4 RID: 116724 RVA: 0x002808FC File Offset: 0x0027EAFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPoints.vtkPoints_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0601C7F5 RID: 116725
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints_GetNumberOfPoints_12(HandleRef pThis);

		/// <summary>
		/// Return number of points in array.
		/// </summary>
		// Token: 0x0601C7F6 RID: 116726 RVA: 0x00280918 File Offset: 0x0027EB18
		public long GetNumberOfPoints()
		{
			return vtkPoints.vtkPoints_GetNumberOfPoints_12(base.GetCppThis());
		}

		// Token: 0x0601C7F7 RID: 116727
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_GetPoint_13(HandleRef pThis, long id);

		/// <summary>
		/// Return a pointer to a double point x[3] for a specific id.
		/// WARNING: Just don't use this error-prone method, the returned pointer
		/// and its values are only valid as long as another method invocation is not
		/// performed. Prefer GetPoint() with the return value in argument.
		/// </summary>
		// Token: 0x0601C7F8 RID: 116728 RVA: 0x00280938 File Offset: 0x0027EB38
		public double[] GetPoint(long id)
		{
			IntPtr intPtr = vtkPoints.vtkPoints_GetPoint_13(base.GetCppThis(), id);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C7F9 RID: 116729
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_GetPoint_14(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Copy point components into user provided array v[3] for specified
		/// id.
		/// </summary>
		// Token: 0x0601C7FA RID: 116730 RVA: 0x00280981 File Offset: 0x0027EB81
		public void GetPoint(long id, IntPtr x)
		{
			vtkPoints.vtkPoints_GetPoint_14(base.GetCppThis(), id, x);
		}

		// Token: 0x0601C7FB RID: 116731
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_GetPoints_15(HandleRef pThis, HandleRef ptId, HandleRef outPoints);

		/// <summary>
		/// Given a list of pt ids, return an array of points.
		/// </summary>
		// Token: 0x0601C7FC RID: 116732 RVA: 0x00280994 File Offset: 0x0027EB94
		public void GetPoints(vtkIdList ptId, vtkPoints outPoints)
		{
			vtkPoints.vtkPoints_GetPoints_15(base.GetCppThis(), (ptId == null) ? default(HandleRef) : ptId.GetCppThis(), (outPoints == null) ? default(HandleRef) : outPoints.GetCppThis());
		}

		// Token: 0x0601C7FD RID: 116733
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_GetVoidPointer_16(HandleRef pThis, int id);

		/// <summary>
		/// Return a void pointer. For image pipeline interface and other
		/// special pointer manipulation.
		/// </summary>
		// Token: 0x0601C7FE RID: 116734 RVA: 0x002809D8 File Offset: 0x0027EBD8
		public IntPtr GetVoidPointer(int id)
		{
			return vtkPoints.vtkPoints_GetVoidPointer_16(base.GetCppThis(), id);
		}

		// Token: 0x0601C7FF RID: 116735
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_Initialize_17(HandleRef pThis);

		/// <summary>
		/// Return object to instantiated state.
		/// </summary>
		// Token: 0x0601C800 RID: 116736 RVA: 0x002809F8 File Offset: 0x0027EBF8
		public virtual void Initialize()
		{
			vtkPoints.vtkPoints_Initialize_17(base.GetCppThis());
		}

		// Token: 0x0601C801 RID: 116737
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints_InsertNextPoint_18(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Insert point into next available slot. Returns id of slot.
		/// </summary>
		// Token: 0x0601C802 RID: 116738 RVA: 0x00280A08 File Offset: 0x0027EC08
		public long InsertNextPoint(IntPtr x)
		{
			return vtkPoints.vtkPoints_InsertNextPoint_18(base.GetCppThis(), x);
		}

		// Token: 0x0601C803 RID: 116739
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints_InsertNextPoint_19(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Insert point into next available slot. Returns id of slot.
		/// </summary>
		// Token: 0x0601C804 RID: 116740 RVA: 0x00280A28 File Offset: 0x0027EC28
		public long InsertNextPoint(double x, double y, double z)
		{
			return vtkPoints.vtkPoints_InsertNextPoint_19(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601C805 RID: 116741
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_InsertPoint_20(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Insert point into object. Range checking performed and memory
		/// allocated as necessary.
		/// </summary>
		// Token: 0x0601C806 RID: 116742 RVA: 0x00280A4A File Offset: 0x0027EC4A
		public void InsertPoint(long id, IntPtr x)
		{
			vtkPoints.vtkPoints_InsertPoint_20(base.GetCppThis(), id, x);
		}

		// Token: 0x0601C807 RID: 116743
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_InsertPoint_21(HandleRef pThis, long id, double x, double y, double z);

		/// <summary>
		/// Insert point into object. Range checking performed and memory
		/// allocated as necessary.
		/// </summary>
		// Token: 0x0601C808 RID: 116744 RVA: 0x00280A5B File Offset: 0x0027EC5B
		public void InsertPoint(long id, double x, double y, double z)
		{
			vtkPoints.vtkPoints_InsertPoint_21(base.GetCppThis(), id, x, y, z);
		}

		// Token: 0x0601C809 RID: 116745
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_InsertPoints_22(HandleRef pThis, HandleRef dstIds, HandleRef srcIds, HandleRef source);

		/// <summary>
		/// Copy the points indexed in srcIds from the source array to the tuple
		/// locations indexed by dstIds in this array.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601C80A RID: 116746 RVA: 0x00280A70 File Offset: 0x0027EC70
		public void InsertPoints(vtkIdList dstIds, vtkIdList srcIds, vtkPoints source)
		{
			vtkPoints.vtkPoints_InsertPoints_22(base.GetCppThis(), (dstIds == null) ? default(HandleRef) : dstIds.GetCppThis(), (srcIds == null) ? default(HandleRef) : srcIds.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601C80B RID: 116747
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_InsertPoints_23(HandleRef pThis, long dstStart, long n, long srcStart, HandleRef source);

		/// <summary>
		/// Copy n consecutive points starting at srcStart from the source array to
		/// this array, starting at the dstStart location.
		/// Note that memory allocation is performed as necessary to hold the data.
		/// </summary>
		// Token: 0x0601C80C RID: 116748 RVA: 0x00280ACC File Offset: 0x0027ECCC
		public void InsertPoints(long dstStart, long n, long srcStart, vtkPoints source)
		{
			vtkPoints.vtkPoints_InsertPoints_23(base.GetCppThis(), dstStart, n, srcStart, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		// Token: 0x0601C80D RID: 116749
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints_IsA_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C80E RID: 116750 RVA: 0x00280B00 File Offset: 0x0027ED00
		public override int IsA(string type)
		{
			return vtkPoints.vtkPoints_IsA_24(base.GetCppThis(), type);
		}

		// Token: 0x0601C80F RID: 116751
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints_IsTypeOf_25([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C810 RID: 116752 RVA: 0x00280B20 File Offset: 0x0027ED20
		public new static int IsTypeOf(string type)
		{
			return vtkPoints.vtkPoints_IsTypeOf_25(type);
		}

		// Token: 0x0601C811 RID: 116753
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_Modified_26(HandleRef pThis);

		/// <summary>
		/// Update the modification time for this object and its Data.
		/// As this object acts as a shell around a DataArray and
		/// forwards Set methods it needs to forward Modified as well.
		/// </summary>
		// Token: 0x0601C812 RID: 116754 RVA: 0x00280B3A File Offset: 0x0027ED3A
		public override void Modified()
		{
			vtkPoints.vtkPoints_Modified_26(base.GetCppThis());
		}

		// Token: 0x0601C813 RID: 116755
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_New_27(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C814 RID: 116756 RVA: 0x00280B4C File Offset: 0x0027ED4C
		public static vtkPoints New(int dataType)
		{
			vtkPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints.vtkPoints_New_27(dataType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C815 RID: 116757
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C816 RID: 116758 RVA: 0x00280BA4 File Offset: 0x0027EDA4
		public new vtkPoints NewInstance()
		{
			vtkPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints.vtkPoints_NewInstance_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C817 RID: 116759
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_Reset_30(HandleRef pThis);

		/// <summary>
		/// Make object look empty but do not delete memory.
		/// </summary>
		// Token: 0x0601C818 RID: 116760 RVA: 0x00280BFE File Offset: 0x0027EDFE
		public virtual void Reset()
		{
			vtkPoints.vtkPoints_Reset_30(base.GetCppThis());
		}

		// Token: 0x0601C819 RID: 116761
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints_Resize_31(HandleRef pThis, long numPoints);

		/// <summary>
		/// Resize the internal array while conserving the data.  Returns 1 if
		/// resizing succeeded and 0 otherwise.
		/// </summary>
		// Token: 0x0601C81A RID: 116762 RVA: 0x00280C10 File Offset: 0x0027EE10
		public int Resize(long numPoints)
		{
			return vtkPoints.vtkPoints_Resize_31(base.GetCppThis(), numPoints);
		}

		// Token: 0x0601C81B RID: 116763
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C81C RID: 116764 RVA: 0x00280C30 File Offset: 0x0027EE30
		public new static vtkPoints SafeDownCast(vtkObjectBase o)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints.vtkPoints_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601C81D RID: 116765
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetData_33(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the underlying data array. This function must be implemented
		/// in a concrete subclass to check for consistency. (The tuple size must
		/// match the type of data. For example, 3-tuple data array can be assigned to
		/// a vector, normal, or points object, but not a tensor object, which has a
		/// tuple dimension of 9. Scalars, on the other hand, can have tuple dimension
		/// from 1-4, depending on the type of scalar.)
		/// </summary>
		// Token: 0x0601C81E RID: 116766 RVA: 0x00280CB0 File Offset: 0x0027EEB0
		public virtual void SetData(vtkDataArray arg0)
		{
			vtkPoints.vtkPoints_SetData_33(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601C81F RID: 116767
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataType_34(HandleRef pThis, int dataType);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C820 RID: 116768 RVA: 0x00280CDF File Offset: 0x0027EEDF
		public virtual void SetDataType(int dataType)
		{
			vtkPoints.vtkPoints_SetDataType_34(base.GetCppThis(), dataType);
		}

		// Token: 0x0601C821 RID: 116769
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToBit_35(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C822 RID: 116770 RVA: 0x00280CEF File Offset: 0x0027EEEF
		public void SetDataTypeToBit()
		{
			vtkPoints.vtkPoints_SetDataTypeToBit_35(base.GetCppThis());
		}

		// Token: 0x0601C823 RID: 116771
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToChar_36(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C824 RID: 116772 RVA: 0x00280CFE File Offset: 0x0027EEFE
		public void SetDataTypeToChar()
		{
			vtkPoints.vtkPoints_SetDataTypeToChar_36(base.GetCppThis());
		}

		// Token: 0x0601C825 RID: 116773
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToDouble_37(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C826 RID: 116774 RVA: 0x00280D0D File Offset: 0x0027EF0D
		public void SetDataTypeToDouble()
		{
			vtkPoints.vtkPoints_SetDataTypeToDouble_37(base.GetCppThis());
		}

		// Token: 0x0601C827 RID: 116775
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToFloat_38(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C828 RID: 116776 RVA: 0x00280D1C File Offset: 0x0027EF1C
		public void SetDataTypeToFloat()
		{
			vtkPoints.vtkPoints_SetDataTypeToFloat_38(base.GetCppThis());
		}

		// Token: 0x0601C829 RID: 116777
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToInt_39(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C82A RID: 116778 RVA: 0x00280D2B File Offset: 0x0027EF2B
		public void SetDataTypeToInt()
		{
			vtkPoints.vtkPoints_SetDataTypeToInt_39(base.GetCppThis());
		}

		// Token: 0x0601C82B RID: 116779
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToLong_40(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C82C RID: 116780 RVA: 0x00280D3A File Offset: 0x0027EF3A
		public void SetDataTypeToLong()
		{
			vtkPoints.vtkPoints_SetDataTypeToLong_40(base.GetCppThis());
		}

		// Token: 0x0601C82D RID: 116781
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToShort_41(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C82E RID: 116782 RVA: 0x00280D49 File Offset: 0x0027EF49
		public void SetDataTypeToShort()
		{
			vtkPoints.vtkPoints_SetDataTypeToShort_41(base.GetCppThis());
		}

		// Token: 0x0601C82F RID: 116783
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToUnsignedChar_42(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C830 RID: 116784 RVA: 0x00280D58 File Offset: 0x0027EF58
		public void SetDataTypeToUnsignedChar()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedChar_42(base.GetCppThis());
		}

		// Token: 0x0601C831 RID: 116785
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToUnsignedInt_43(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C832 RID: 116786 RVA: 0x00280D67 File Offset: 0x0027EF67
		public void SetDataTypeToUnsignedInt()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedInt_43(base.GetCppThis());
		}

		// Token: 0x0601C833 RID: 116787
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToUnsignedLong_44(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C834 RID: 116788 RVA: 0x00280D76 File Offset: 0x0027EF76
		public void SetDataTypeToUnsignedLong()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedLong_44(base.GetCppThis());
		}

		// Token: 0x0601C835 RID: 116789
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetDataTypeToUnsignedShort_45(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// Default is VTK_FLOAT.
		/// </summary>
		// Token: 0x0601C836 RID: 116790 RVA: 0x00280D85 File Offset: 0x0027EF85
		public void SetDataTypeToUnsignedShort()
		{
			vtkPoints.vtkPoints_SetDataTypeToUnsignedShort_45(base.GetCppThis());
		}

		// Token: 0x0601C837 RID: 116791
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetNumberOfPoints_46(HandleRef pThis, long numPoints);

		/// <summary>
		/// Specify the number of points for this object to hold. Does an
		/// allocation as well as setting the MaxId ivar. Used in conjunction with
		/// SetPoint() method for fast insertion.
		/// </summary>
		// Token: 0x0601C838 RID: 116792 RVA: 0x00280D94 File Offset: 0x0027EF94
		public void SetNumberOfPoints(long numPoints)
		{
			vtkPoints.vtkPoints_SetNumberOfPoints_46(base.GetCppThis(), numPoints);
		}

		// Token: 0x0601C839 RID: 116793
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetPoint_47(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Insert point into object. No range checking performed (fast!).
		/// Make sure you use SetNumberOfPoints() to allocate memory prior
		/// to using SetPoint(). You should call Modified() finally after
		/// changing points using this method as it will not do it itself.
		/// </summary>
		// Token: 0x0601C83A RID: 116794 RVA: 0x00280DA4 File Offset: 0x0027EFA4
		public void SetPoint(long id, IntPtr x)
		{
			vtkPoints.vtkPoints_SetPoint_47(base.GetCppThis(), id, x);
		}

		// Token: 0x0601C83B RID: 116795
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_SetPoint_48(HandleRef pThis, long id, double x, double y, double z);

		/// <summary>
		/// Insert point into object. No range checking performed (fast!).
		/// Make sure you use SetNumberOfPoints() to allocate memory prior
		/// to using SetPoint(). You should call Modified() finally after
		/// changing points using this method as it will not do it itself.
		/// </summary>
		// Token: 0x0601C83C RID: 116796 RVA: 0x00280DB5 File Offset: 0x0027EFB5
		public void SetPoint(long id, double x, double y, double z)
		{
			vtkPoints.vtkPoints_SetPoint_48(base.GetCppThis(), id, x, y, z);
		}

		// Token: 0x0601C83D RID: 116797
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_ShallowCopy_49(HandleRef pThis, HandleRef ad);

		/// <summary>
		/// Different ways to copy data. Shallow copy does reference count (i.e.,
		/// assigns pointers and updates reference count); deep copy runs through
		/// entire data array assigning values.
		/// </summary>
		// Token: 0x0601C83E RID: 116798 RVA: 0x00280DCC File Offset: 0x0027EFCC
		public virtual void ShallowCopy(vtkPoints ad)
		{
			vtkPoints.vtkPoints_ShallowCopy_49(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		// Token: 0x0601C83F RID: 116799
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints_Squeeze_50(HandleRef pThis);

		/// <summary>
		/// Reclaim any extra memory.
		/// </summary>
		// Token: 0x0601C840 RID: 116800 RVA: 0x00280DFB File Offset: 0x0027EFFB
		public virtual void Squeeze()
		{
			vtkPoints.vtkPoints_Squeeze_50(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E3B RID: 7739
		public new const string MRFullTypeName = "Kitware.VTK.vtkPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E3C RID: 7740
		public new static readonly string MRClassNameKey = "class vtkPoints";
	}
}
