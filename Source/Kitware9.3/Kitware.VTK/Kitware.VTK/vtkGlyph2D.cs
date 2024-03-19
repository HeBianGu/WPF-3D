using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGlyph2D
	/// </summary>
	/// <remarks>
	///    copy oriented and scaled glyph geometry to every input point (2D specialization)
	///
	/// This subclass of vtkGlyph3D is a specialization to 2D. Transformations
	/// (i.e., translation, scaling, and rotation) are constrained to the plane.
	/// For example, rotations due to a vector are computed from the x-y
	/// coordinates of the vector only, and are assumed to occur around the
	/// z-axis. (See vtkGlyph3D for documentation on the interface to this
	/// class.)
	///
	/// Frequently this class is used in combination with vtkGlyphSource.
	/// vtkGlyphSource2D can produce a family of 2D glyphs.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorGlyph vtkGlyph3D vtkProgrammableGlyphFilter vtkGlyphSource2D
	/// </seealso>
	// Token: 0x0200096D RID: 2413
	public class vtkGlyph2D : vtkGlyph3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019292 RID: 103058 RVA: 0x00230EEF File Offset: 0x0022F0EF
		static vtkGlyph2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGlyph2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyph2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019293 RID: 103059 RVA: 0x00230F17 File Offset: 0x0022F117
		public vtkGlyph2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019294 RID: 103060
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with scaling on, scaling mode is by scalar value,
		/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
		/// orientation is by vector. Clamping and indexing are turned off. No
		/// initial sources are defined.
		/// </summary>
		// Token: 0x06019295 RID: 103061 RVA: 0x00230F28 File Offset: 0x0022F128
		public new static vtkGlyph2D New()
		{
			vtkGlyph2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph2D.vtkGlyph2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with scaling on, scaling mode is by scalar value,
		/// scale factor = 1.0, the range is (0,1), orient geometry is on, and
		/// orientation is by vector. Clamping and indexing are turned off. No
		/// initial sources are defined.
		/// </summary>
		// Token: 0x06019296 RID: 103062 RVA: 0x00230F7C File Offset: 0x0022F17C
		public vtkGlyph2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGlyph2D.vtkGlyph2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019297 RID: 103063 RVA: 0x00230FC0 File Offset: 0x0022F1C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019298 RID: 103064
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph2D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x06019299 RID: 103065 RVA: 0x00230FCC File Offset: 0x0022F1CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGlyph2D.vtkGlyph2D_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601929A RID: 103066
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGlyph2D_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0601929B RID: 103067 RVA: 0x00230FEC File Offset: 0x0022F1EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGlyph2D.vtkGlyph2D_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601929C RID: 103068
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph2D_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0601929D RID: 103069 RVA: 0x00231008 File Offset: 0x0022F208
		public override int IsA(string type)
		{
			return vtkGlyph2D.vtkGlyph2D_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601929E RID: 103070
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGlyph2D_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x0601929F RID: 103071 RVA: 0x00231028 File Offset: 0x0022F228
		public new static int IsTypeOf(string type)
		{
			return vtkGlyph2D.vtkGlyph2D_IsTypeOf_04(type);
		}

		// Token: 0x060192A0 RID: 103072
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x060192A1 RID: 103073 RVA: 0x00231044 File Offset: 0x0022F244
		public new vtkGlyph2D NewInstance()
		{
			vtkGlyph2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph2D.vtkGlyph2D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060192A2 RID: 103074
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGlyph2D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing.
		/// </summary>
		// Token: 0x060192A3 RID: 103075 RVA: 0x002310A0 File Offset: 0x0022F2A0
		public new static vtkGlyph2D SafeDownCast(vtkObjectBase o)
		{
			vtkGlyph2D vtkGlyph2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGlyph2D.vtkGlyph2D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGlyph2D = (vtkGlyph2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGlyph2D.Register(null);
				}
			}
			return vtkGlyph2D;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B93 RID: 7059
		public new const string MRFullTypeName = "Kitware.VTK.vtkGlyph2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B94 RID: 7060
		public new static readonly string MRClassNameKey = "class vtkGlyph2D";
	}
}
