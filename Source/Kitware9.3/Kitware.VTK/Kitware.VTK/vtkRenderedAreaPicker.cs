using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRenderedAreaPicker
	/// </summary>
	/// <remarks>
	///    Uses graphics hardware to picks props behind
	/// a selection rectangle on a viewport.
	///
	///
	/// Like vtkAreaPicker, this class picks all props within a selection area
	/// on the screen. The difference is in implementation. This class uses
	/// graphics hardware to perform the test where the other uses software
	/// bounding box/frustum intersection testing.
	///
	/// This picker is more conservative than vtkAreaPicker. It will reject
	/// some objects that pass the bounding box test of vtkAreaPicker. This
	/// will happen, for instance, when picking through a corner of the bounding
	/// box when the data set does not have any visible geometry in that corner.
	/// </remarks>
	// Token: 0x02000815 RID: 2069
	public class vtkRenderedAreaPicker : vtkAreaPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601549C RID: 87196 RVA: 0x001E2701 File Offset: 0x001E0901
		static vtkRenderedAreaPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedAreaPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedAreaPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601549D RID: 87197 RVA: 0x001E2729 File Offset: 0x001E0929
		public vtkRenderedAreaPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601549E RID: 87198
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedAreaPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601549F RID: 87199 RVA: 0x001E2738 File Offset: 0x001E0938
		public new static vtkRenderedAreaPicker New()
		{
			vtkRenderedAreaPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedAreaPicker.vtkRenderedAreaPicker_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedAreaPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154A0 RID: 87200 RVA: 0x001E278C File Offset: 0x001E098C
		public vtkRenderedAreaPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRenderedAreaPicker.vtkRenderedAreaPicker_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060154A1 RID: 87201 RVA: 0x001E27D0 File Offset: 0x001E09D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060154A2 RID: 87202
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedAreaPicker_AreaPick_01(HandleRef pThis, double x0, double y0, double x1, double y1, HandleRef arg4);

		/// <summary>
		/// Perform pick operation in volume behind the given screen coordinates.
		/// Props intersecting the selection frustum will be accessible via GetProp3D.
		/// GetPlanes returns a vtkImplicitFunction suitable for vtkExtractGeometry.
		/// </summary>
		// Token: 0x060154A3 RID: 87203 RVA: 0x001E27DC File Offset: 0x001E09DC
		public override int AreaPick(double x0, double y0, double x1, double y1, vtkRenderer arg4)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_AreaPick_01(base.GetCppThis(), x0, y0, x1, y1, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis());
		}

		// Token: 0x060154A4 RID: 87204
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedAreaPicker_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154A5 RID: 87205 RVA: 0x001E2818 File Offset: 0x001E0A18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060154A6 RID: 87206
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRenderedAreaPicker_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154A7 RID: 87207 RVA: 0x001E2838 File Offset: 0x001E0A38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060154A8 RID: 87208
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedAreaPicker_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154A9 RID: 87209 RVA: 0x001E2854 File Offset: 0x001E0A54
		public override int IsA(string type)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060154AA RID: 87210
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRenderedAreaPicker_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154AB RID: 87211 RVA: 0x001E2874 File Offset: 0x001E0A74
		public new static int IsTypeOf(string type)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_IsTypeOf_05(type);
		}

		// Token: 0x060154AC RID: 87212
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedAreaPicker_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154AD RID: 87213 RVA: 0x001E2890 File Offset: 0x001E0A90
		public new vtkRenderedAreaPicker NewInstance()
		{
			vtkRenderedAreaPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedAreaPicker.vtkRenderedAreaPicker_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedAreaPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060154AE RID: 87214
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRenderedAreaPicker_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154AF RID: 87215 RVA: 0x001E28EC File Offset: 0x001E0AEC
		public new static vtkRenderedAreaPicker SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedAreaPicker vtkRenderedAreaPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRenderedAreaPicker.vtkRenderedAreaPicker_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedAreaPicker = (vtkRenderedAreaPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedAreaPicker.Register(null);
				}
			}
			return vtkRenderedAreaPicker;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001872 RID: 6258
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedAreaPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001873 RID: 6259
		public new static readonly string MRClassNameKey = "class vtkRenderedAreaPicker";
	}
}
