using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridVolumeRayCastIterator
	///
	///
	///
	/// vtkUnstructuredGridVolumeRayCastIterator is a superclass for iterating
	/// over the intersections of a viewing ray with a group of unstructured
	/// cells.  These iterators are created with a
	/// vtkUnstructuredGridVolumeRayCastFunction.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkUnstructuredGridVolumeRayCastFunction
	///
	/// </seealso>
	// Token: 0x020003A9 RID: 937
	public abstract class vtkUnstructuredGridVolumeRayCastIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AA1D RID: 43549 RVA: 0x000F1D9F File Offset: 0x000EFF9F
		static vtkUnstructuredGridVolumeRayCastIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayCastIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AA1E RID: 43550 RVA: 0x000F1DC7 File Offset: 0x000EFFC7
		public vtkUnstructuredGridVolumeRayCastIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AA1F RID: 43551 RVA: 0x000F1DD5 File Offset: 0x000EFFD5
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AA20 RID: 43552
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_GetBounds_01(HandleRef pThis);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA21 RID: 43553 RVA: 0x000F1DE0 File Offset: 0x000EFFE0
		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AA22 RID: 43554
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_GetBounds_02(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA23 RID: 43555 RVA: 0x000F1E28 File Offset: 0x000F0028
		public virtual void GetBounds(ref double _arg1, ref double _arg2)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetBounds_02(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600AA24 RID: 43556
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_GetBounds_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA25 RID: 43557 RVA: 0x000F1E39 File Offset: 0x000F0039
		public virtual void GetBounds(IntPtr _arg)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetBounds_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA26 RID: 43558
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetMaxNumberOfIntersections_04(HandleRef pThis);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA27 RID: 43559 RVA: 0x000F1E4C File Offset: 0x000F004C
		public virtual long GetMaxNumberOfIntersections()
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetMaxNumberOfIntersections_04(base.GetCppThis());
		}

		// Token: 0x0600AA28 RID: 43560
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNextIntersections_05(HandleRef pThis, HandleRef intersectedCells, HandleRef intersectionLengths, HandleRef scalars, HandleRef nearIntersections, HandleRef farIntersections);

		/// <summary>
		/// Get the intersections of the next several cells.  The cell ids are
		/// stored in \c intersectedCells and the length of each ray segment
		/// within the cell is stored in \c intersectionLengths.  The point
		/// scalars \c scalars are interpolated and stored in \c nearIntersections
		/// and \c farIntersections.  \c intersectedCells, \c intersectionLengths,
		/// or \c scalars may be \c NULL to suppress passing the associated
		/// information.  The number of intersections actually encountered is
		/// returned.  0 is returned if and only if no more intersections are to
		/// be found.
		/// </summary>
		// Token: 0x0600AA29 RID: 43561 RVA: 0x000F1E6C File Offset: 0x000F006C
		public virtual long GetNextIntersections(vtkIdList intersectedCells, vtkDoubleArray intersectionLengths, vtkDataArray scalars, vtkDataArray nearIntersections, vtkDataArray farIntersections)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetNextIntersections_05(base.GetCppThis(), (intersectedCells == null) ? default(HandleRef) : intersectedCells.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis());
		}

		// Token: 0x0600AA2A RID: 43562
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA2B RID: 43563 RVA: 0x000F1EF8 File Offset: 0x000F00F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600AA2C RID: 43564
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA2D RID: 43565 RVA: 0x000F1F18 File Offset: 0x000F0118
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600AA2E RID: 43566
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_Initialize_08(HandleRef pThis, int x, int y);

		/// <summary>
		/// Initializes the iteration to the start of the ray at the given screen
		/// coordinates.
		/// </summary>
		// Token: 0x0600AA2F RID: 43567 RVA: 0x000F1F32 File Offset: 0x000F0132
		public virtual void Initialize(int x, int y)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_Initialize_08(base.GetCppThis(), x, y);
		}

		// Token: 0x0600AA30 RID: 43568
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastIterator_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA31 RID: 43569 RVA: 0x000F1F44 File Offset: 0x000F0144
		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600AA32 RID: 43570
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastIterator_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA33 RID: 43571 RVA: 0x000F1F64 File Offset: 0x000F0164
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_IsTypeOf_10(type);
		}

		// Token: 0x0600AA34 RID: 43572
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA35 RID: 43573 RVA: 0x000F1F80 File Offset: 0x000F0180
		public new vtkUnstructuredGridVolumeRayCastIterator NewInstance()
		{
			vtkUnstructuredGridVolumeRayCastIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AA36 RID: 43574
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AA37 RID: 43575 RVA: 0x000F1FDC File Offset: 0x000F01DC
		public new static vtkUnstructuredGridVolumeRayCastIterator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastIterator = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastIterator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastIterator;
		}

		// Token: 0x0600AA38 RID: 43576
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetBounds_13(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA39 RID: 43577 RVA: 0x000F205B File Offset: 0x000F025B
		public virtual void SetBounds(double _arg1, double _arg2)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SetBounds_13(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600AA3A RID: 43578
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetBounds_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA3B RID: 43579 RVA: 0x000F206C File Offset: 0x000F026C
		public void SetBounds(IntPtr _arg)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SetBounds_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AA3C RID: 43580
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastIterator_SetMaxNumberOfIntersections_15(HandleRef pThis, long _arg);

		/// <summary>
		/// Set/get the bounds of the cast ray (in viewing coordinates).  By
		/// default the range is [0,1].
		/// </summary>
		// Token: 0x0600AA3D RID: 43581 RVA: 0x000F207C File Offset: 0x000F027C
		public virtual void SetMaxNumberOfIntersections(long _arg)
		{
			vtkUnstructuredGridVolumeRayCastIterator.vtkUnstructuredGridVolumeRayCastIterator_SetMaxNumberOfIntersections_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D87 RID: 3463
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D88 RID: 3464
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastIterator";
	}
}
