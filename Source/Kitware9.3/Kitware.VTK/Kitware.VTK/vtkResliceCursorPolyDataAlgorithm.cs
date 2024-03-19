using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorPolyDataAlgorithm
	/// </summary>
	/// <remarks>
	///    generates a 2D reslice cursor polydata
	///
	/// vtkResliceCursorPolyDataAlgorithm is a class that generates a 2D
	/// reslice cursor vtkPolyData, suitable for rendering within a
	/// vtkResliceCursorActor. The class takes as input the reslice plane
	/// normal index (an index into the normal plane maintained by the reslice
	/// cursor object) and generates the polydata representing the other two
	/// reslice axes suitable for rendering on a slice through this plane.
	/// The cursor consists of two intersection axes lines that meet at the
	/// cursor focus. These lines may have a user defined thickness. They
	/// need not be orthogonal to each other.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursorActor vtkResliceCursor vtkResliceCursorWidget
	/// </seealso>
	// Token: 0x0200036A RID: 874
	public class vtkResliceCursorPolyDataAlgorithm : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009F09 RID: 40713 RVA: 0x000E18FB File Offset: 0x000DFAFB
		static vtkResliceCursorPolyDataAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorPolyDataAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorPolyDataAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009F0A RID: 40714 RVA: 0x000E1923 File Offset: 0x000DFB23
		public vtkResliceCursorPolyDataAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009F0B RID: 40715
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F0C RID: 40716 RVA: 0x000E1934 File Offset: 0x000DFB34
		public new static vtkResliceCursorPolyDataAlgorithm New()
		{
			vtkResliceCursorPolyDataAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F0D RID: 40717 RVA: 0x000E1988 File Offset: 0x000DFB88
		public vtkResliceCursorPolyDataAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009F0E RID: 40718 RVA: 0x000E19CC File Offset: 0x000DFBCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009F0F RID: 40719
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_GetAxis1_01(HandleRef pThis);

		/// <summary>
		/// Get the index of the axes and the planes that they represent
		/// </summary>
		// Token: 0x06009F10 RID: 40720 RVA: 0x000E19D8 File Offset: 0x000DFBD8
		public virtual int GetAxis1()
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetAxis1_01(base.GetCppThis());
		}

		// Token: 0x06009F11 RID: 40721
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_GetAxis2_02(HandleRef pThis);

		/// <summary>
		/// Get the index of the axes and the planes that they represent
		/// </summary>
		// Token: 0x06009F12 RID: 40722 RVA: 0x000E19F8 File Offset: 0x000DFBF8
		public virtual int GetAxis2()
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetAxis2_02(base.GetCppThis());
		}

		// Token: 0x06009F13 RID: 40723
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis1_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get either one of the axes that this object produces. Depending on
		/// the mode, one renders either the centerline axes or both the
		/// centerline axes and the slab
		/// </summary>
		// Token: 0x06009F14 RID: 40724 RVA: 0x000E1A18 File Offset: 0x000DFC18
		public virtual vtkPolyData GetCenterlineAxis1()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis1_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009F15 RID: 40725
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis2_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get either one of the axes that this object produces. Depending on
		/// the mode, one renders either the centerline axes or both the
		/// centerline axes and the slab
		/// </summary>
		// Token: 0x06009F16 RID: 40726 RVA: 0x000E1A88 File Offset: 0x000DFC88
		public virtual vtkPolyData GetCenterlineAxis2()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetCenterlineAxis2_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009F17 RID: 40727
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkResliceCursorPolyDataAlgorithm_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Get the MTime. Check the MTime of the internal ResliceCursor as well, if
		/// one has been set
		/// </summary>
		// Token: 0x06009F18 RID: 40728 RVA: 0x000E1AF8 File Offset: 0x000DFCF8
		public override ulong GetMTime()
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06009F19 RID: 40729
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F1A RID: 40730 RVA: 0x000E1B18 File Offset: 0x000DFD18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06009F1B RID: 40731
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F1C RID: 40732 RVA: 0x000E1B38 File Offset: 0x000DFD38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06009F1D RID: 40733
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_GetOtherPlaneForAxis_08(HandleRef pThis, int p);

		/// <summary>
		/// Convenience method that, given one plane, returns the other plane
		/// that this class represents.
		/// </summary>
		// Token: 0x06009F1E RID: 40734 RVA: 0x000E1B54 File Offset: 0x000DFD54
		public int GetOtherPlaneForAxis(int p)
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetOtherPlaneForAxis_08(base.GetCppThis(), p);
		}

		// Token: 0x06009F1F RID: 40735
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis1_09(HandleRef pThis);

		/// <summary>
		/// Get the index of the axes and the planes that they represent
		/// </summary>
		// Token: 0x06009F20 RID: 40736 RVA: 0x000E1B74 File Offset: 0x000DFD74
		public virtual int GetPlaneAxis1()
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis1_09(base.GetCppThis());
		}

		// Token: 0x06009F21 RID: 40737
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis2_10(HandleRef pThis);

		/// <summary>
		/// Get the index of the axes and the planes that they represent
		/// </summary>
		// Token: 0x06009F22 RID: 40738 RVA: 0x000E1B94 File Offset: 0x000DFD94
		public virtual int GetPlaneAxis2()
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetPlaneAxis2_10(base.GetCppThis());
		}

		// Token: 0x06009F23 RID: 40739
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetResliceCursor_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the Reslice cursor from which to generate the polydata representation
		/// </summary>
		// Token: 0x06009F24 RID: 40740 RVA: 0x000E1BB4 File Offset: 0x000DFDB4
		public virtual vtkResliceCursor GetResliceCursor()
		{
			vtkResliceCursor vtkResliceCursor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetResliceCursor_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursor = (vtkResliceCursor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursor.Register(null);
				}
			}
			return vtkResliceCursor;
		}

		// Token: 0x06009F25 RID: 40741
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_GetReslicePlaneNormal_12(HandleRef pThis);

		/// <summary>
		/// Which of the 3 axes defines the reslice plane normal ?
		/// </summary>
		// Token: 0x06009F26 RID: 40742 RVA: 0x000E1C24 File Offset: 0x000DFE24
		public virtual int GetReslicePlaneNormal()
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetReslicePlaneNormal_12(base.GetCppThis());
		}

		// Token: 0x06009F27 RID: 40743
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the slice bounds, ie the slice of this view on which to display
		/// the reslice cursor.
		/// </summary>
		// Token: 0x06009F28 RID: 40744 RVA: 0x000E1C44 File Offset: 0x000DFE44
		public virtual double[] GetSliceBounds()
		{
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06009F29 RID: 40745
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		/// <summary>
		/// Set/Get the slice bounds, ie the slice of this view on which to display
		/// the reslice cursor.
		/// </summary>
		// Token: 0x06009F2A RID: 40746 RVA: 0x000E1C8C File Offset: 0x000DFE8C
		public virtual void GetSliceBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x06009F2B RID: 40747
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the slice bounds, ie the slice of this view on which to display
		/// the reslice cursor.
		/// </summary>
		// Token: 0x06009F2C RID: 40748 RVA: 0x000E1CA4 File Offset: 0x000DFEA4
		public virtual void GetSliceBounds(IntPtr _arg)
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetSliceBounds_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06009F2D RID: 40749
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis1_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get either one of the axes that this object produces. Depending on
		/// the mode, one renders either the centerline axes or both the
		/// centerline axes and the slab
		/// </summary>
		// Token: 0x06009F2E RID: 40750 RVA: 0x000E1CB4 File Offset: 0x000DFEB4
		public virtual vtkPolyData GetThickSlabAxis1()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis1_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009F2F RID: 40751
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis2_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get either one of the axes that this object produces. Depending on
		/// the mode, one renders either the centerline axes or both the
		/// centerline axes and the slab
		/// </summary>
		// Token: 0x06009F30 RID: 40752 RVA: 0x000E1D24 File Offset: 0x000DFF24
		public virtual vtkPolyData GetThickSlabAxis2()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_GetThickSlabAxis2_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06009F31 RID: 40753
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F32 RID: 40754 RVA: 0x000E1D94 File Offset: 0x000DFF94
		public override int IsA(string type)
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06009F33 RID: 40755
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPolyDataAlgorithm_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F34 RID: 40756 RVA: 0x000E1DB4 File Offset: 0x000DFFB4
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_IsTypeOf_19(type);
		}

		// Token: 0x06009F35 RID: 40757
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F36 RID: 40758 RVA: 0x000E1DD0 File Offset: 0x000DFFD0
		public new vtkResliceCursorPolyDataAlgorithm NewInstance()
		{
			vtkResliceCursorPolyDataAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009F37 RID: 40759
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPolyDataAlgorithm_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F38 RID: 40760 RVA: 0x000E1E2C File Offset: 0x000E002C
		public new static vtkResliceCursorPolyDataAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorPolyDataAlgorithm = (vtkResliceCursorPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorPolyDataAlgorithm.Register(null);
				}
			}
			return vtkResliceCursorPolyDataAlgorithm;
		}

		// Token: 0x06009F39 RID: 40761
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetResliceCursor_23(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the Reslice cursor from which to generate the polydata representation
		/// </summary>
		// Token: 0x06009F3A RID: 40762 RVA: 0x000E1EAC File Offset: 0x000E00AC
		public virtual void SetResliceCursor(vtkResliceCursor arg0)
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetResliceCursor_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009F3B RID: 40763
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormal_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Which of the 3 axes defines the reslice plane normal ?
		/// </summary>
		// Token: 0x06009F3C RID: 40764 RVA: 0x000E1EDB File Offset: 0x000E00DB
		public virtual void SetReslicePlaneNormal(int _arg)
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormal_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06009F3D RID: 40765
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToXAxis_25(HandleRef pThis);

		/// <summary>
		/// Set the planes that correspond to the reslice axes.
		/// </summary>
		// Token: 0x06009F3E RID: 40766 RVA: 0x000E1EEB File Offset: 0x000E00EB
		public void SetReslicePlaneNormalToXAxis()
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToXAxis_25(base.GetCppThis());
		}

		// Token: 0x06009F3F RID: 40767
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToYAxis_26(HandleRef pThis);

		/// <summary>
		/// Set the planes that correspond to the reslice axes.
		/// </summary>
		// Token: 0x06009F40 RID: 40768 RVA: 0x000E1EFA File Offset: 0x000E00FA
		public void SetReslicePlaneNormalToYAxis()
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToYAxis_26(base.GetCppThis());
		}

		// Token: 0x06009F41 RID: 40769
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToZAxis_27(HandleRef pThis);

		/// <summary>
		/// Set the planes that correspond to the reslice axes.
		/// </summary>
		// Token: 0x06009F42 RID: 40770 RVA: 0x000E1F09 File Offset: 0x000E0109
		public void SetReslicePlaneNormalToZAxis()
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetReslicePlaneNormalToZAxis_27(base.GetCppThis());
		}

		// Token: 0x06009F43 RID: 40771
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_28(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		/// <summary>
		/// Set/Get the slice bounds, ie the slice of this view on which to display
		/// the reslice cursor.
		/// </summary>
		// Token: 0x06009F44 RID: 40772 RVA: 0x000E1F18 File Offset: 0x000E0118
		public virtual void SetSliceBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_28(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06009F45 RID: 40773
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the slice bounds, ie the slice of this view on which to display
		/// the reslice cursor.
		/// </summary>
		// Token: 0x06009F46 RID: 40774 RVA: 0x000E1F30 File Offset: 0x000E0130
		public virtual void SetSliceBounds(IntPtr _arg)
		{
			vtkResliceCursorPolyDataAlgorithm.vtkResliceCursorPolyDataAlgorithm_SetSliceBounds_29(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD5 RID: 3285
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorPolyDataAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD6 RID: 3286
		public new static readonly string MRClassNameKey = "class vtkResliceCursorPolyDataAlgorithm";

		/// <summary>
		/// Which of the 3 axes defines the reslice plane normal ?
		/// </summary>
		// Token: 0x0200036B RID: 875
		public enum XAxis_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000CD8 RID: 3288
			XAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000CD9 RID: 3289
			YAxis,
			/// <summary>enum member</summary>
			// Token: 0x04000CDA RID: 3290
			ZAxis
		}
	}
}
