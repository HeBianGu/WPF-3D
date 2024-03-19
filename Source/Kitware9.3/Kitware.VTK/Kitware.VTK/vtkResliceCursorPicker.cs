using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceCursorPicker
	/// </summary>
	/// <remarks>
	///    ray-cast cell picker for the reslice cursor
	///
	/// This class is used by the vtkResliceCursorWidget to pick reslice axes
	/// drawn by a vtkResliceCursorActor. The class returns the axes picked if
	/// any, whether one has picked the center. It takes as input an instance
	/// of vtkResliceCursorPolyDataAlgorithm. This is all done internally by
	/// vtkResliceCursorWidget and as such users are not expected to use this
	/// class directly, unless they are overriding the behaviour of
	/// vtkResliceCursorWidget.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursor vtkResliceCursorWidget
	/// </seealso>
	// Token: 0x02000369 RID: 873
	public class vtkResliceCursorPicker : vtkPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06009EE7 RID: 40679 RVA: 0x000E152B File Offset: 0x000DF72B
		static vtkResliceCursorPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceCursorPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceCursorPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06009EE8 RID: 40680 RVA: 0x000E1553 File Offset: 0x000DF753
		public vtkResliceCursorPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06009EE9 RID: 40681
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EEA RID: 40682 RVA: 0x000E1564 File Offset: 0x000DF764
		public new static vtkResliceCursorPicker New()
		{
			vtkResliceCursorPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPicker.vtkResliceCursorPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EEB RID: 40683 RVA: 0x000E15B8 File Offset: 0x000DF7B8
		public vtkResliceCursorPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceCursorPicker.vtkResliceCursorPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06009EEC RID: 40684 RVA: 0x000E15FC File Offset: 0x000DF7FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06009EED RID: 40685
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EEE RID: 40686 RVA: 0x000E1608 File Offset: 0x000DF808
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06009EEF RID: 40687
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceCursorPicker_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EF0 RID: 40688 RVA: 0x000E1628 File Offset: 0x000DF828
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06009EF1 RID: 40689
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPicker_GetPickedAxis1_03(HandleRef pThis);

		/// <summary>
		/// Get the picked axis
		/// </summary>
		// Token: 0x06009EF2 RID: 40690 RVA: 0x000E1644 File Offset: 0x000DF844
		public virtual int GetPickedAxis1()
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_GetPickedAxis1_03(base.GetCppThis());
		}

		// Token: 0x06009EF3 RID: 40691
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPicker_GetPickedAxis2_04(HandleRef pThis);

		/// <summary>
		/// Get the picked axis
		/// </summary>
		// Token: 0x06009EF4 RID: 40692 RVA: 0x000E1664 File Offset: 0x000DF864
		public virtual int GetPickedAxis2()
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_GetPickedAxis2_04(base.GetCppThis());
		}

		// Token: 0x06009EF5 RID: 40693
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPicker_GetPickedCenter_05(HandleRef pThis);

		/// <summary>
		/// Get the picked axis
		/// </summary>
		// Token: 0x06009EF6 RID: 40694 RVA: 0x000E1684 File Offset: 0x000DF884
		public virtual int GetPickedCenter()
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_GetPickedCenter_05(base.GetCppThis());
		}

		// Token: 0x06009EF7 RID: 40695
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPicker_GetResliceCursorAlgorithm_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the reslice cursor algorithm. One must be set
		/// </summary>
		// Token: 0x06009EF8 RID: 40696 RVA: 0x000E16A4 File Offset: 0x000DF8A4
		public virtual vtkResliceCursorPolyDataAlgorithm GetResliceCursorAlgorithm()
		{
			vtkResliceCursorPolyDataAlgorithm vtkResliceCursorPolyDataAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPicker.vtkResliceCursorPicker_GetResliceCursorAlgorithm_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06009EF9 RID: 40697
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPicker_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EFA RID: 40698 RVA: 0x000E1714 File Offset: 0x000DF914
		public override int IsA(string type)
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06009EFB RID: 40699
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPicker_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EFC RID: 40700 RVA: 0x000E1734 File Offset: 0x000DF934
		public new static int IsTypeOf(string type)
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_IsTypeOf_08(type);
		}

		// Token: 0x06009EFD RID: 40701
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPicker_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009EFE RID: 40702 RVA: 0x000E1750 File Offset: 0x000DF950
		public new vtkResliceCursorPicker NewInstance()
		{
			vtkResliceCursorPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPicker.vtkResliceCursorPicker_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceCursorPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06009EFF RID: 40703
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceCursorPicker_Pick_11(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// Perform pick operation with selection point provided. Normally the
		/// first two values are the (x,y) pixel coordinates for the pick, and
		/// the third value is z=0. The return value will be non-zero if
		/// something was successfully picked.
		/// </summary>
		// Token: 0x06009F00 RID: 40704 RVA: 0x000E17AC File Offset: 0x000DF9AC
		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkResliceCursorPicker.vtkResliceCursorPicker_Pick_11(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x06009F01 RID: 40705
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPicker_Pick_12(HandleRef pThis, IntPtr displayPos, IntPtr world, HandleRef ren);

		/// <summary>
		/// Overloaded pick method that returns the picked coordinates of the current
		/// resliced plane in world coordinates when given a display position
		/// </summary>
		// Token: 0x06009F02 RID: 40706 RVA: 0x000E17E8 File Offset: 0x000DF9E8
		public void Pick(IntPtr displayPos, IntPtr world, vtkRenderer ren)
		{
			vtkResliceCursorPicker.vtkResliceCursorPicker_Pick_12(base.GetCppThis(), displayPos, world, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06009F03 RID: 40707
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceCursorPicker_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06009F04 RID: 40708 RVA: 0x000E181C File Offset: 0x000DFA1C
		public new static vtkResliceCursorPicker SafeDownCast(vtkObjectBase o)
		{
			vtkResliceCursorPicker vtkResliceCursorPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceCursorPicker.vtkResliceCursorPicker_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceCursorPicker = (vtkResliceCursorPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceCursorPicker.Register(null);
				}
			}
			return vtkResliceCursorPicker;
		}

		// Token: 0x06009F05 RID: 40709
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPicker_SetResliceCursorAlgorithm_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the reslice cursor algorithm. One must be set
		/// </summary>
		// Token: 0x06009F06 RID: 40710 RVA: 0x000E189C File Offset: 0x000DFA9C
		public virtual void SetResliceCursorAlgorithm(vtkResliceCursorPolyDataAlgorithm arg0)
		{
			vtkResliceCursorPicker.vtkResliceCursorPicker_SetResliceCursorAlgorithm_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06009F07 RID: 40711
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceCursorPicker_SetTransformMatrix_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the reslice cursor algorithm. One must be set
		/// </summary>
		// Token: 0x06009F08 RID: 40712 RVA: 0x000E18CC File Offset: 0x000DFACC
		public virtual void SetTransformMatrix(vtkMatrix4x4 arg0)
		{
			vtkResliceCursorPicker.vtkResliceCursorPicker_SetTransformMatrix_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD3 RID: 3283
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceCursorPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000CD4 RID: 3284
		public new static readonly string MRClassNameKey = "class vtkResliceCursorPicker";
	}
}
