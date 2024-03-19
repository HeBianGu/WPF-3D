using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPointPicker
	/// </summary>
	/// <remarks>
	///    select a point by shooting a ray into a graphics window
	///
	///
	/// vtkPointPicker is used to select a point by shooting a ray into a graphics
	/// window and intersecting with actor's defining geometry - specifically its
	/// points. Beside returning coordinates, actor, and mapper, vtkPointPicker
	/// returns the id of the point projecting closest onto the ray (within the
	/// specified tolerance).  Ties are broken (i.e., multiple points all
	/// projecting within the tolerance along the pick ray) by choosing the point
	/// closest to the ray origin (i.e., closest to the eye).
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPicker vtkCellPicker
	/// </seealso>
	// Token: 0x02000814 RID: 2068
	public class vtkPointPicker : vtkPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015480 RID: 87168 RVA: 0x001E2463 File Offset: 0x001E0663
		static vtkPointPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015481 RID: 87169 RVA: 0x001E248B File Offset: 0x001E068B
		public vtkPointPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015482 RID: 87170
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015483 RID: 87171 RVA: 0x001E249C File Offset: 0x001E069C
		public new static vtkPointPicker New()
		{
			vtkPointPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointPicker.vtkPointPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015484 RID: 87172 RVA: 0x001E24F0 File Offset: 0x001E06F0
		public vtkPointPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPointPicker.vtkPointPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015485 RID: 87173 RVA: 0x001E2534 File Offset: 0x001E0734
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015486 RID: 87174
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015487 RID: 87175 RVA: 0x001E2540 File Offset: 0x001E0740
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPointPicker.vtkPointPicker_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06015488 RID: 87176
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointPicker_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015489 RID: 87177 RVA: 0x001E2560 File Offset: 0x001E0760
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPointPicker.vtkPointPicker_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601548A RID: 87178
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPointPicker_GetPointId_03(HandleRef pThis);

		/// <summary>
		/// Get the id of the picked point. If PointId = -1, nothing was picked.
		/// </summary>
		// Token: 0x0601548B RID: 87179 RVA: 0x001E257C File Offset: 0x001E077C
		public virtual long GetPointId()
		{
			return vtkPointPicker.vtkPointPicker_GetPointId_03(base.GetCppThis());
		}

		// Token: 0x0601548C RID: 87180
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPicker_GetUseCells_04(HandleRef pThis);

		/// <summary>
		/// Specify whether the point search should be based on cell points or
		/// directly on the point list.
		/// </summary>
		// Token: 0x0601548D RID: 87181 RVA: 0x001E259C File Offset: 0x001E079C
		public virtual int GetUseCells()
		{
			return vtkPointPicker.vtkPointPicker_GetUseCells_04(base.GetCppThis());
		}

		// Token: 0x0601548E RID: 87182
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPicker_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601548F RID: 87183 RVA: 0x001E25BC File Offset: 0x001E07BC
		public override int IsA(string type)
		{
			return vtkPointPicker.vtkPointPicker_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06015490 RID: 87184
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPointPicker_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015491 RID: 87185 RVA: 0x001E25DC File Offset: 0x001E07DC
		public new static int IsTypeOf(string type)
		{
			return vtkPointPicker.vtkPointPicker_IsTypeOf_06(type);
		}

		// Token: 0x06015492 RID: 87186
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointPicker_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015493 RID: 87187 RVA: 0x001E25F8 File Offset: 0x001E07F8
		public new vtkPointPicker NewInstance()
		{
			vtkPointPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointPicker.vtkPointPicker_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015494 RID: 87188
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPointPicker_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x06015495 RID: 87189 RVA: 0x001E2654 File Offset: 0x001E0854
		public new static vtkPointPicker SafeDownCast(vtkObjectBase o)
		{
			vtkPointPicker vtkPointPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPointPicker.vtkPointPicker_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPicker = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPicker.Register(null);
				}
			}
			return vtkPointPicker;
		}

		// Token: 0x06015496 RID: 87190
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointPicker_SetUseCells_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether the point search should be based on cell points or
		/// directly on the point list.
		/// </summary>
		// Token: 0x06015497 RID: 87191 RVA: 0x001E26D3 File Offset: 0x001E08D3
		public virtual void SetUseCells(int _arg)
		{
			vtkPointPicker.vtkPointPicker_SetUseCells_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06015498 RID: 87192
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointPicker_UseCellsOff_11(HandleRef pThis);

		/// <summary>
		/// Specify whether the point search should be based on cell points or
		/// directly on the point list.
		/// </summary>
		// Token: 0x06015499 RID: 87193 RVA: 0x001E26E3 File Offset: 0x001E08E3
		public virtual void UseCellsOff()
		{
			vtkPointPicker.vtkPointPicker_UseCellsOff_11(base.GetCppThis());
		}

		// Token: 0x0601549A RID: 87194
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPointPicker_UseCellsOn_12(HandleRef pThis);

		/// <summary>
		/// Specify whether the point search should be based on cell points or
		/// directly on the point list.
		/// </summary>
		// Token: 0x0601549B RID: 87195 RVA: 0x001E26F2 File Offset: 0x001E08F2
		public virtual void UseCellsOn()
		{
			vtkPointPicker.vtkPointPicker_UseCellsOn_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001870 RID: 6256
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001871 RID: 6257
		public new static readonly string MRClassNameKey = "class vtkPointPicker";
	}
}
