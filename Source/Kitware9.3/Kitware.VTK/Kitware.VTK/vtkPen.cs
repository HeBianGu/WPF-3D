using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPen
	/// </summary>
	/// <remarks>
	///    provides a pen that draws the outlines of shapes drawn
	/// by vtkContext2D.
	///
	///
	/// The vtkPen defines the outline of shapes that are drawn by vtkContext2D.
	/// The color is stored as four unsigned chars (RGBA), where the
	/// opacity defaults to 255, but can be modified separately to the other
	/// components. Ideally we would use a lightweight color class to store and pass
	/// around colors.
	/// </remarks>
	// Token: 0x020007B7 RID: 1975
	public class vtkPen : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014446 RID: 83014 RVA: 0x001CA5C3 File Offset: 0x001C87C3
		static vtkPen()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPen.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPen"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014447 RID: 83015 RVA: 0x001CA5EB File Offset: 0x001C87EB
		public vtkPen(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014448 RID: 83016
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPen_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014449 RID: 83017 RVA: 0x001CA5FC File Offset: 0x001C87FC
		public new static vtkPen New()
		{
			vtkPen result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPen.vtkPen_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601444A RID: 83018 RVA: 0x001CA650 File Offset: 0x001C8850
		public vtkPen() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPen.vtkPen_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601444B RID: 83019 RVA: 0x001CA694 File Offset: 0x001C8894
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601444C RID: 83020
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_DeepCopy_01(HandleRef pThis, HandleRef pen);

		/// <summary>
		/// Make a deep copy of the supplied pen.
		/// </summary>
		// Token: 0x0601444D RID: 83021 RVA: 0x001CA6A0 File Offset: 0x001C88A0
		public void DeepCopy(vtkPen pen)
		{
			vtkPen.vtkPen_DeepCopy_01(base.GetCppThis(), (pen == null) ? default(HandleRef) : pen.GetCppThis());
		}

		// Token: 0x0601444E RID: 83022
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_GetColor_02(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Get the color of the brush - expects an unsigned char of length 3.
		/// </summary>
		// Token: 0x0601444F RID: 83023 RVA: 0x001CA6CF File Offset: 0x001C88CF
		public void GetColor(IntPtr color)
		{
			vtkPen.vtkPen_GetColor_02(base.GetCppThis(), color);
		}

		// Token: 0x06014450 RID: 83024
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPen_GetColor_03(HandleRef pThis);

		/// <summary>
		/// Get the color of the brush - gives a pointer to the underlying data.
		/// </summary>
		// Token: 0x06014451 RID: 83025 RVA: 0x001CA6E0 File Offset: 0x001C88E0
		public IntPtr GetColor()
		{
			return vtkPen.vtkPen_GetColor_03(base.GetCppThis());
		}

		// Token: 0x06014452 RID: 83026
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_GetColorF_04(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Get the color of the brush - expects a double of length 3 to copy into.
		/// </summary>
		// Token: 0x06014453 RID: 83027 RVA: 0x001CA6FF File Offset: 0x001C88FF
		public void GetColorF(IntPtr color)
		{
			vtkPen.vtkPen_GetColorF_04(base.GetCppThis(), color);
		}

		// Token: 0x06014454 RID: 83028
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPen_GetColorObject_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the color of the pen.
		/// </summary>
		// Token: 0x06014455 RID: 83029 RVA: 0x001CA710 File Offset: 0x001C8910
		public vtkColor4ub GetColorObject()
		{
			vtkColor4ub result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPen.vtkPen_GetColorObject_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014456 RID: 83030
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPen_GetLineType_06(HandleRef pThis);

		/// <summary>
		/// Get the type of line that the pen will draw.
		/// </summary>
		// Token: 0x06014457 RID: 83031 RVA: 0x001CA76C File Offset: 0x001C896C
		public int GetLineType()
		{
			return vtkPen.vtkPen_GetLineType_06(base.GetCppThis());
		}

		// Token: 0x06014458 RID: 83032
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPen_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014459 RID: 83033 RVA: 0x001CA78C File Offset: 0x001C898C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPen.vtkPen_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601445A RID: 83034
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPen_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601445B RID: 83035 RVA: 0x001CA7AC File Offset: 0x001C89AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPen.vtkPen_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601445C RID: 83036
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPen_GetOpacity_09(HandleRef pThis);

		/// <summary>
		/// Get the opacity (unsigned char), ranging from 0 (transparent) to 255
		/// (opaque).
		/// </summary>
		// Token: 0x0601445D RID: 83037 RVA: 0x001CA7C8 File Offset: 0x001C89C8
		public byte GetOpacity()
		{
			return vtkPen.vtkPen_GetOpacity_09(base.GetCppThis());
		}

		// Token: 0x0601445E RID: 83038
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkPen_GetWidth_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the width of the pen.
		/// </summary>
		// Token: 0x0601445F RID: 83039 RVA: 0x001CA7E8 File Offset: 0x001C89E8
		public virtual float GetWidth()
		{
			return vtkPen.vtkPen_GetWidth_10(base.GetCppThis());
		}

		// Token: 0x06014460 RID: 83040
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPen_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014461 RID: 83041 RVA: 0x001CA808 File Offset: 0x001C8A08
		public override int IsA(string type)
		{
			return vtkPen.vtkPen_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06014462 RID: 83042
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPen_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014463 RID: 83043 RVA: 0x001CA828 File Offset: 0x001C8A28
		public new static int IsTypeOf(string type)
		{
			return vtkPen.vtkPen_IsTypeOf_12(type);
		}

		// Token: 0x06014464 RID: 83044
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPen_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014465 RID: 83045 RVA: 0x001CA844 File Offset: 0x001C8A44
		public new vtkPen NewInstance()
		{
			vtkPen result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPen.vtkPen_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014466 RID: 83046
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPen_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014467 RID: 83047 RVA: 0x001CA8A0 File Offset: 0x001C8AA0
		public new static vtkPen SafeDownCast(vtkObjectBase o)
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPen.vtkPen_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		// Token: 0x06014468 RID: 83048
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColor_16(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set the color of the brush with three component unsigned chars (RGB),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x06014469 RID: 83049 RVA: 0x001CA91F File Offset: 0x001C8B1F
		public void SetColor(IntPtr color)
		{
			vtkPen.vtkPen_SetColor_16(base.GetCppThis(), color);
		}

		// Token: 0x0601446A RID: 83050
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColor_17(HandleRef pThis, byte r, byte g, byte b);

		/// <summary>
		/// Set the color of the brush with three component unsigned chars (RGB),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x0601446B RID: 83051 RVA: 0x001CA92F File Offset: 0x001C8B2F
		public void SetColor(byte r, byte g, byte b)
		{
			vtkPen.vtkPen_SetColor_17(base.GetCppThis(), r, g, b);
		}

		// Token: 0x0601446C RID: 83052
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColor_18(HandleRef pThis, byte r, byte g, byte b, byte a);

		/// <summary>
		/// Set the color of the brush with four component unsigned chars (RGBA),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x0601446D RID: 83053 RVA: 0x001CA941 File Offset: 0x001C8B41
		public void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPen.vtkPen_SetColor_18(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x0601446E RID: 83054
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColor_19(HandleRef pThis, HandleRef color);

		/// <summary>
		/// Set the color of the brush with four component unsigned chars (RGBA),
		/// ranging from 0 to 255.
		/// </summary>
		// Token: 0x0601446F RID: 83055 RVA: 0x001CA958 File Offset: 0x001C8B58
		public void SetColor(vtkColor4ub color)
		{
			vtkPen.vtkPen_SetColor_19(base.GetCppThis(), (color == null) ? default(HandleRef) : color.GetCppThis());
		}

		// Token: 0x06014470 RID: 83056
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColorF_20(HandleRef pThis, IntPtr color);

		/// <summary>
		/// Set the color of the brush with three component doubles (RGB), ranging from
		/// 0.0 to 1.0.
		/// </summary>
		// Token: 0x06014471 RID: 83057 RVA: 0x001CA987 File Offset: 0x001C8B87
		public void SetColorF(IntPtr color)
		{
			vtkPen.vtkPen_SetColorF_20(base.GetCppThis(), color);
		}

		// Token: 0x06014472 RID: 83058
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColorF_21(HandleRef pThis, double r, double g, double b);

		/// <summary>
		/// Set the color of the brush with three component doubles (RGB), ranging from
		/// 0.0 to 1.0.
		/// </summary>
		// Token: 0x06014473 RID: 83059 RVA: 0x001CA997 File Offset: 0x001C8B97
		public void SetColorF(double r, double g, double b)
		{
			vtkPen.vtkPen_SetColorF_21(base.GetCppThis(), r, g, b);
		}

		// Token: 0x06014474 RID: 83060
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetColorF_22(HandleRef pThis, double r, double g, double b, double a);

		/// <summary>
		/// Set the color of the brush with four component doubles (RGBA), ranging from
		/// 0.0 to 1.0.
		/// </summary>
		// Token: 0x06014475 RID: 83061 RVA: 0x001CA9A9 File Offset: 0x001C8BA9
		public void SetColorF(double r, double g, double b, double a)
		{
			vtkPen.vtkPen_SetColorF_22(base.GetCppThis(), r, g, b, a);
		}

		// Token: 0x06014476 RID: 83062
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetLineType_23(HandleRef pThis, int type);

		/// <summary>
		/// Set the type of line that the pen should draw. The default is solid (1).
		/// </summary>
		// Token: 0x06014477 RID: 83063 RVA: 0x001CA9BD File Offset: 0x001C8BBD
		public void SetLineType(int type)
		{
			vtkPen.vtkPen_SetLineType_23(base.GetCppThis(), type);
		}

		// Token: 0x06014478 RID: 83064
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetOpacity_24(HandleRef pThis, byte a);

		/// <summary>
		/// Set the opacity with an unsigned char, ranging from 0 (transparent) to 255
		/// (opaque).
		/// </summary>
		// Token: 0x06014479 RID: 83065 RVA: 0x001CA9CD File Offset: 0x001C8BCD
		public void SetOpacity(byte a)
		{
			vtkPen.vtkPen_SetOpacity_24(base.GetCppThis(), a);
		}

		// Token: 0x0601447A RID: 83066
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetOpacityF_25(HandleRef pThis, double a);

		/// <summary>
		/// Set the opacity with a double, ranging from 0.0 (transparent) to 1.0
		/// (opaque).
		/// </summary>
		// Token: 0x0601447B RID: 83067 RVA: 0x001CA9DD File Offset: 0x001C8BDD
		public void SetOpacityF(double a)
		{
			vtkPen.vtkPen_SetOpacityF_25(base.GetCppThis(), a);
		}

		// Token: 0x0601447C RID: 83068
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPen_SetWidth_26(HandleRef pThis, float _arg);

		/// <summary>
		/// Set/Get the width of the pen.
		/// </summary>
		// Token: 0x0601447D RID: 83069 RVA: 0x001CA9ED File Offset: 0x001C8BED
		public virtual void SetWidth(float _arg)
		{
			vtkPen.vtkPen_SetWidth_26(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001782 RID: 6018
		public new const string MRFullTypeName = "Kitware.VTK.vtkPen";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001783 RID: 6019
		public new static readonly string MRClassNameKey = "class vtkPen";

		/// <summary>
		/// Enum of the available line types.
		/// </summary>
		// Token: 0x020007B8 RID: 1976
		public enum DASH_DOT_DOT_LINE_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001785 RID: 6021
			DASH_DOT_DOT_LINE = 5,
			/// <summary>enum member</summary>
			// Token: 0x04001786 RID: 6022
			DASH_DOT_LINE = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001787 RID: 6023
			DASH_LINE = 2,
			/// <summary>enum member</summary>
			// Token: 0x04001788 RID: 6024
			DENSE_DOT_LINE = 6,
			/// <summary>enum member</summary>
			// Token: 0x04001789 RID: 6025
			DOT_LINE = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400178A RID: 6026
			NO_PEN = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400178B RID: 6027
			SOLID_LINE
		}
	}
}
