using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMapToWindowLevelColors
	/// </summary>
	/// <remarks>
	///    Map an image through a lookup table and/or a window/level.
	///
	/// The vtkImageMapToWindowLevelColors filter can be used to perform
	/// the following operations depending on its settings:
	/// -# If no lookup table is provided, and if the input data has a single
	///    component (any numerical scalar type is allowed), then the data is
	///    mapped through the specified Window/Level.  The type of the output
	///    scalars will be "unsigned char" with a range of (0,255).
	/// -# If no lookup table is provided, and if the input data is already
	///    unsigned char, and if the Window/Level is set to 255.0/127.5, then
	///    the input data will be passed directly to the output.
	/// -# If a lookup table is provided, then the first component of the
	///    input data is mapped through the lookup table (using the Range of
	///    the lookup table), and the resulting color is modulated according
	///    to the Window/Level.  For example, if the input value is 500 and
	///    the Window/Level are 2000/1000, the output value will be RGB*0.25
	///    where RGB is the color assigned by the lookup table and 0.25 is
	///    the modulation factor.
	/// See SetWindow() and SetLevel() for the equations used for modulation.
	/// To map scalars through a lookup table without modulating the resulting
	/// color, use vtkImageMapToColors instead of this filter.
	/// </remarks>
	/// <seealso>
	///
	/// vtkLookupTable vtkScalarsToColors
	/// </seealso>
	// Token: 0x020003F2 RID: 1010
	public class vtkImageMapToWindowLevelColors : vtkImageMapToColors
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C12F RID: 49455 RVA: 0x0010D18F File Offset: 0x0010B38F
		static vtkImageMapToWindowLevelColors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapToWindowLevelColors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToWindowLevelColors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C130 RID: 49456 RVA: 0x0010D1B7 File Offset: 0x0010B3B7
		public vtkImageMapToWindowLevelColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C131 RID: 49457
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToWindowLevelColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C132 RID: 49458 RVA: 0x0010D1C8 File Offset: 0x0010B3C8
		public new static vtkImageMapToWindowLevelColors New()
		{
			vtkImageMapToWindowLevelColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C133 RID: 49459 RVA: 0x0010D21C File Offset: 0x0010B41C
		public vtkImageMapToWindowLevelColors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C134 RID: 49460 RVA: 0x0010D260 File Offset: 0x0010B460
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C135 RID: 49461
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMapToWindowLevelColors_GetLevel_01(HandleRef pThis);

		/// <summary>
		/// Set / Get the Level to use -&gt; modulation will be performed on the
		/// color based on (S - (L - W/2))/W where S is the scalar value, L is
		/// the level and W is the window.
		/// </summary>
		// Token: 0x0600C136 RID: 49462 RVA: 0x0010D26C File Offset: 0x0010B46C
		public virtual double GetLevel()
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_GetLevel_01(base.GetCppThis());
		}

		// Token: 0x0600C137 RID: 49463
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C138 RID: 49464 RVA: 0x0010D28C File Offset: 0x0010B48C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600C139 RID: 49465
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C13A RID: 49466 RVA: 0x0010D2AC File Offset: 0x0010B4AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600C13B RID: 49467
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageMapToWindowLevelColors_GetWindow_04(HandleRef pThis);

		/// <summary>
		/// Set / Get the Window to use -&gt; modulation will be performed on the
		/// color based on (S - (L - W/2))/W where S is the scalar value, L is
		/// the level and W is the window.
		/// </summary>
		// Token: 0x0600C13C RID: 49468 RVA: 0x0010D2C8 File Offset: 0x0010B4C8
		public virtual double GetWindow()
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_GetWindow_04(base.GetCppThis());
		}

		// Token: 0x0600C13D RID: 49469
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToWindowLevelColors_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C13E RID: 49470 RVA: 0x0010D2E8 File Offset: 0x0010B4E8
		public override int IsA(string type)
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600C13F RID: 49471
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToWindowLevelColors_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C140 RID: 49472 RVA: 0x0010D308 File Offset: 0x0010B508
		public new static int IsTypeOf(string type)
		{
			return vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_IsTypeOf_06(type);
		}

		// Token: 0x0600C141 RID: 49473
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToWindowLevelColors_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C142 RID: 49474 RVA: 0x0010D324 File Offset: 0x0010B524
		public new vtkImageMapToWindowLevelColors NewInstance()
		{
			vtkImageMapToWindowLevelColors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C143 RID: 49475
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToWindowLevelColors_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C144 RID: 49476 RVA: 0x0010D380 File Offset: 0x0010B580
		public new static vtkImageMapToWindowLevelColors SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToWindowLevelColors = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToWindowLevelColors.Register(null);
				}
			}
			return vtkImageMapToWindowLevelColors;
		}

		// Token: 0x0600C145 RID: 49477
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToWindowLevelColors_SetLevel_10(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the Level to use -&gt; modulation will be performed on the
		/// color based on (S - (L - W/2))/W where S is the scalar value, L is
		/// the level and W is the window.
		/// </summary>
		// Token: 0x0600C146 RID: 49478 RVA: 0x0010D3FF File Offset: 0x0010B5FF
		public virtual void SetLevel(double _arg)
		{
			vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_SetLevel_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600C147 RID: 49479
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageMapToWindowLevelColors_SetWindow_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / Get the Window to use -&gt; modulation will be performed on the
		/// color based on (S - (L - W/2))/W where S is the scalar value, L is
		/// the level and W is the window.
		/// </summary>
		// Token: 0x0600C148 RID: 49480 RVA: 0x0010D40F File Offset: 0x0010B60F
		public virtual void SetWindow(double _arg)
		{
			vtkImageMapToWindowLevelColors.vtkImageMapToWindowLevelColors_SetWindow_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E51 RID: 3665
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToWindowLevelColors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E52 RID: 3666
		public new static readonly string MRClassNameKey = "class vtkImageMapToWindowLevelColors";
	}
}
