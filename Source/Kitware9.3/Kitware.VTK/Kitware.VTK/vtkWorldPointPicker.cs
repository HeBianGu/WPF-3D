using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWorldPointPicker
	/// </summary>
	/// <remarks>
	///    find world x,y,z corresponding to display x,y,z
	///
	/// vtkWorldPointPicker is used to find the x,y,z world coordinate of a
	/// screen x,y,z. This picker cannot pick actors and/or mappers, it
	/// simply determines an x-y-z coordinate in world space. (It will always
	/// return a x-y-z, even if the selection point is not over a prop/actor.)
	///
	/// @warning
	/// The PickMethod() is not invoked, but StartPickMethod() and EndPickMethod()
	/// are.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPropPicker vtkPicker vtkCellPicker vtkPointPicker
	/// </seealso>
	// Token: 0x02000813 RID: 2067
	public class vtkWorldPointPicker : vtkAbstractPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601546A RID: 87146 RVA: 0x001E21BF File Offset: 0x001E03BF
		static vtkWorldPointPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWorldPointPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWorldPointPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601546B RID: 87147 RVA: 0x001E21E7 File Offset: 0x001E03E7
		public vtkWorldPointPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601546C RID: 87148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWorldPointPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601546D RID: 87149 RVA: 0x001E21F8 File Offset: 0x001E03F8
		public new static vtkWorldPointPicker New()
		{
			vtkWorldPointPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWorldPointPicker.vtkWorldPointPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWorldPointPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601546E RID: 87150 RVA: 0x001E224C File Offset: 0x001E044C
		public vtkWorldPointPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWorldPointPicker.vtkWorldPointPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601546F RID: 87151 RVA: 0x001E2290 File Offset: 0x001E0490
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015470 RID: 87152
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWorldPointPicker_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015471 RID: 87153 RVA: 0x001E229C File Offset: 0x001E049C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06015472 RID: 87154
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWorldPointPicker_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015473 RID: 87155 RVA: 0x001E22BC File Offset: 0x001E04BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06015474 RID: 87156
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWorldPointPicker_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015475 RID: 87157 RVA: 0x001E22D8 File Offset: 0x001E04D8
		public override int IsA(string type)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06015476 RID: 87158
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWorldPointPicker_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015477 RID: 87159 RVA: 0x001E22F8 File Offset: 0x001E04F8
		public new static int IsTypeOf(string type)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_IsTypeOf_04(type);
		}

		// Token: 0x06015478 RID: 87160
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWorldPointPicker_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015479 RID: 87161 RVA: 0x001E2314 File Offset: 0x001E0514
		public new vtkWorldPointPicker NewInstance()
		{
			vtkWorldPointPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWorldPointPicker.vtkWorldPointPicker_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWorldPointPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601547A RID: 87162
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWorldPointPicker_Pick_07(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		/// <summary>
		/// Perform the pick. (This method overload's the superclass.)
		/// </summary>
		// Token: 0x0601547B RID: 87163 RVA: 0x001E2370 File Offset: 0x001E0570
		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_Pick_07(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0601547C RID: 87164
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWorldPointPicker_Pick_08(HandleRef pThis, IntPtr selectionPt, HandleRef renderer);

		/// <summary>
		/// Perform the pick. (This method overload's the superclass.)
		/// </summary>
		// Token: 0x0601547D RID: 87165 RVA: 0x001E23AC File Offset: 0x001E05AC
		public new int Pick(IntPtr selectionPt, vtkRenderer renderer)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_Pick_08(base.GetCppThis(), selectionPt, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		// Token: 0x0601547E RID: 87166
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWorldPointPicker_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601547F RID: 87167 RVA: 0x001E23E4 File Offset: 0x001E05E4
		public new static vtkWorldPointPicker SafeDownCast(vtkObjectBase o)
		{
			vtkWorldPointPicker vtkWorldPointPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWorldPointPicker.vtkWorldPointPicker_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWorldPointPicker = (vtkWorldPointPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWorldPointPicker.Register(null);
				}
			}
			return vtkWorldPointPicker;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400186E RID: 6254
		public new const string MRFullTypeName = "Kitware.VTK.vtkWorldPointPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400186F RID: 6255
		public new static readonly string MRClassNameKey = "class vtkWorldPointPicker";
	}
}
