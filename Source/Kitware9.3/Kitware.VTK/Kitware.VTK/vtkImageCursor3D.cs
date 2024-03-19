using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageCursor3D
	/// </summary>
	/// <remarks>
	///    Paints a cursor on top of an image or volume.
	///
	/// vtkImageCursor3D will draw a cursor on a 2d image or 3d volume.
	/// </remarks>
	// Token: 0x020003E3 RID: 995
	public class vtkImageCursor3D : vtkImageInPlaceFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BEAF RID: 48815 RVA: 0x00109CB7 File Offset: 0x00107EB7
		static vtkImageCursor3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCursor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCursor3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BEB0 RID: 48816 RVA: 0x00109CDF File Offset: 0x00107EDF
		public vtkImageCursor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BEB1 RID: 48817
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCursor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEB2 RID: 48818 RVA: 0x00109CF0 File Offset: 0x00107EF0
		public new static vtkImageCursor3D New()
		{
			vtkImageCursor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEB3 RID: 48819 RVA: 0x00109D44 File Offset: 0x00107F44
		public vtkImageCursor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageCursor3D.vtkImageCursor3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BEB4 RID: 48820 RVA: 0x00109D88 File Offset: 0x00107F88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BEB5 RID: 48821
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCursor3D_GetCursorPosition_01(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the center point of the 3d cursor.
		/// </summary>
		// Token: 0x0600BEB6 RID: 48822 RVA: 0x00109D94 File Offset: 0x00107F94
		public virtual double[] GetCursorPosition()
		{
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_GetCursorPosition_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BEB7 RID: 48823
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCursor3D_GetCursorPosition_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Sets/Gets the center point of the 3d cursor.
		/// </summary>
		// Token: 0x0600BEB8 RID: 48824 RVA: 0x00109DDC File Offset: 0x00107FDC
		public virtual void GetCursorPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageCursor3D.vtkImageCursor3D_GetCursorPosition_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600BEB9 RID: 48825
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCursor3D_GetCursorPosition_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets/Gets the center point of the 3d cursor.
		/// </summary>
		// Token: 0x0600BEBA RID: 48826 RVA: 0x00109DEE File Offset: 0x00107FEE
		public virtual void GetCursorPosition(IntPtr _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_GetCursorPosition_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BEBB RID: 48827
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCursor3D_GetCursorRadius_04(HandleRef pThis);

		/// <summary>
		/// Sets/Gets the radius of the cursor. The radius determines
		/// how far the axis lines project out from the cursors center.
		/// </summary>
		// Token: 0x0600BEBC RID: 48828 RVA: 0x00109E00 File Offset: 0x00108000
		public virtual int GetCursorRadius()
		{
			return vtkImageCursor3D.vtkImageCursor3D_GetCursorRadius_04(base.GetCppThis());
		}

		// Token: 0x0600BEBD RID: 48829
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageCursor3D_GetCursorValue_05(HandleRef pThis);

		/// <summary>
		/// Sets/Gets what pixel value to draw the cursor in.
		/// </summary>
		// Token: 0x0600BEBE RID: 48830 RVA: 0x00109E20 File Offset: 0x00108020
		public virtual double GetCursorValue()
		{
			return vtkImageCursor3D.vtkImageCursor3D_GetCursorValue_05(base.GetCppThis());
		}

		// Token: 0x0600BEBF RID: 48831
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCursor3D_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEC0 RID: 48832 RVA: 0x00109E40 File Offset: 0x00108040
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageCursor3D.vtkImageCursor3D_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600BEC1 RID: 48833
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageCursor3D_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEC2 RID: 48834 RVA: 0x00109E60 File Offset: 0x00108060
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageCursor3D.vtkImageCursor3D_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600BEC3 RID: 48835
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCursor3D_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEC4 RID: 48836 RVA: 0x00109E7C File Offset: 0x0010807C
		public override int IsA(string type)
		{
			return vtkImageCursor3D.vtkImageCursor3D_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600BEC5 RID: 48837
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageCursor3D_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEC6 RID: 48838 RVA: 0x00109E9C File Offset: 0x0010809C
		public new static int IsTypeOf(string type)
		{
			return vtkImageCursor3D.vtkImageCursor3D_IsTypeOf_09(type);
		}

		// Token: 0x0600BEC7 RID: 48839
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCursor3D_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEC8 RID: 48840 RVA: 0x00109EB8 File Offset: 0x001080B8
		public new vtkImageCursor3D NewInstance()
		{
			vtkImageCursor3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BEC9 RID: 48841
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageCursor3D_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BECA RID: 48842 RVA: 0x00109F14 File Offset: 0x00108114
		public new static vtkImageCursor3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageCursor3D vtkImageCursor3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCursor3D = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCursor3D.Register(null);
				}
			}
			return vtkImageCursor3D;
		}

		// Token: 0x0600BECB RID: 48843
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCursor3D_SetCursorPosition_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Sets/Gets the center point of the 3d cursor.
		/// </summary>
		// Token: 0x0600BECC RID: 48844 RVA: 0x00109F93 File Offset: 0x00108193
		public virtual void SetCursorPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorPosition_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600BECD RID: 48845
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCursor3D_SetCursorPosition_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Sets/Gets the center point of the 3d cursor.
		/// </summary>
		// Token: 0x0600BECE RID: 48846 RVA: 0x00109FA5 File Offset: 0x001081A5
		public virtual void SetCursorPosition(IntPtr _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorPosition_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BECF RID: 48847
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCursor3D_SetCursorRadius_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Sets/Gets the radius of the cursor. The radius determines
		/// how far the axis lines project out from the cursors center.
		/// </summary>
		// Token: 0x0600BED0 RID: 48848 RVA: 0x00109FB5 File Offset: 0x001081B5
		public virtual void SetCursorRadius(int _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorRadius_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BED1 RID: 48849
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageCursor3D_SetCursorValue_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Sets/Gets what pixel value to draw the cursor in.
		/// </summary>
		// Token: 0x0600BED2 RID: 48850 RVA: 0x00109FC5 File Offset: 0x001081C5
		public virtual void SetCursorValue(double _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorValue_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E33 RID: 3635
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCursor3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E34 RID: 3636
		public new static readonly string MRClassNameKey = "class vtkImageCursor3D";
	}
}
