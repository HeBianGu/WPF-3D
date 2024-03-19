using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPoints2D
	/// </summary>
	/// <remarks>
	///    represent and manipulate 2D points
	///
	/// vtkPoints2D represents 2D points. The data model for vtkPoints2D is an
	/// array of vx-vy doublets accessible by (point or cell) id.
	/// </remarks>
	// Token: 0x02000B79 RID: 2937
	public class vtkPoints2D : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EA41 RID: 125505 RVA: 0x002B756F File Offset: 0x002B576F
		static vtkPoints2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPoints2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoints2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EA42 RID: 125506 RVA: 0x002B7597 File Offset: 0x002B5797
		public vtkPoints2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EA43 RID: 125507
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA44 RID: 125508 RVA: 0x002B75A8 File Offset: 0x002B57A8
		public new static vtkPoints2D New()
		{
			vtkPoints2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA45 RID: 125509 RVA: 0x002B75FC File Offset: 0x002B57FC
		public vtkPoints2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPoints2D.vtkPoints2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EA46 RID: 125510 RVA: 0x002B7640 File Offset: 0x002B5840
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EA47 RID: 125511
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints2D_Allocate_01(HandleRef pThis, long sz, long ext);

		/// <summary>
		/// Allocate initial memory size. ext is no longer used.
		/// </summary>
		// Token: 0x0601EA48 RID: 125512 RVA: 0x002B764C File Offset: 0x002B584C
		public virtual int Allocate(long sz, long ext)
		{
			return vtkPoints2D.vtkPoints2D_Allocate_01(base.GetCppThis(), sz, ext);
		}

		// Token: 0x0601EA49 RID: 125513
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_ComputeBounds_02(HandleRef pThis);

		/// <summary>
		/// Determine (xmin,xmax, ymin,ymax) bounds of points.
		/// </summary>
		// Token: 0x0601EA4A RID: 125514 RVA: 0x002B766D File Offset: 0x002B586D
		public virtual void ComputeBounds()
		{
			vtkPoints2D.vtkPoints2D_ComputeBounds_02(base.GetCppThis());
		}

		// Token: 0x0601EA4B RID: 125515
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_DeepCopy_03(HandleRef pThis, HandleRef ad);

		/// <summary>
		/// Different ways to copy data. Shallow copy does reference count (i.e.,
		/// assigns pointers and updates reference count); deep copy runs through
		/// entire data array assigning values.
		/// </summary>
		// Token: 0x0601EA4C RID: 125516 RVA: 0x002B767C File Offset: 0x002B587C
		public virtual void DeepCopy(vtkPoints2D ad)
		{
			vtkPoints2D.vtkPoints2D_DeepCopy_03(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		// Token: 0x0601EA4D RID: 125517
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPoints2D_GetActualMemorySize_04(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this attribute data.
		/// Used to support streaming and reading/writing data. The value
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to actually represent the data represented
		/// by this object. The information returned is valid only after
		/// the pipeline has been updated.
		/// </summary>
		// Token: 0x0601EA4E RID: 125518 RVA: 0x002B76AC File Offset: 0x002B58AC
		public uint GetActualMemorySize()
		{
			return vtkPoints2D.vtkPoints2D_GetActualMemorySize_04(base.GetCppThis());
		}

		// Token: 0x0601EA4F RID: 125519
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Return the bounds of the points.
		/// </summary>
		// Token: 0x0601EA50 RID: 125520 RVA: 0x002B76CC File Offset: 0x002B58CC
		public double[] GetBounds()
		{
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601EA51 RID: 125521
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_GetBounds_06(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return the bounds of the points.
		/// </summary>
		// Token: 0x0601EA52 RID: 125522 RVA: 0x002B7714 File Offset: 0x002B5914
		public void GetBounds(IntPtr bounds)
		{
			vtkPoints2D.vtkPoints2D_GetBounds_06(base.GetCppThis(), bounds);
		}

		// Token: 0x0601EA53 RID: 125523
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_GetData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the underlying data array. This function must be implemented
		/// in a concrete subclass to check for consistency. (The tuple size must
		/// match the type of data. For example, 3-tuple data array can be assigned to
		/// a vector, normal, or points object, but not a tensor object, which has a
		/// tuple dimension of 9. Scalars, on the other hand, can have tuple dimension
		/// from 1-4, depending on the type of scalar.)
		/// </summary>
		// Token: 0x0601EA54 RID: 125524 RVA: 0x002B7724 File Offset: 0x002B5924
		public vtkDataArray GetData()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_GetData_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601EA55 RID: 125525
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints2D_GetDataType_08(HandleRef pThis);

		/// <summary>
		/// Return the underlying data type. An integer indicating data type is
		/// returned as specified in vtkSetGet.h.
		/// </summary>
		// Token: 0x0601EA56 RID: 125526 RVA: 0x002B7794 File Offset: 0x002B5994
		public virtual int GetDataType()
		{
			return vtkPoints2D.vtkPoints2D_GetDataType_08(base.GetCppThis());
		}

		// Token: 0x0601EA57 RID: 125527
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints2D_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA58 RID: 125528 RVA: 0x002B77B4 File Offset: 0x002B59B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPoints2D.vtkPoints2D_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x0601EA59 RID: 125529
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints2D_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA5A RID: 125530 RVA: 0x002B77D4 File Offset: 0x002B59D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPoints2D.vtkPoints2D_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x0601EA5B RID: 125531
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints2D_GetNumberOfPoints_11(HandleRef pThis);

		/// <summary>
		/// Return number of points in array.
		/// </summary>
		// Token: 0x0601EA5C RID: 125532 RVA: 0x002B77F0 File Offset: 0x002B59F0
		public long GetNumberOfPoints()
		{
			return vtkPoints2D.vtkPoints2D_GetNumberOfPoints_11(base.GetCppThis());
		}

		// Token: 0x0601EA5D RID: 125533
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_GetPoint_12(HandleRef pThis, long id);

		/// <summary>
		/// Return a pointer to a double point x[2] for a specific id.
		/// WARNING: Just don't use this error-prone method, the returned pointer
		/// and its values are only valid as long as another method invocation is not
		/// performed. Prefer GetPoint() with the return value in argument.
		/// </summary>
		// Token: 0x0601EA5E RID: 125534 RVA: 0x002B7810 File Offset: 0x002B5A10
		public double[] GetPoint(long id)
		{
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_GetPoint_12(base.GetCppThis(), id);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601EA5F RID: 125535
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_GetPoint_13(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Copy point components into user provided array v[2] for specified id.
		/// </summary>
		// Token: 0x0601EA60 RID: 125536 RVA: 0x002B7859 File Offset: 0x002B5A59
		public void GetPoint(long id, IntPtr x)
		{
			vtkPoints2D.vtkPoints2D_GetPoint_13(base.GetCppThis(), id, x);
		}

		// Token: 0x0601EA61 RID: 125537
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_GetPoints_14(HandleRef pThis, HandleRef ptId, HandleRef fp);

		/// <summary>
		/// Given a list of pt ids, return an array of points.
		/// </summary>
		// Token: 0x0601EA62 RID: 125538 RVA: 0x002B786C File Offset: 0x002B5A6C
		public void GetPoints(vtkIdList ptId, vtkPoints2D fp)
		{
			vtkPoints2D.vtkPoints2D_GetPoints_14(base.GetCppThis(), (ptId == null) ? default(HandleRef) : ptId.GetCppThis(), (fp == null) ? default(HandleRef) : fp.GetCppThis());
		}

		// Token: 0x0601EA63 RID: 125539
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_GetVoidPointer_15(HandleRef pThis, int id);

		/// <summary>
		/// Return a void pointer. For image pipeline interface and other
		/// special pointer manipulation.
		/// </summary>
		// Token: 0x0601EA64 RID: 125540 RVA: 0x002B78B0 File Offset: 0x002B5AB0
		public IntPtr GetVoidPointer(int id)
		{
			return vtkPoints2D.vtkPoints2D_GetVoidPointer_15(base.GetCppThis(), id);
		}

		// Token: 0x0601EA65 RID: 125541
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_Initialize_16(HandleRef pThis);

		/// <summary>
		/// Return object to instantiated state.
		/// </summary>
		// Token: 0x0601EA66 RID: 125542 RVA: 0x002B78D0 File Offset: 0x002B5AD0
		public virtual void Initialize()
		{
			vtkPoints2D.vtkPoints2D_Initialize_16(base.GetCppThis());
		}

		// Token: 0x0601EA67 RID: 125543
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints2D_InsertNextPoint_17(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Insert point into next available slot. Returns id of slot.
		/// </summary>
		// Token: 0x0601EA68 RID: 125544 RVA: 0x002B78E0 File Offset: 0x002B5AE0
		public long InsertNextPoint(IntPtr x)
		{
			return vtkPoints2D.vtkPoints2D_InsertNextPoint_17(base.GetCppThis(), x);
		}

		// Token: 0x0601EA69 RID: 125545
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPoints2D_InsertNextPoint_18(HandleRef pThis, double x, double y);

		/// <summary>
		/// Insert point into next available slot. Returns id of slot.
		/// </summary>
		// Token: 0x0601EA6A RID: 125546 RVA: 0x002B7900 File Offset: 0x002B5B00
		public long InsertNextPoint(double x, double y)
		{
			return vtkPoints2D.vtkPoints2D_InsertNextPoint_18(base.GetCppThis(), x, y);
		}

		// Token: 0x0601EA6B RID: 125547
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_InsertPoint_19(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Insert point into object. Range checking performed and memory
		/// allocated as necessary.
		/// </summary>
		// Token: 0x0601EA6C RID: 125548 RVA: 0x002B7921 File Offset: 0x002B5B21
		public void InsertPoint(long id, IntPtr x)
		{
			vtkPoints2D.vtkPoints2D_InsertPoint_19(base.GetCppThis(), id, x);
		}

		// Token: 0x0601EA6D RID: 125549
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_InsertPoint_20(HandleRef pThis, long id, double x, double y);

		/// <summary>
		/// Insert point into object. Range checking performed and memory
		/// allocated as necessary.
		/// </summary>
		// Token: 0x0601EA6E RID: 125550 RVA: 0x002B7932 File Offset: 0x002B5B32
		public void InsertPoint(long id, double x, double y)
		{
			vtkPoints2D.vtkPoints2D_InsertPoint_20(base.GetCppThis(), id, x, y);
		}

		// Token: 0x0601EA6F RID: 125551
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints2D_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA70 RID: 125552 RVA: 0x002B7944 File Offset: 0x002B5B44
		public override int IsA(string type)
		{
			return vtkPoints2D.vtkPoints2D_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0601EA71 RID: 125553
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints2D_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA72 RID: 125554 RVA: 0x002B7964 File Offset: 0x002B5B64
		public new static int IsTypeOf(string type)
		{
			return vtkPoints2D.vtkPoints2D_IsTypeOf_22(type);
		}

		// Token: 0x0601EA73 RID: 125555
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_New_23(int dataType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA74 RID: 125556 RVA: 0x002B7980 File Offset: 0x002B5B80
		public static vtkPoints2D New(int dataType)
		{
			vtkPoints2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_New_23(dataType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EA75 RID: 125557
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA76 RID: 125558 RVA: 0x002B79D8 File Offset: 0x002B5BD8
		public new vtkPoints2D NewInstance()
		{
			vtkPoints2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EA77 RID: 125559
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_RemovePoint_26(HandleRef pThis, long id);

		/// <summary>
		/// Remove point described by its id
		/// </summary>
		// Token: 0x0601EA78 RID: 125560 RVA: 0x002B7A32 File Offset: 0x002B5C32
		public void RemovePoint(long id)
		{
			vtkPoints2D.vtkPoints2D_RemovePoint_26(base.GetCppThis(), id);
		}

		// Token: 0x0601EA79 RID: 125561
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_Reset_27(HandleRef pThis);

		/// <summary>
		/// Make object look empty but do not delete memory.
		/// </summary>
		// Token: 0x0601EA7A RID: 125562 RVA: 0x002B7A42 File Offset: 0x002B5C42
		public virtual void Reset()
		{
			vtkPoints2D.vtkPoints2D_Reset_27(base.GetCppThis());
		}

		// Token: 0x0601EA7B RID: 125563
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPoints2D_Resize_28(HandleRef pThis, long numPoints);

		/// <summary>
		/// Resize the internal array while conserving the data.  Returns 1 if
		/// resizing succeeded and 0 otherwise.
		/// </summary>
		// Token: 0x0601EA7C RID: 125564 RVA: 0x002B7A54 File Offset: 0x002B5C54
		public int Resize(long numPoints)
		{
			return vtkPoints2D.vtkPoints2D_Resize_28(base.GetCppThis(), numPoints);
		}

		// Token: 0x0601EA7D RID: 125565
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPoints2D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA7E RID: 125566 RVA: 0x002B7A74 File Offset: 0x002B5C74
		public new static vtkPoints2D SafeDownCast(vtkObjectBase o)
		{
			vtkPoints2D vtkPoints2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPoints2D.vtkPoints2D_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints2D = (vtkPoints2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints2D.Register(null);
				}
			}
			return vtkPoints2D;
		}

		// Token: 0x0601EA7F RID: 125567
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetData_30(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the underlying data array. This function must be implemented
		/// in a concrete subclass to check for consistency. (The tuple size must
		/// match the type of data. For example, 3-tuple data array can be assigned to
		/// a vector, normal, or points object, but not a tensor object, which has a
		/// tuple dimension of 9. Scalars, on the other hand, can have tuple dimension
		/// from 1-4, depending on the type of scalar.)
		/// </summary>
		// Token: 0x0601EA80 RID: 125568 RVA: 0x002B7AF4 File Offset: 0x002B5CF4
		public virtual void SetData(vtkDataArray arg0)
		{
			vtkPoints2D.vtkPoints2D_SetData_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601EA81 RID: 125569
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataType_31(HandleRef pThis, int dataType);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA82 RID: 125570 RVA: 0x002B7B23 File Offset: 0x002B5D23
		public virtual void SetDataType(int dataType)
		{
			vtkPoints2D.vtkPoints2D_SetDataType_31(base.GetCppThis(), dataType);
		}

		// Token: 0x0601EA83 RID: 125571
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToBit_32(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA84 RID: 125572 RVA: 0x002B7B33 File Offset: 0x002B5D33
		public void SetDataTypeToBit()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToBit_32(base.GetCppThis());
		}

		// Token: 0x0601EA85 RID: 125573
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToChar_33(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA86 RID: 125574 RVA: 0x002B7B42 File Offset: 0x002B5D42
		public void SetDataTypeToChar()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToChar_33(base.GetCppThis());
		}

		// Token: 0x0601EA87 RID: 125575
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToDouble_34(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA88 RID: 125576 RVA: 0x002B7B51 File Offset: 0x002B5D51
		public void SetDataTypeToDouble()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToDouble_34(base.GetCppThis());
		}

		// Token: 0x0601EA89 RID: 125577
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToFloat_35(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA8A RID: 125578 RVA: 0x002B7B60 File Offset: 0x002B5D60
		public void SetDataTypeToFloat()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToFloat_35(base.GetCppThis());
		}

		// Token: 0x0601EA8B RID: 125579
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToInt_36(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA8C RID: 125580 RVA: 0x002B7B6F File Offset: 0x002B5D6F
		public void SetDataTypeToInt()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToInt_36(base.GetCppThis());
		}

		// Token: 0x0601EA8D RID: 125581
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToLong_37(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA8E RID: 125582 RVA: 0x002B7B7E File Offset: 0x002B5D7E
		public void SetDataTypeToLong()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToLong_37(base.GetCppThis());
		}

		// Token: 0x0601EA8F RID: 125583
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToShort_38(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA90 RID: 125584 RVA: 0x002B7B8D File Offset: 0x002B5D8D
		public void SetDataTypeToShort()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToShort_38(base.GetCppThis());
		}

		// Token: 0x0601EA91 RID: 125585
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedChar_39(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA92 RID: 125586 RVA: 0x002B7B9C File Offset: 0x002B5D9C
		public void SetDataTypeToUnsignedChar()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedChar_39(base.GetCppThis());
		}

		// Token: 0x0601EA93 RID: 125587
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedInt_40(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA94 RID: 125588 RVA: 0x002B7BAB File Offset: 0x002B5DAB
		public void SetDataTypeToUnsignedInt()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedInt_40(base.GetCppThis());
		}

		// Token: 0x0601EA95 RID: 125589
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedLong_41(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA96 RID: 125590 RVA: 0x002B7BBA File Offset: 0x002B5DBA
		public void SetDataTypeToUnsignedLong()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedLong_41(base.GetCppThis());
		}

		// Token: 0x0601EA97 RID: 125591
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetDataTypeToUnsignedShort_42(HandleRef pThis);

		/// <summary>
		/// Specify the underlying data type of the object.
		/// </summary>
		// Token: 0x0601EA98 RID: 125592 RVA: 0x002B7BC9 File Offset: 0x002B5DC9
		public void SetDataTypeToUnsignedShort()
		{
			vtkPoints2D.vtkPoints2D_SetDataTypeToUnsignedShort_42(base.GetCppThis());
		}

		// Token: 0x0601EA99 RID: 125593
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetNumberOfPoints_43(HandleRef pThis, long numPoints);

		/// <summary>
		/// Specify the number of points for this object to hold. Does an
		/// allocation as well as setting the MaxId ivar. Used in conjunction with
		/// SetPoint() method for fast insertion.
		/// </summary>
		// Token: 0x0601EA9A RID: 125594 RVA: 0x002B7BD8 File Offset: 0x002B5DD8
		public void SetNumberOfPoints(long numPoints)
		{
			vtkPoints2D.vtkPoints2D_SetNumberOfPoints_43(base.GetCppThis(), numPoints);
		}

		// Token: 0x0601EA9B RID: 125595
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetPoint_44(HandleRef pThis, long id, IntPtr x);

		/// <summary>
		/// Insert point into object. No range checking performed (fast!).
		/// Make sure you use SetNumberOfPoints() to allocate memory prior
		/// to using SetPoint().
		/// </summary>
		// Token: 0x0601EA9C RID: 125596 RVA: 0x002B7BE8 File Offset: 0x002B5DE8
		public void SetPoint(long id, IntPtr x)
		{
			vtkPoints2D.vtkPoints2D_SetPoint_44(base.GetCppThis(), id, x);
		}

		// Token: 0x0601EA9D RID: 125597
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_SetPoint_45(HandleRef pThis, long id, double x, double y);

		/// <summary>
		/// Insert point into object. No range checking performed (fast!).
		/// Make sure you use SetNumberOfPoints() to allocate memory prior
		/// to using SetPoint().
		/// </summary>
		// Token: 0x0601EA9E RID: 125598 RVA: 0x002B7BF9 File Offset: 0x002B5DF9
		public void SetPoint(long id, double x, double y)
		{
			vtkPoints2D.vtkPoints2D_SetPoint_45(base.GetCppThis(), id, x, y);
		}

		// Token: 0x0601EA9F RID: 125599
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_ShallowCopy_46(HandleRef pThis, HandleRef ad);

		/// <summary>
		/// Different ways to copy data. Shallow copy does reference count (i.e.,
		/// assigns pointers and updates reference count); deep copy runs through
		/// entire data array assigning values.
		/// </summary>
		// Token: 0x0601EAA0 RID: 125600 RVA: 0x002B7C0C File Offset: 0x002B5E0C
		public virtual void ShallowCopy(vtkPoints2D ad)
		{
			vtkPoints2D.vtkPoints2D_ShallowCopy_46(base.GetCppThis(), (ad == null) ? default(HandleRef) : ad.GetCppThis());
		}

		// Token: 0x0601EAA1 RID: 125601
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPoints2D_Squeeze_47(HandleRef pThis);

		/// <summary>
		/// Reclaim any extra memory.
		/// </summary>
		// Token: 0x0601EAA2 RID: 125602 RVA: 0x002B7C3B File Offset: 0x002B5E3B
		public virtual void Squeeze()
		{
			vtkPoints2D.vtkPoints2D_Squeeze_47(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D6 RID: 8406
		public new const string MRFullTypeName = "Kitware.VTK.vtkPoints2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D7 RID: 8407
		public new static readonly string MRClassNameKey = "class vtkPoints2D";
	}
}
